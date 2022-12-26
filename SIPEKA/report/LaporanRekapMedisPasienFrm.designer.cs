namespace SIPEKA.report
{
    partial class LaporanRekapMedisPasienFrm
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
            this.rekapmedis_crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rekapmedis_crv
            // 
            this.rekapmedis_crv.ActiveViewIndex = -1;
            this.rekapmedis_crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rekapmedis_crv.Cursor = System.Windows.Forms.Cursors.Default;
            this.rekapmedis_crv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rekapmedis_crv.Location = new System.Drawing.Point(0, 0);
            this.rekapmedis_crv.Name = "rekapmedis_crv";
            this.rekapmedis_crv.Size = new System.Drawing.Size(800, 450);
            this.rekapmedis_crv.TabIndex = 0;
            this.rekapmedis_crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // LaporanRekapMedisPasienFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rekapmedis_crv);
            this.Name = "LaporanRekapMedisPasienFrm";
            this.Text = "LaporanRekapMedisPasienFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LaporanRekapMedisPasienFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rekapmedis_crv;
    }
}