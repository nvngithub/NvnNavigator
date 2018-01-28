using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using NvnNavigator.Common;

namespace NvnNavigator.Editor {
    public partial class MainForm : Form {

        private NavigatorPlace place;
        private int selectedPointIndex = -1;

        public MainForm() {
            InitializeComponent();

            imageCaptureControl1.PointImagesUpdated += new EventHandler(imageCaptureControl1_PointImagesUpdated);
            Logger.MessageLogged += new EventHandler(Logger_MessageLogged);
        }

        void Logger_MessageLogged(object message, EventArgs e) {
            txtLog.AppendText((string)message + Environment.NewLine);
        }

        void imageCaptureControl1_PointImagesUpdated(object sender, EventArgs e) {
            LoadSelectedPoint();
        }

        private void btnCreatePlace_Click(object sender, EventArgs e) {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK) {
                Globals.ProjectDir = dlg.SelectedPath;
                File.Create(Globals.ProjectFile).Close();
                
                // Images
                if (Directory.Exists(Globals.ImagesDir)) {
                    Directory.Move(Globals.ImagesDir, Globals.ProjectDir + "\\_Images");
                }
                Directory.CreateDirectory(Globals.ImagesDir);

                place = new NvnNavigator.Common.NavigatorPlace();
                LoadSave.Save(Globals.ProjectFile, place);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.ShowNewFolderButton = true;
            dlg.RootFolder = Environment.SpecialFolder.Desktop;
            if (dlg.ShowDialog() == DialogResult.OK) {
                Globals.ProjectDir = dlg.SelectedPath;
                Globals.NavigatorPlace = place = LoadSave.Load(Globals.ProjectFile);
                lstPoints.Items.Clear();
                lstPaths.Items.Clear();
                lstPaths.Items.AddRange(place.Paths.ToArray());
                if(lstPaths.Items.Count > 0) lstPaths.SelectedIndex = 0;

                markControl1.LoadMapsList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (place != null) {
                LoadSave.Save(Globals.ProjectFile, place);
            }
        }

        private void btnCreatePath_Click(object sender, EventArgs e) {
            NavigatorPath path = new NvnNavigator.Common.NavigatorPath();
            place.Paths.Add(path);
            lstPaths.Items.Add(path);

            string pathDir = Globals.ImagesDir + "\\" + path.Id;
            if (Directory.Exists(pathDir)) {
                Directory.Move(pathDir, Globals.ImagesDir + "\\_" + path.Id);
            }

            Directory.CreateDirectory(pathDir);
        }

        private void btnDeletePath_Click(object sender, EventArgs e) {
            // Delete selected path
            if (lstPaths.SelectedItem != null) {
                NavigatorPath path = (NavigatorPath)lstPaths.SelectedItem;
                if (place.Paths.Contains(path)) {
                    place.Paths.Remove(path);
                    lstPaths.Items.Remove(path);

                    string pathDir = Globals.ImagesDir + "\\" + path.Id;
                    if (Directory.Exists(pathDir)) {
                        Directory.Move(pathDir, Globals.ImagesDir + "\\_" + path.Id);
                    }
                }
            }
        }

        private void btnAddPoint_Click(object sender, EventArgs e) {
            AddPoint();
        }

        private void AddPoint() {
            if (lstPaths.SelectedItem != null) {
                NavigatorPoint newPoint = new NvnNavigator.Common.NavigatorPoint();
                NavigatorPath selectedPath = (NavigatorPath)lstPaths.SelectedItem;
                selectedPath.Points.Add(newPoint);
                lstPoints.Items.Add(newPoint);
            }
        }

        private void btnDeletePoint_Click(object sender, EventArgs e) {
            if (lstPaths.SelectedItem != null && lstPoints.SelectedItem != null) {
                NavigatorPoint selectedPoint = (NavigatorPoint)lstPoints.SelectedItem;
                NavigatorPath selectedPath = (NavigatorPath)lstPaths.SelectedItem;

                lstPoints.Items.Remove(selectedPoint);
                if (selectedPath.Points.Contains(selectedPoint)) {
                    selectedPath.Points.Remove(selectedPoint);
                }

                // remove all corresponding images
                string pathDir = Globals.ImagesDir + "\\" + selectedPath.Id;
                if (File.Exists(pathDir + "\\" + selectedPoint.Img1))
                    File.Move(pathDir + "\\" + selectedPoint.Img1, pathDir + "\\_" + selectedPoint.Img1);
                if (File.Exists(pathDir + "\\" + selectedPoint.Img2))
                    File.Move(pathDir + "\\" + selectedPoint.Img2, pathDir + "\\_" + selectedPoint.Img2);
                if (File.Exists(pathDir + "\\" + selectedPoint.Img3))
                    File.Move(pathDir + "\\" + selectedPoint.Img3, pathDir + "\\_" + selectedPoint.Img3);
                if (File.Exists(pathDir + "\\" + selectedPoint.Img4))
                    File.Move(pathDir + "\\" + selectedPoint.Img4, pathDir + "\\_" + selectedPoint.Img4);
            }
        }

        private void btnPathIdSave_Click(object sender, EventArgs e) {
            if (lstPaths.SelectedItem != null) {
                NavigatorPath selectedPath = (NavigatorPath)lstPaths.SelectedItem;
                if (Directory.Exists(Globals.ImagesDir + "\\" + selectedPath.Id) && Directory.Exists(Globals.ImagesDir + "\\" + txtPathId.Text) == false) {
                    // change directory name
                    Directory.Move(Globals.ImagesDir + "\\" + selectedPath.Id, Globals.ImagesDir + "\\" + txtPathId.Text);
                    // change path id
                    selectedPath.Id = txtPathId.Text;
                    int selectedIndex = lstPaths.SelectedIndex;
                    lstPaths.Items.Clear();
                    lstPaths.Items.AddRange(place.Paths.ToArray());
                }
            }
        }

        private void btnPointInfoSave_Click(object sender, EventArgs e) {
            if (lstPoints.SelectedItem != null && lstPaths.SelectedItem != null) {
                NavigatorPath selectedPath = (NavigatorPath)lstPaths.SelectedItem;
                NavigatorPoint selectedPoint = (NavigatorPoint)lstPoints.SelectedItem;

                // change all associated image file names
                string[] files = Directory.GetFiles(Globals.ImagesDir + selectedPath.Id, selectedPoint.Id + "*.*");
                foreach (string file in files) {
                    string[] pointFileNameParts = Path.GetFileName(file).Split("-".ToCharArray());
                    if (pointFileNameParts.Length != 2) throw new Exception("File name is not in proper format");

                    IOSupport.RenameFile(file, Globals.ImagesDir + selectedPath.Id + "\\" + txtPointId.Text + "-" + pointFileNameParts[1]);
                }

                // Update selected point info
                if (String.IsNullOrEmpty(txtNextPointAngle.Text) == false) {
                    selectedPoint.NextPointAngle = Int32.Parse(txtNextPointAngle.Text);
                }
                if (String.IsNullOrEmpty(txtPointId.Text) == false) {
                    selectedPoint.Id = txtPointId.Text;
                }

                // sav e project file
                if (place != null) {
                    LoadSave.Save(Globals.ProjectFile, place);
                }
            }
        }

        private void lstPaths_SelectedIndexChanged(object sender, EventArgs e) {
            // Load all points assigned to this path
            if (lstPaths.SelectedItem != null) {
                lstPoints.Items.Clear();
                NavigatorPath selectedPath = (NavigatorPath)lstPaths.SelectedItem;
                lstPoints.Items.AddRange(selectedPath.Points.ToArray());
                txtPathId.Text = selectedPath.Id;

                markControl1.SetSelectedNavigatorPath(selectedPath);
            }
        }

        private void lstPoints_SelectedIndexChanged(object sender, EventArgs e) {
            if (selectedPointIndex != -1) {
                lstPoints.SelectedIndex = selectedPointIndex;
                selectedPointIndex = -1;
            }

            LoadSelectedPoint();
        }

        private void LoadSelectedPoint() {
            if (lstPoints.SelectedItem != null && lstPaths.SelectedItem != null) {
                NavigatorPoint selectedPoint = (NavigatorPoint)lstPoints.SelectedItem;
                if (selectedPoint != null) {
                    // Set point control values
                    txtPointId.Text = selectedPoint.Id;
                    txtNextPointAngle.Text = selectedPoint.NextPointAngle.ToString();

                    // Load Images
                    pointImages.Point = selectedPoint;
                    pointImages.NavigatorPath = (NavigatorPath)lstPaths.SelectedItem;
                    pointImages.LoadPointImages();

                    // Load Junction Points
                    pnlJunctionPoints.Controls.Clear();
                    if (selectedPoint.JunctionPoints != null) {
                        foreach (JunctionPoint junctionPoint in selectedPoint.JunctionPoints) {
                            JunctionPointItemControl junctionPointControl = new JunctionPointItemControl();
                            junctionPointControl.JunctionPointSaved += new EventHandler(junctionPointControl_JunctionPointSaved);
                            junctionPointControl.JunctionPointDeleted += new EventHandler(junctionPointControl_JunctionPointDeleted);
                            junctionPointControl.JunctionPoint = junctionPoint;
                            junctionPointControl.LoadProperties();
                            pnlJunctionPoints.Controls.Add(junctionPointControl);
                        }
                    }

                    // Load Images in Image capture control
                    imageCaptureControl1.NavigatorPoint = selectedPoint;
                    imageCaptureControl1.NavigatorPath = (NavigatorPath)lstPaths.SelectedItem;
                    imageCaptureControl1.LoadPointImages();
                }
            }
        }

        void junctionPointControl_JunctionPointDeleted(object sender, EventArgs e) {
            if (lstPoints.SelectedItem != null) {
                // delete this junction point
                NavigatorPoint selectedPoint = (NavigatorPoint)lstPoints.SelectedItem;
                JunctionPointItemControl itemControl = (JunctionPointItemControl)sender;
                if (selectedPoint.JunctionPoints.Contains(itemControl.JunctionPoint)) {
                    selectedPoint.JunctionPoints.Remove(itemControl.JunctionPoint);
                }

                // Load selected point again
                LoadSelectedPoint();
            }
        }

        void junctionPointControl_JunctionPointSaved(object sender, EventArgs e) {
            LoadSelectedPoint();
        }

        private void lnkAddJunctionPoint_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (lstPoints.SelectedItem != null && lstPaths.SelectedItem != null) {
                JunctionPointForm newJunctionPointForm = new JunctionPointForm();
                if (newJunctionPointForm.ShowDialog() == DialogResult.OK) {
                    NavigatorPoint selectedPoint = (NavigatorPoint)lstPoints.SelectedItem;
                    NavigatorPath selectedPath = (NavigatorPath)lstPaths.SelectedItem;

                    if (newJunctionPointForm.JunctionPoint.Path.Id != selectedPath.Id) {
                        JunctionPoint junctionPoint = newJunctionPointForm.JunctionPoint;
                        selectedPoint.JunctionPoints.Add(junctionPoint);

                        // Add junction point to the path connecting to it
                        JunctionPoint newJunctionPoint = new JunctionPoint();
                        newJunctionPoint.Path = selectedPath;
                        newJunctionPoint.PathAngle = ((360 - junctionPoint.PathAngle) + 180) % 360;
                        if (junctionPoint.StartOrEnd == StartOrEnd.Start) {
                            newJunctionPoint.StartOrEnd = StartOrEnd.End;
                            junctionPoint.Path.Points[0].JunctionPoints.Add(newJunctionPoint);
                        } else {
                            newJunctionPoint.StartOrEnd = StartOrEnd.Start;
                            junctionPoint.Path.Points[junctionPoint.Path.Points.Count - 1].JunctionPoints.Add(newJunctionPoint);
                        }

                        // Reload selected point
                        LoadSelectedPoint();
                    } else {
                        MessageBox.Show("You selected same path to join. It should be different");
                    }
                }
            }
        }

        private void btnRealView_Click(object sender, EventArgs e) {
            if (lstPaths.SelectedItem != null && lstPoints.SelectedItem != null) {
                RealNavigationForm navigationForm = new RealNavigationForm();
                navigationForm.ProjectImagePath = Globals.ImagesDir;
                navigationForm.CurrentPlace = Globals.NavigatorPlace;
                navigationForm.CurrentPath = (NavigatorPath)lstPaths.SelectedItem;
                navigationForm.CurrentPoint = (NavigatorPoint)lstPoints.SelectedItem;
                navigationForm.CurrentAngle = 0;
                navigationForm.StartRealView();
                navigationForm.ShowDialog();
            }
        }

        private void btnFindUnusedImages_Click(object sender, EventArgs e) {
            if (Globals.NavigatorPlace != null) {
                UnusedImagesForm unusedImagesForm = new UnusedImagesForm();
                unusedImagesForm.ShowDialog();
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e) {
            selectedPointIndex = -1;
            // specific to capture tab control
            if (tabControl1.SelectedIndex == 2) {
                if (e.KeyData == Keys.L) {
                    lstPoints.Focus();
                } else if (e.KeyData == Keys.K) {
                    lstPaths.Focus();
                } else if (e.KeyData == Keys.P) {
                    AddPoint();
                } else if (e.KeyData == Keys.D1 || e.KeyData == Keys.D2 || e.KeyData == Keys.D3 || e.KeyData == Keys.D4) {
                    selectedPointIndex = lstPoints.SelectedIndex;
                    imageCaptureControl1.ProcessKeyDownEvent(e.KeyData);
                }
            }
        }
    }
}