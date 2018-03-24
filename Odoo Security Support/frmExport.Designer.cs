namespace Odoo_Security_Support
{
    partial class frmExport
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
            this.txtMain = new System.Windows.Forms.TextBox();
            this.btnClipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMain
            // 
            this.txtMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMain.BackColor = System.Drawing.Color.White;
            this.txtMain.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMain.Location = new System.Drawing.Point(12, 12);
            this.txtMain.Multiline = true;
            this.txtMain.Name = "txtMain";
            this.txtMain.ReadOnly = true;
            this.txtMain.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMain.Size = new System.Drawing.Size(801, 301);
            this.txtMain.TabIndex = 0;
            this.txtMain.WordWrap = false;
            // 
            // btnClipboard
            // 
            this.btnClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClipboard.Location = new System.Drawing.Point(697, 319);
            this.btnClipboard.Name = "btnClipboard";
            this.btnClipboard.Size = new System.Drawing.Size(116, 23);
            this.btnClipboard.TabIndex = 1;
            this.btnClipboard.Text = "Copy to Clipboard";
            this.btnClipboard.UseVisualStyleBackColor = true;
            this.btnClipboard.Click += new System.EventHandler(this.btnClipboard_Click);
            // 
            // frmExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 354);
            this.Controls.Add(this.btnClipboard);
            this.Controls.Add(this.txtMain);
            this.Name = "frmExport";
            this.Text = "frmExport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmExport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.Button btnClipboard;
    }
}