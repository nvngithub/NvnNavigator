using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NvnNavigator.Common;

namespace NvnNavigator.Admin {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        public MainForm(string selectedPath) : this() {
            containerCtrl1.LoadControl(selectedPath);
        }
    }
}
