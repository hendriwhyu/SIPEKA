namespace SIPEKA.report
{
    partial class LaporanPasien_Frm
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
            this.pasien_crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // pasien_crv
            // 
            this.pasien_crv.ActiveViewIndex = -1;
            this.pasien_crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pasien_crv.Cursor = System.Windows.Forms.Cursors.Default;
            this.pasien_crv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pasien_crv.Location = new System.Drawing.Point(0, 0);
            this.pasien_crv.Name = "pasien_crv";
            this.pasien_crv.Size = new System.Drawing.Size(800, 450);
            this.pasien_crv.TabIndex = 0;
            this.pasien_crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // LaporanPasien_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pasien_crv);
            this.Name = "LaporanPasien_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaporanPasien_Frm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LaporanPasien_Frm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer pasien_crv;
    }
}