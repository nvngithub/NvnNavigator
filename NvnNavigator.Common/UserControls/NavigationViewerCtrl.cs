using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Threading;

namespace NvnNavigator.Common {
    public partial class NavigationViewerCtrl : UserControl {

        public event EventHandler ImageChanged;
        public event EventHandler<NavigatorPositionChangedEventArgs> PositionChanged;

        private string imagePath; // TODO: remove this. use Globals
        private string currentImagePath;

        private int minArrowLength = 20, arrowLength = 15, radius;
        int centerX, centerY;

        private NavigatorPlace currentPlace;
        private NavigatorPath currentPath;
        private NavigatorPoint currentPoint;
        private int currentIndex;
        private int currentAngle;

        private const int WM_KEYDOWN = 0x100;
        private const int WM_SYSKEYDOWN = 0x104;

        public NavigationViewerCtrl() {
            InitializeComponent();
        }

        public NavigatorPlace CurrentPlace {
            get { return currentPlace; }
            set { currentPlace = value; }
        }

        public NavigatorPath CurrentPath {
            get { return currentPath; }
            set { currentPath = value; }
        }

        public NavigatorPoint CurrentPoint {
            get { return currentPoint; }
            set { currentPoint = value; }
        }

        public int CurrentAngle {
            get { return currentAngle; }
            set { currentAngle = value; }
        }

        public string CurrentImagePath {
            get { return currentImagePath; }
        }

        public string ProjectImagePath {
            set { imagePath = value; }
        }

        public void StartViewer() {
            LoadImage();
        }

        public void RefreshCurrentImage() {
            LoadImage();
        }

        #region Search and navigate
        public void SearchAndNavigate(HotspotLocation location) {
            List<string> paths = NavigatorSearch.Search(currentPath, location.GetNavigatorPoint());

            // navigate to hotspot location
            Thread searchNavigateThread = new Thread(new ParameterizedThreadStart(SearchNavigateThread));
            searchNavigateThread.IsBackground = true;
            searchNavigateThread.Start(new object[] { paths, location });
        }

        private void SearchNavigateThread(object o) {
            List<string> paths = (List<string>)((object[])o)[0];
            HotspotLocation location = (HotspotLocation)((object[])o)[1];

            SearchShowPath(currentPath, location, paths);
        }

        private void SearchShowPath(NavigatorPath path, HotspotLocation location, List<string> searchPaths) {
            // show points
            for (int i = 0; i < path.Points.Count; i++) {
                NavigatorPoint point = path.Points[i];

                SearchShowPoint(point, path.Id);

                // if current point is the one looking for
                if (point.Id == location.GetNavigatorPoint().Id) {
                    // TODO: turn and show as given in HotspotLocation
                    return;
                }
            }

            // connent to another path
            List<JunctionPoint> junctionPoints = path.Points[path.Points.Count - 1].JunctionPoints;
            if (junctionPoints != null) {
                foreach (JunctionPoint junctionPoint in junctionPoints) {
                    if (searchPaths.Contains(junctionPoint.Path.Id)) {
                        SearchShowPath(junctionPoint.Path, location, searchPaths);
                    }
                }
            }
        }

        private void SearchShowPoint(NavigatorPoint point, string pathId) {
            Image img = GetImage(point.Img1, pathId);
            pbNavigationImage.Image = img;

            //TODO: draw direction

            pbNavigationImage.Refresh();
        }
        #endregion

        private void btnLoadProject_Click(object sender, EventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK) {
                currentPlace = LoadSave.Load(dlg.FileName);
                imagePath = Path.GetDirectoryName(dlg.FileName) + "\\images";

                currentPath = currentPlace.Paths[0];
                currentPoint = currentPath.Points[0];
                currentAngle = 0;

                LoadImage();
            }
        }

        private void btnForward_Click(object sender, EventArgs e) {
            Navigate(NavigateDirection.Forward);
        }

        private void btnBackward_Click(object sender, EventArgs e) {
            Navigate(NavigateDirection.Backward);
        }

        private void btnLeft_Click(object sender, EventArgs e) {
            Navigate(NavigateDirection.Left);
        }

        private void btnRight_Click(object sender, EventArgs e) {
            Navigate(NavigateDirection.Right);
        }

        private void Navigate(NavigateDirection direction) {
            if (direction == NavigateDirection.Left) {
                currentAngle = GetNextAngle(currentAngle, currentPoint);
            } else if (direction == NavigateDirection.Right) {
                currentAngle = GetPrevAngle(currentAngle, currentPoint);
            } else if (direction == NavigateDirection.Forward) {
                currentPoint = GetNextPoint(currentPoint, currentPath);
            } else if (direction == NavigateDirection.Backward) {
                currentPoint = GetPrevPoint(currentPoint, currentPath);
            }

            LoadImage();
        }

        // Display image based on current point, direction or next path first point image
        private void LoadImage()  {
            Image img = null;
            string imageName = string.Empty;
            NavigatorPoint point = currentPoint;
            if (currentPoint.JunctionPoints != null) {
                foreach (JunctionPoint junctionPoint in currentPoint.JunctionPoints) {
                    if (currentAngle == junctionPoint.PathAngle && currentAngle % 90 != 0) {
                        // use next path first image and show
                        if (junctionPoint.StartOrEnd == StartOrEnd.Start) {
                            imageName = junctionPoint.Path.Points[0].Img1;
                        } else {
                            imageName = junctionPoint.Path.Points[junctionPoint.Path.Points.Count - 1].Img1;
                        }
                        img = GetImage(imageName, junctionPoint.Path.Id);
                        break;
                    }
                }
            }

            // if no juction point image assigned (show next path first point image)
            if (img == null) {
                imageName = string.Empty;

                switch (currentAngle) {
                    case 0: imageName = point.Img1; break;
                    case 90: imageName = point.Img2; break;
                    case 180: imageName = point.Img3; break;
                    case 270: imageName = point.Img4; break;
                }

                img = GetImage(imageName, currentPath.Id);
            }

            // Display image
            lblImageName.Text = imageName;
            lblPath.Text = currentPath.Id;
            lblCurrentAngle.Text = "" + currentAngle;
            currentImagePath = imagePath + "\\" + currentPath.Id + "\\" + imageName;
            pbNavigationImage.Image = img;

            // Draw navigation direction
            DrawNavigationDirection();

            pbNavigationImage.Refresh();

            // Notify that image changed
            if (ImageChanged != null) { ImageChanged(this, null); }
        }

        // Get next point... either in current path or go to next path
        private NavigatorPoint GetNextPoint(NavigatorPoint curPoint, NavigatorPath curPath) {
            NavigatorPoint nextPoint = null;
            if (curPoint.JunctionPoints != null && curPoint.JunctionPoints.Count > 0) {
                foreach (JunctionPoint junctionPoint in curPoint.JunctionPoints) {
                    if (junctionPoint.PathAngle == currentAngle) {
                        // change current path to point next path linked with junction point
                        currentPath = junctionPoint.Path;

                        if (junctionPoint.StartOrEnd == StartOrEnd.Start) {
                            nextPoint = currentPath.Points[0];
                            currentAngle = 0;
                            currentIndex = 0;
                        } else if (junctionPoint.StartOrEnd == StartOrEnd.End) {
                            nextPoint = currentPath.Points[currentPath.Points.Count - 1];
                            currentAngle = 180;
                            currentIndex = currentPath.Points.Count - 1;
                        }
                        
                        break;
                    }
                }
            }

            if (nextPoint == null) {
                // Get next point in current path
                nextPoint = GetNextPrevPoint(curPoint, curPath, true);
            }

            if (nextPoint != null && PositionChanged != null) {
                PositionChanged(this, new NavigatorPositionChangedEventArgs(nextPoint, currentPath));
            }

            return nextPoint;
        }

        private NavigatorPoint GetPrevPoint(NavigatorPoint curPoint, NavigatorPath curPath) {
            // Get prev point in current path
            NavigatorPoint prevPoint = GetNextPrevPoint(curPoint, curPath, false);
            if (PositionChanged != null) {
                PositionChanged(this, new NavigatorPositionChangedEventArgs(prevPoint, curPath));
            }

            return prevPoint;
        }

        private NavigatorPoint GetNextPrevPoint(NavigatorPoint curPoint, NavigatorPath curPath, bool next) {
            int nextOrPrev = next ? 1 : -1;
            if (curPath.Points.Contains(curPoint)) {
                int curIndex = curPath.Points.IndexOf(curPoint);
                int nextIndex = -1;
                if (currentAngle == 0) {
                    nextIndex = curIndex + nextOrPrev;
                } else if (currentAngle == 180) {
                    nextIndex = curIndex - nextOrPrev;
                }

                if (nextIndex >= 0 && nextIndex < curPath.Points.Count) {
                    currentIndex = nextIndex;
                    return curPath.Points[nextIndex];
                }
            }

            return curPoint;
        }

        private int GetNextAngle(int curAngle, NavigatorPoint curPoint) {
            int angle = -1;
            if (curPoint.JunctionPoints != null && curPoint.JunctionPoints.Count > 0) {
                foreach (JunctionPoint junctionPoint in curPoint.JunctionPoints) {
                    if (junctionPoint.PathAngle > curAngle && junctionPoint.PathAngle < GetNextQuadrantAngle(curAngle)) {
                        angle = junctionPoint.PathAngle;
                        break;
                    }
                }
            }

            if (angle == -1) {
                angle = GetNextQuadrantAngle(curAngle);
            }

            return angle % 360;
        }

        private int GetPrevAngle(int curAngle, NavigatorPoint curPoint) {
            int angle = -1;
            curAngle = curAngle == 0 ? 360 : curAngle;
            if (curPoint.JunctionPoints != null && curPoint.JunctionPoints.Count > 0) {
                foreach (JunctionPoint junctionPoint in curPoint.JunctionPoints) {
                    if (junctionPoint.PathAngle < curAngle && junctionPoint.PathAngle > GetPrevQuadrantAngle(curAngle)) {
                        angle = junctionPoint.PathAngle;
                        break;
                    }
                }
            }

            if (angle < 0) {
                angle = GetPrevQuadrantAngle(curAngle);
            }

            return angle % 360;
        }

        private int GetNextQuadrantAngle(int angle) {
            if (angle >= 0 && angle < 90) {
                return 90;
            } else if (angle >= 90 && angle < 180) {
                return 180;
            } else if (angle >= 180 && angle < 270) {
                return 270;
            } else if (angle >= 270 && angle < 360) {
                return 360;
            }

            return angle;
        }

        private int GetPrevQuadrantAngle(int angle) {
            if (angle <= 360 && angle > 270) {
                return 270;
            } else if (angle <= 270 && angle > 180) {
                return 180;
            } else if (angle <= 180 && angle > 90) {
                return 90;
            } else if (angle <= 90 && angle > 0) {
                return 0;
            }

            return angle;
        }

        private Image GetImage(string filename, string pathId) {
            return ImageLoader.GetImageFromFile(Globals.ImagesDir+ pathId + "\\" + filename, pbNavigationImage.Width, pbNavigationImage.Height);
        }

        #region Drawing navigation arrows
        private void DrawNavigationDirection() {
            // forward direction
            if (currentIndex != currentPath.Points.Count - 1) {
                int forwardAngle = (360 - currentAngle) % 360;
                DrawArrow(forwardAngle);
            }

            // backward direction
            if (currentIndex != 0) {
                int backwardAngle = (360 - (currentAngle + 180)) % 360;
                DrawArrow(backwardAngle);
            }

            // Junction point directions
            if (currentPoint.JunctionPoints != null) {
                foreach (JunctionPoint junctionPoint in currentPoint.JunctionPoints) {
                    DrawArrow((360 + junctionPoint.PathAngle - currentAngle) % 360);
                }
            }
        }

        private void DrawArrow(double angle) {
            radius = pbNavigationImage.Height / 8;
            centerX = pbNavigationImage.Width / 2;
            centerY = pbNavigationImage.Height - pbNavigationImage.Height / 4;

            angle = 360 - (angle % 360) + 90; // 0 degree in this application is 90 as actual angle
            double radAngle = Math.PI * angle / 180;
            int x1 = centerX - (int)(Math.Cos(radAngle) * radius);
            int y1 = centerY - (int)(Math.Sin(radAngle) * radius);

            int x2 = x1 - (int)(Math.Cos(radAngle) * (minArrowLength + arrowLength * (angle - 90) / 180));
            int y2 = y1 - (int)(Math.Sin(radAngle) * (minArrowLength + arrowLength * (angle - 90) / 180));

            DrawArrowLine(new Point(x1, y1), new Point(x2, y2));
        }

        private void DrawArrowLine(Point p1, Point p2) {
            Graphics g = Graphics.FromImage(pbNavigationImage.Image);

            Pen pen = new Pen(Color.Blue, 15);
            pen.StartCap = LineCap.Flat;
            pen.EndCap = LineCap.ArrowAnchor;
            g.DrawLine(pen, p1, p2);

            pbNavigationImage.Refresh();
        }
        #endregion

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if ((msg.Msg == WM_KEYDOWN) || (msg.Msg == WM_SYSKEYDOWN)) {
                switch (keyData) {
                    case Keys.Up:
                        Navigate(NavigateDirection.Forward);
                        break;
                    case Keys.Down:
                        Navigate(NavigateDirection.Backward);
                        break;
                    case Keys.Left:
                        Navigate(NavigateDirection.Left);
                        break;
                    case Keys.Right:
                        Navigate(NavigateDirection.Right);
                        break;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
