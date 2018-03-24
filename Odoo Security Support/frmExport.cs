using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odoo_Security_Support
{
    public partial class frmExport : Form
    {
        public frmExport(List<string> Rules)
        {
            InitializeComponent();
            txtMain.Clear();
            foreach (var line in Rules)
                txtMain.Text += string.Format("{0}{1}", line, Environment.NewLine);
        }

        private void frmExport_Load(object sender, EventArgs e)
        {

        }

        private void btnClipboard_Click(object sender, EventArgs e)
        {
            txtMain.SelectAll();
            Clipboard.SetText(txtMain.Text);

            var tmp = btnClipboard.Text;
            btnClipboard.Text = "Copied...";
        }
    }
}
