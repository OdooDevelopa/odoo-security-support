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

        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                bool isModule = !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath)
                                && Directory.EnumerateFiles(folderBrowser.SelectedPath)
                                    .Any(file => file.Contains("__manifest__"));
                if (isModule)
                {
                    txtPath.Text = folderBrowser.SelectedPath;
                    dgvMain.Rows.Clear();
                    dgvMain.Refresh();
                    var Models = Read.GetModelName(folderBrowser.SelectedPath);
                    var Groups = Read.GetGroupId(folderBrowser.SelectedPath);
                    foreach (var model in Models)
                    {
                        foreach (var groupId in Groups)
                        {
                            var _model = model.Replace(".", "_");
                            var name = string.Format("{0}_{1}", _model, groupId.Replace(".", "_"));
                            var id = string.Format("access_{0}", name);
                            var model_id = string.Format("model_{0}", _model);
                            dgvMain.Rows.Add(id, name, model_id, groupId, "1", "0", "0", "0");
                        }
                        dgvMain.Rows.Add("", "", "", "", "", "", "", "", "", "");
                    }
                }
                else
                    MessageBox.Show("Invalid module folder!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
