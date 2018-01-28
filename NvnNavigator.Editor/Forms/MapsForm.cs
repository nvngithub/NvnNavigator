using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using NvnNavigator.Common;

namespace NvnNavigator.Editor
{
    public partial class MapsForm : Form
    {

        public MapsForm()
        {
            InitializeComponent();
        }

        public void LoadMapsToGrid()
        {
            List<Map> maps = LoadSave.LoadMaps(Globals.ProjectFile);
            if (maps != null)
            {
                foreach (Map map in maps)
                {
                    int index = dgrMaps.Rows.Add();
                    dgrMaps[0, index].Value = map.Name;
                    dgrMaps[1, index].Value = map.Floor;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (String.IsNullOrEmpty(Globals.ProjectFile) == false)
                {
                    string destFile = Globals.MapsDir + Path.GetFileName(dlg.FileName);
                    IOSupport.CopyFile(dlg.FileName, destFile);

                    int index = dgrMaps.Rows.Add();
                    dgrMaps[0, index].Value = Path.GetFileName(dlg.FileName);
                    dgrMaps[1, index].Value = "";
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<Map> maps = new List<Map>();
            foreach (DataGridViewRow row in dgrMaps.Rows)
            {
                Map map = new Map();
                map.Name = (string)row.Cells[0].Value;
                map.Floor = (string)row.Cells[1].Value;

                maps.Add(map);
            }

            LoadSave.SaveMaps(maps, Globals.MapsDir + @"maps.xml");

            this.DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
