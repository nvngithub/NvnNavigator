using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NvnNavigator.Admin {
    public partial class ExceptionForm : Form {
        public ExceptionForm() {
            InitializeComponent();
        }

        public ExceptionForm(Exception exc):this() {
            txtMessage.Text = exc.Message + Environment.NewLine
                + Environment.NewLine + "Stack trace:" + Environment.NewLine + exc.Source;
        }
    }
}
