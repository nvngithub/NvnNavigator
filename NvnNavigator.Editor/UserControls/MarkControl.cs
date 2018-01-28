using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using NvnNavigator.Common;

namespace NvnNavigator.Editor {
    public partial class MarkControl : UserControl {
        private Image mapImage;
        private Image currentPositionImage; // TODO: delete this variable as it is unused
        private Image searchPositionImage; // TODO: delete this variable as it is unused
        private Graphics graphics;

        private Pen bluePen = new Pen(Color.Blue, Globals.LineThinkness);
        private Pen purplePen = new Pen(Color.Purple, Globals.LineThinkness);
        private Pen redPen = new Pen(Color.Red, Globals.NavigatorPointThickness);

        private NavigatorPath selectedNavigatorPath;
        private MapPath currentPath; // used while drawing lines
        private List<MapPath> currentMapPaths = new List<MapPath>(); // all paths drawn on current map

        public MarkControl() {
            InitializeComponent();
        }

        #region Event handlers
        private void btnMaps_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(Globals.ProjectFile) == false) {
                MapsForm mapsForm = new MapsForm();
                mapsForm.LoadMapsToGrid();
                if (mapsForm.ShowDialog() == DialogResult.OK) {
                    LoadMapsList();
                }
            } else {
                MessageBox.Show("Please load project file");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(Globals.ProjectFile) == false) {
                int index = cmbMaps.SelectedIndex;

                LoadMapsList();

                cmbMaps.SelectedIndex = index;
            }
        }

        private void cmbMaps_SelectedIndexChanged(object sender, EventArgs e) {
            LoadSelectedMap();
            LoadMapPaths();
        }

        private void lbkClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            // delete map path assigned to the navigator path
            if (MessageBox.Show("Are you sure you want to delete map path assigned to navigator path ?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                if (selectedNavigatorPath != null && cmbMaps.SelectedItem != null) {
                    Map selectedMap = (Map)cmbMaps.SelectedItem;
                    for (int i = 0; i < selectedMap.PathIds.Count; i++) {
                        if (selectedMap.PathIds[i] == selectedNavigatorPath.Id) {
                            selectedMap.PathIds.RemoveAt(i);
                            break;
                        }
                    }

                    SaveMaps();

                    LoadMapPaths();
                }
            }
        }

        private void lnkClearAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            // delete all map path in the selected map image
            if (MessageBox.Show("Are you sure you want to delete ALL map path assigned to navigator path ?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                if (cmbMaps.SelectedItem != null) {
                    Map selectedMap = (Map)cmbMaps.SelectedItem;
                    selectedMap.PathIds.Clear();

                    SaveMaps();

                    LoadSelectedMap();

                    LoadMapPaths();
                }
            }
        }

        private void lblDeleteUnused_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            DeleteUnusedPathFiles();
        }
        #endregion

        #region Private methods
        public void SetSelectedNavigatorPath(NavigatorPath navigatorPath) {
            selectedNavigatorPath = navigatorPath;
            LoadMapPaths();
        }

        public void LoadMapsList() {
            int index = cmbMaps.SelectedIndex;
            cmbMaps.Items.Clear();
            List<Map> maps = LoadSave.LoadMaps(Globals.ProjectFile);
            if (maps != null) {
                foreach (Map map in maps) {
                    cmbMaps.Items.Add(map);
                }
                cmbMaps.SelectedIndex = index;
            }
        }

        private void LoadSelectedMap() {
            if (cmbMaps.SelectedItem != null) {
                // TODO: use global method available
                Map selectedMap = (Map)cmbMaps.Items[cmbMaps.SelectedIndex];
                string filename = Globals.MapsDir + selectedMap.Name;
                mapImage = Image.FromFile(filename);
                graphics = Graphics.FromImage(mapImage);
                pbMap.Size = mapImage.Size;
                pbMap.Image = mapImage;
            }
        }

        private void LoadMapPaths() {
            if (cmbMaps.SelectedItem != null) {
                Map selectedMap = (Map)cmbMaps.SelectedItem;
                currentMapPaths.Clear();
                foreach (string pathId in selectedMap.PathIds.ToArray()) {
                    MapPath path = LoadSave.LoadMapPath(Globals.MapPathsDir + pathId);
                    if (path == null) {
                        selectedMap.PathIds.Remove(pathId);// remove from the object list if corresponding file not found
                    } else {
                        currentMapPaths.Add(path);
                        DrawPath(path, selectedNavigatorPath != null && selectedNavigatorPath.Id == pathId ? purplePen : bluePen);
                    }
                }
            }
        }

        private void DrawPath(MapPath mapPath, Pen pen) {
            // Draw map path points
            foreach (MapPoint point in mapPath.Points) {
                DrawPoint(point.X, point.Y, pen);
            }

            DrawNavigatorPoints(mapPath);

            pbMap.Refresh();
        }

        private void DrawNavigatorPoints(MapPath mapPath) {
            if (mapPath.Points.Count < selectedNavigatorPath.Points.Count) return;

            int difference = (int)Math.Floor((double)mapPath.Points.Count / selectedNavigatorPath.Points.Count);
            for (int i = 0; i < mapPath.Points.Count; i = i + difference) {
                DrawPoint(mapPath.Points[i].X, mapPath.Points[i].Y, redPen);
            }
        }

        private void DrawPoint(int x, int y, Pen pen) {
            graphics.DrawRectangle(pen, x, y, 1, 1);
        }

        private void DrawImage(int x, int y, Image image) {
            if (graphics != null) {
                graphics.DrawImage(image, new Point(x, y));
                pbMap.Refresh();
            }
        }

        private void SaveMapPath(MapPath mapPath) {
            if (String.IsNullOrEmpty(Globals.ProjectFile) == false) {
                if (Directory.Exists(Globals.MapPathsDir) == false) {
                    Directory.CreateDirectory(Globals.MapPathsDir);
                }

                LoadSave.SaveMapPath(mapPath, Globals.MapPathsDir + mapPath.Id);
            } else {
                MessageBox.Show("Please load project file.");
            }
        }

        private void SaveMaps() {
            List<Map> maps = new List<Map>();
            foreach (Map map in cmbMaps.Items) {
                maps.Add(map);
            }

            LoadSave.SaveMaps(maps, Globals.ProjectFile);

            DeleteUnusedPathFiles();
        }

        private void DeleteUnusedPathFiles() {
            List<string> ids = new List<string>();
            foreach (Map map in cmbMaps.Items) {
                foreach (string pathId in map.PathIds) {
                    ids.Add(pathId);
                }
            }
            string[] pathFiles = Directory.GetFiles(Globals.MapPathsDir);
            foreach (string pathFile in pathFiles) {
                if (ids.Contains(Path.GetFileName(pathFile)) == false) {
                    File.Delete(pathFile);
                }
            }
        }

        private MapPoint IsMouseOnTheLine(int x, int y) {
            foreach (MapPath mapPath in currentMapPaths) {
                foreach (MapPoint mapPoint in mapPath.Points) {
                    if ((mapPoint.X <= (x + 5) && mapPoint.X >= (x - 5)) && (mapPoint.Y <= (y + 5) && mapPoint.Y >= (y - 5))) {
                        return mapPoint;
                    }
                }
            }
            return null;
        }
        #endregion

        #region Mouse events
        private void pbMap_MouseClick(object sender, MouseEventArgs e) {
            MapPoint mapPoint = IsMouseOnTheLine(e.X, e.Y);
            if (mapPoint != null) {
                foreach (MapPath mapPath in currentMapPaths) {
                    if (mapPath.Points.Contains(mapPoint)) {
                        // find nearest navigator point
                        int difference = (int)Math.Floor((double)mapPath.Points.Count / selectedNavigatorPath.Points.Count);
                        int index = (int)Math.Floor((double)mapPath.Points.IndexOf(mapPoint) / difference) * difference;
                        index += difference * (mapPath.Points.IndexOf(mapPoint) % difference > (difference / 2) ? 1 : 0);
                        MapPoint nearestPoint = mapPath.Points[index];
                        DrawImage(nearestPoint.X - 7, nearestPoint.Y - 7, searchPositionImage);
                        break;
                    }
                }
            }
        }

        private void pbMap_MouseUp(object sender, MouseEventArgs e) {
            if (currentPath != null) {
                SaveMapPath(currentPath);

                SaveMaps(); // this is needed because maps.xml stores all path ids

                DrawNavigatorPoints(currentPath);

                pbMap.Refresh();
            }

            currentPath = null;
        }

        private void pbMap_MouseMove(object sender, MouseEventArgs e) {
            this.Cursor = IsMouseOnTheLine(e.X, e.Y) != null ? Cursors.Hand : Cursors.Default;

            if (graphics != null && selectedNavigatorPath != null && cmbMaps.SelectedItem != null) {
                lblLocation.Text = e.X + ", " + e.Y;
                if (e.Button == MouseButtons.Left) {
                    if (currentPath == null) {
                        Map selectedMap = (Map)cmbMaps.SelectedItem;
                        foreach (string pathId in selectedMap.PathIds.ToArray()) {
                            if (pathId == selectedNavigatorPath.Id) {
                                selectedMap.PathIds.Remove(pathId);
                                if (File.Exists(Globals.MapPathsDir + pathId)) {
                                    File.Delete(Globals.MapPathsDir + pathId);
                                }
                                break;
                            }
                        }

                        LoadSelectedMap();
                        LoadMapPaths();

                        currentPath = new MapPath();
                        currentPath.Id = selectedNavigatorPath.Id;
                        selectedMap.PathIds.Add(selectedNavigatorPath.Id);
                    }

                    MapPoint pnt = new MapPoint();
                    pnt.X = e.X;
                    pnt.Y = e.Y;

                    if (currentPath != null) {
                        currentPath.Points.Add(pnt);
                    }

                    DrawPoint(e.X, e.Y, purplePen);

                    pbMap.Refresh();
                }
            }
        }
        #endregion
    }
}