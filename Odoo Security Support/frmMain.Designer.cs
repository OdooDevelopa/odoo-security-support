namespace Odoo_Security_Support
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perm_read = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perm_write = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perm_create = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perm_unlink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeColumns = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.model_id,
            this.group_id,
            this.perm_read,
            this.perm_write,
            this.perm_create,
            this.perm_unlink});
            this.dgvMain.Location = new System.Drawing.Point(12, 41);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.Size = new System.Drawing.Size(808, 311);
            this.dgvMain.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 41;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 58;
            // 
            // model_id
            // 
            this.model_id.HeaderText = "Model";
            this.model_id.Name = "model_id";
            this.model_id.ReadOnly = true;
            this.model_id.Width = 59;
            // 
            // group_id
            // 
            this.group_id.HeaderText = "Group";
            this.group_id.Name = "group_id";
            this.group_id.ReadOnly = true;
            this.group_id.Width = 59;
            // 
            // perm_read
            // 
            this.perm_read.HeaderText = "Read";
            this.perm_read.Name = "perm_read";
            this.perm_read.Width = 56;
            // 
            // perm_write
            // 
            this.perm_write.HeaderText = "Write";
            this.perm_write.Name = "perm_write";
            this.perm_write.Width = 55;
            // 
            // perm_create
            // 
            this.perm_create.HeaderText = "Create";
            this.perm_create.Name = "perm_create";
            this.perm_create.Width = 61;
            // 
            // perm_unlink
            // 
            this.perm_unlink.HeaderText = "Unlink";
            this.perm_unlink.Name = "perm_unlink";
            this.perm_unlink.Width = 60;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(12, 12);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(80, 23);
            this.btnBrowser.TabIndex = 1;
            this.btnBrowser.Text = "Browser";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(98, 14);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(633, 20);
            this.txtPath.TabIndex = 2;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(737, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(83, 23);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 364);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.dgvMain);
            this.Name = "frmMain";
            this.Text = "Odoo Security Support";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn model_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn perm_read;
        private System.Windows.Forms.DataGridViewTextBoxColumn perm_write;
        private System.Windows.Forms.DataGridViewTextBoxColumn perm_create;
        private System.Windows.Forms.DataGridViewTextBoxColumn perm_unlink;
        private System.Windows.Forms.Button btnExport;
    }
}

