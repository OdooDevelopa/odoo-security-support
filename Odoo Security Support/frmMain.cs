using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Odoo_Security_Support.FileHandle;

namespace Odoo_Security_Support
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            return;
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
                txtPath.Text = folderBrowser.SelectedPath;
             
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            var Rules = new List<string>();
            Rules.Add("id,name,model_id:id,group_id:id,perm_read,perm_write,perm_create,perm_unlink");
            for (int r = 0; r < dgvMain.Rows.Count; r++)
            {
                var line = "";
                for (int c = 0; c < dgvMain.Columns.Count; c++)
                {
                    var value = dgvMain.Rows[r].Cells[c].Value.ToString().Trim();
                    if (value == "") { line += ""; continue; }
                    var separator = (c == dgvMain.Columns.Count - 1) ? "" : ",";
                    line += string.Format("{0}{1}", value, separator);
                }
                Rules.Add(line);
            }
            new frmExport(Rules).ShowDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var folderPath = txtPath.Text;
            bool isModuleFolder = !string.IsNullOrWhiteSpace(folderPath)
                && Directory.EnumerateFiles(folderPath).Any(file => file.Contains("__manifest__"));
            if (isModuleFolder)
            {
                dgvMain.Rows.Clear();
                dgvMain.Refresh();
                var Models = Read.GetModelName(folderPath);
                var Groups = Read.GetGroupId(folderPath);
                var AvailableAccess = Read.GetAccess(folderPath);
                var Access = FileHandle.Handle.GetAccess(Models, Groups, AvailableAccess);
                foreach (var access in Access) dgvMain.Rows.Add(access);
            }
            else
                MessageBox.Show(
                    "Invalid module folder!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.All;
        }

        private void dgvMain_DragDrop(object sender, DragEventArgs e)
        {
            var dropedFiles = ((string[])e.Data.GetData(DataFormats.FileDrop));
            txtPath.Text = dropedFiles[0];
        }

        private void txtPath_DragEnter(object sender, DragEventArgs e)
        {
            dgvMain_DragEnter(sender, e);
        }

        private void txtPath_DragDrop(object sender, DragEventArgs e)
        {
            dgvMain_DragDrop(sender, e);
        }
    }
}
