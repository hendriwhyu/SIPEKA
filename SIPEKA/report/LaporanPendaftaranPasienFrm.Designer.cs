﻿namespace SIPEKA.report
{
    partial class LaporanPendaftaranPasienFrm
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
            this.crv_pendaftaran = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_pendaftaran
            // 
            this.crv_pendaftaran.ActiveViewIndex = -1;
            this.crv_pendaftaran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_pendaftaran.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_pendaftaran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_pendaftaran.Location = new System.Drawing.Point(0, 0);
            this.crv_pendaftaran.Name = "crv_pendaftaran";
            this.crv_pendaftaran.Size = new System.Drawing.Size(800, 450);
            this.crv_pendaftaran.TabIndex = 0;
            this.crv_pendaftaran.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // LaporanPendaftaranPasienFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crv_pendaftaran);
            this.Name = "LaporanPendaftaranPasienFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaporanPendaftaranPasienFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LaporanPendaftaranPasienFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_pendaftaran;
    }
}