using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace NvnNavigator.Common {
    public partial class FloorsCtrl : UserControl {

        public event EventHandler FloorSelected;

        private Map selectedMap;

        public FloorsCtrl() {
            InitializeComponent();
        }

        public Map SelectedMap {
            get { return selectedMap; }
            set {
                selectedMap = value;
                foreach (Control ctrl in this.Controls) {
                    if (ctrl is Button) {
                        Button btn = (Button) ctrl;
                        if (btn.Text == value.Floor) {
                            btn.BackColor = SystemColors.ControlDark;
                        } else {
                            btn.BackColor = SystemColors.Control;
                        }
                    }
                }
            }
        }

        public void LoadFloors(List<Map> maps) {
            if (maps == null) return;

            foreach (Map map in maps) {
                Button button = new Button();
                button.Click += new EventHandler(button_Click);
                button.Size = new Size(25, 20);
                button.Text = map.Floor;

                this.Controls.Add(button);
            }
        }

        void button_Click(object sender, EventArgs e) {
            if (FloorSelected != null) {
                FloorSelected(((Button)sender).Text, null);
            }
        }
    }
}
