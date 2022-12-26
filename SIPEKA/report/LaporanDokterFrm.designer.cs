namespace SIPEKA.report
{
    partial class LaporanDokterFrm
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
            this.dokter_crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // dokter_crv
            // 
            this.dokter_crv.ActiveViewIndex = -1;
            this.dokter_crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dokter_crv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dokter_crv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dokter_crv.Location = new System.Drawing.Point(0, 0);
            this.dokter_crv.Name = "dokter_crv";
            this.dokter_crv.Size = new System.Drawing.Size(800, 450);
            this.dokter_crv.TabIndex = 0;
            this.dokter_crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // LaporanDokterFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dokter_crv);
            this.Name = "LaporanDokterFrm";
            this.Text = "LaporanDokterFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LaporanDokterFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer dokter_crv;
    }
}