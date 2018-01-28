using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using NvnNavigator.Common.Properties;

namespace NvnNavigator.Common {
    public partial class NavigatorMapCtrl : UserControl {

        private Image actualMapImage;
        private Image loadedMapImage;
        private Graphics graphics;
        private Pen bluePen = new Pen(Color.Blue, Globals.LineThinkness);

        private Image youareHerePositionImage;
        private Image currentPositionImage;
        private Image searchPositionImage;

        private NavigatorPoint youareHerePoint;
        private NavigatorPoint currentPositionPoint;
        private NavigatorPoint searchPositionPoint;

        private int currentX;
        private int currentY;
        private int mouseDownX;
        private int mouseDownY;
        private bool mouseDown = false;
        private bool isMouseIn = false;

        private int zoomIndex = 0;
        private int zoomIncrement = 50;

        private Map selectedMap;
        private List<Map> maps;
        private List<MapPath> currentMapPaths = new List<MapPath>(); // all paths drawn on current map
        private Dictionary<string, NavigatorPath> currentNavigatorPaths = new Dictionary<string, NavigatorPath>();

        public NavigatorMapCtrl() {
            InitializeComponent();

            ResourceManager res = new ResourceManager(typeof(Resources));
            youareHerePositionImage = (Bitmap)res.GetObject("youarehere");
            currentPositionImage = (Bitmap)res.GetObject("currentlocstar");
            searchPositionImage = (Bitmap)res.GetObject("searchstar");

            floorsCtrl.FloorSelected += new EventHandler(floorsCtrl_FloorSelected);
        }

        #region Public Methods

        public void LoadMaps() {
            maps = LoadSave.LoadMaps(Globals.ProjectFile);

            floorsCtrl.LoadFloors(maps);

            if (maps != null && maps.Count > 0) {
                LoadSelectedMap(maps[0]); // TODO: Default map can be different, not just the first one
                floorsCtrl.SelectedMap = maps[0];
            }
        }

        public void UpdateLocation(NavigatorPoint point, MapLocationImageType imageType) {
            if (imageType == MapLocationImageType.CurrentLocation) currentPositionPoint = point;
            else if (imageType == MapLocationImageType.Search) searchPositionPoint = point;
            else if (imageType == MapLocationImageType.YouAreHere) youareHerePoint = point;

            if (selectedMap != null) {
                LoadSelectedMap(selectedMap);
            }
        }

        #endregion

        #region Private Methods

        private void LoadSelectedMap(Map map) {
            selectedMap = map;
            // load map
            string filename = Globals.MapsDir + map.Name;
            actualMapImage = ImageLoader.GetImageFromFile(filename);

            loadedMapImage = ImageLoader.GetImageFromFile(filename, pbMap.Width + (zoomIndex * zoomIncrement), pbMap.Height + (zoomIndex * zoomIncrement));
            graphics = Graphics.FromImage(loadedMapImage);

            // draw all lines
            LoadMapPaths(map);

            // draw stars
            LoadMapStars();

            pbMap.Image = GetDisplayImage();
        }

        private void LoadMapPaths(Map map) {
            currentMapPaths.Clear();
            foreach (string pathId in map.PathIds.ToArray()) {
                MapPath path = LoadSave.LoadMapPath(Globals.MapPathsDir + pathId);
                if (path != null) {
                    currentMapPaths.Add(path);

                    if (Globals.IsDebugMode) {
                        DrawPath(path, bluePen);
                    }
                } else {
                    throw new Exception("MapPath returned is null. This should ne ver happen. Please contact administrator.");
                }
            }

            // Load navigator paths in the current map
            currentNavigatorPaths.Clear();
            foreach (string pathId in map.PathIds.ToArray()) {
                foreach (NavigatorPath path in Globals.NavigatorPlace.Paths) {
                    if (path.Id == pathId) {
                        currentNavigatorPaths.Add(pathId, path);
                        break;
                    }
                }
            }
        }

        private void LoadMapStars() {
            if (youareHerePoint != null) {
                Point? point = GetMapPointForNaviatorPoint(youareHerePoint);
                if (point.HasValue) {
                    DrawImage(point.Value.X, point.Value.Y, youareHerePositionImage);
                }
            }

            if (currentPositionPoint != null) {
                Point? point = GetMapPointForNaviatorPoint(currentPositionPoint);
                if (point.HasValue) {
                    DrawImage(point.Value.X, point.Value.Y, currentPositionImage);
                }
            }

            if (searchPositionPoint != null) {
                Point? point = GetMapPointForNaviatorPoint(searchPositionPoint);
                if (point.HasValue) {
                    DrawImage(point.Value.X, point.Value.Y, searchPositionImage);
                }
            }
        }

        // Get portion of image to be shown on picture box
        private Image GetDisplayImage() {
            return GetDisplayImage(0, 0);
        }

        private Image GetDisplayImage(int x, int y) {
            currentX = x; currentY = y;

            Bitmap bmpImage = new Bitmap(loadedMapImage);
            Bitmap bmpCrop = bmpImage.Clone(new Rectangle(x, y, pbMap.Width, pbMap.Height), bmpImage.PixelFormat);
            return (Image)(bmpCrop);
        }

        private void DrawPath(MapPath mapPath, Pen pen) {
            // Draw map path points
            foreach (MapPoint point in mapPath.Points) {
                float x = point.X * ((float)(pbMap.Width + (zoomIndex * zoomIncrement)) / actualMapImage.Width);
                float y = point.Y * ((float)(pbMap.Height + (zoomIndex * zoomIncrement)) / actualMapImage.Height);

                DrawPoint(x, y, pen);
            }

            pbMap.Refresh();
        }

        private void DrawPoint(float x, float y, Pen pen) {
            graphics.DrawRectangle(pen, x, y, 1, 1);
        }

        private void DrawImage(int x, int y, Image image) {
            if (graphics != null) {
                float X = x * ((float)(pbMap.Width + (zoomIndex * zoomIncrement)) / actualMapImage.Width);
                float Y = y * ((float)(pbMap.Height + (zoomIndex * zoomIncrement)) / actualMapImage.Height);
                graphics.DrawImage(image, X, Y);
                pbMap.Refresh();
            }
        }

        //private MapPoint IsMouseOnTheLine(int x, int y) {
        //    foreach (MapPath mapPath in currentMapPaths) {
        //        foreach (MapPoint mapPoint in mapPath.Points) {
        //            float mapx = mapPoint.X * ((float)(pbMap.Width + (zoomIndex * zoomIncrement)) / actualMapImage.Width);
        //            float mapy = mapPoint.Y * ((float)(pbMap.Height + (zoomIndex * zoomIncrement)) / actualMapImage.Height);
        //            if ((mapx <= (x + 5) && mapx >= (x - 5)) && (mapy <= (y + 5) && mapy >= (y - 5))) {
        //                return mapPoint;
        //            }
        //        }
        //    }
        //    return null;
        //}

        //private NavigatorPath GetNavigatorPath(string id) {
        //    if (NavigatorPlace.Place != null) {
        //        foreach (NavigatorPath path in NavigatorPlace.Place.Paths) {
        //            if (path.Id == id) {
        //                return path;
        //            }
        //        }
        //    }

        //    return null;
        //}

        private Point? GetMapPointForNaviatorPoint(NavigatorPoint navigatorPoint) {
            foreach (NavigatorPath path in currentNavigatorPaths.Values) {
                if (path.Points.Contains(navigatorPoint)) {
                    foreach (MapPath mapPath in currentMapPaths) {
                        if (mapPath.Id == path.Id) {
                            int index = path.Points.IndexOf(navigatorPoint) * (int)Math.Floor((decimal)mapPath.Points.Count / (path.Points.Count - 1));
                            index += path.Points.IndexOf(navigatorPoint) == path.Points.Count - 1 ? -1 : 0;
                            return new Point(mapPath.Points[index].X, mapPath.Points[index].Y);
                        }
                    }
                }
            }

            return null;
        }

        #endregion

        #region Event Handlers

        private void NavigatorMapCtrl_Resize(object sender, EventArgs e) {
            if (selectedMap != null) {
                LoadSelectedMap(selectedMap); // Load map and draw path again
            }
        }

        void floorsCtrl_FloorSelected(object floor, EventArgs e) {
            foreach (Map map in maps) {
                if (map.Floor == (string)floor) {
                    LoadSelectedMap(map);
                    floorsCtrl.SelectedMap = map;
                    break;
                }
            }
        }

        private void pbMap_MouseClick(object sender, MouseEventArgs e) {
            //MapPoint mapPoint = IsMouseOnTheLine(e.X, e.Y);
            //if (mapPoint != null) {
            //    foreach (MapPath mapPath in currentMapPaths) {
            //        if (mapPath.Points.Contains(mapPoint)) {
            //            NavigatorPath selectedNavigatorPath = GetNavigatorPath(mapPath.Id);
            //            if (selectedNavigatorPath != null) {
            //                // find nearest navigator point
            //                int difference = (int)Math.Floor((double)mapPath.Points.Count / selectedNavigatorPath.Points.Count);
            //                int index = (int)Math.Floor((double)mapPath.Points.IndexOf(mapPoint) / difference) * difference;
            //                index += difference * (mapPath.Points.IndexOf(mapPoint) % difference > (difference / 2) ? 1 : 0);
            //                MapPoint nearestPoint = mapPath.Points[index];
            //                DrawImage(nearestPoint.X - 7, nearestPoint.Y - 7, searchPositionImage);
            //                break;
            //            }
            //        }
            //    }
            //}
        }

        private void pbMap_MouseEnter(object sender, EventArgs e) {
            isMouseIn = true;
        }

        private void pbMap_MouseLeave(object sender, EventArgs e) {
            isMouseIn = false;
        }

        // Zoom-In, Zoom-Out image
        public void MouseWheelMoved(MouseEventArgs e) {
            if (isMouseIn) {
                zoomIndex = zoomIndex + (int)(e.Delta / 120);

                LoadSelectedMap(selectedMap);
            }
        }

        private void pbMap_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = true;
            mouseDownX = e.X;
            mouseDownY = e.Y;
            this.Cursor = Cursors.SizeAll;
        }

        private void pbMap_MouseUp(object sender, MouseEventArgs e) {
            mouseDown = false;
            mouseDownX = mouseDownY = 0;
            this.Cursor = Cursors.Default;
        }

        // Used when user try to drag image
        private void pbMap_MouseMove(object sender, MouseEventArgs e) {
            if (mouseDown) {
                // get piece from loaded image which is to be shown in picture box
                int x = currentX + mouseDownX - e.X;
                int y = currentY + mouseDownY - e.Y;

                mouseDownX = e.X;
                mouseDownY = e.Y;

                if (x >= 0 && y >= 0 && x < loadedMapImage.Width - pbMap.Width && y < loadedMapImage.Height - pbMap.Height) {
                    pbMap.Image = GetDisplayImage(x, y);
                    pbMap.Refresh();
                }
            }
        }

        #endregion
    }
}