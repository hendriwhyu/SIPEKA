namespace SIPEKA.report
{
    partial class LaporanDokterFrmFilter
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
            this.dokterFilter_crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // dokterFilter_crv
            // 
            this.dokterFilter_crv.ActiveViewIndex = -1;
            this.dokterFilter_crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dokterFilter_crv.Cursor = System.Windows.Forms.Cursors.Default;
            this.dokterFilter_crv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dokterFilter_crv.Location = new System.Drawing.Point(0, 0);
            this.dokterFilter_crv.Name = "dokterFilter_crv";
            this.dokterFilter_crv.Size = new System.Drawing.Size(800, 450);
            this.dokterFilter_crv.TabIndex = 0;
            this.dokterFilter_crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // LaporanDokterFrmFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dokterFilter_crv);
            this.Name = "LaporanDokterFrmFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaporanDokterFrmFilter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LaporanDokterFrmFilter_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer dokterFilter_crv;
    }
}