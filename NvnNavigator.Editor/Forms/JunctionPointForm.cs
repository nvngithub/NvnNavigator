using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NvnNavigator.Common;

namespace NvnNavigator.Editor {
    public partial class JunctionPointForm : Form {

        private JunctionPoint junctionPoint = new NvnNavigator.Common.JunctionPoint ();

        public JunctionPointForm() {
            InitializeComponent();

            // Load path ids into drop down
            foreach (NavigatorPath path in Globals.NavigatorPlace.Paths) {
                cmbPathId.Items.Add(path.Id);
            }
        }

        public JunctionPoint JunctionPoint {
            get { return junctionPoint; }
            set { junctionPoint = value; }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            junctionPoint.PathAngle = Int32.Parse(txtPathAngle.Text);
            if (rbStart.Checked) junctionPoint.StartOrEnd = StartOrEnd.Start;
            else if (rbEnd.Checked) junctionPoint.StartOrEnd = StartOrEnd.End;
            junctionPoint.Path = Globals.NavigatorPlace.GetPath((string)cmbPathId.SelectedItem);
            if (junctionPoint.Path == null) {
                MessageBox.Show("Path with Id" + (string)cmbPathId.SelectedItem + " not found");
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
