namespace SIPEKA.view
{
    partial class SearchPasien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPasien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_keluar = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_cetak = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_pasien = new System.Windows.Forms.DataGridView();
            this.txt_no_kartu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NomorKartu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoBPJS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaPasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaPoli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaDokter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pasien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_keluar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 100);
            this.panel1.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(307, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Pasien";
            // 
            // btn_keluar
            // 
            this.btn_keluar.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_keluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_keluar.Location = new System.Drawing.Point(781, 3);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(40, 34);
            this.btn_keluar.TabIndex = 47;
            this.btn_keluar.Text = "X";
            this.btn_keluar.UseVisualStyleBackColor = false;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(6, 21);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(315, 22);
            this.txt_search.TabIndex = 40;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_cetak
            // 
            this.btn_cetak.Location = new System.Drawing.Point(224, 173);
            this.btn_cetak.Name = "btn_cetak";
            this.btn_cetak.Size = new System.Drawing.Size(88, 32);
            this.btn_cetak.TabIndex = 46;
            this.btn_cetak.Text = "Cetak";
            this.btn_cetak.UseVisualStyleBackColor = true;
            this.btn_cetak.Click += new System.EventHandler(this.btn_cetak_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 72);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 640);
            this.panel2.TabIndex = 48;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Location = new System.Drawing.Point(218, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 49);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari";
            // 
            // dgv_pasien
            // 
            this.dgv_pasien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pasien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomorKartu,
            this.NoBPJS,
            this.NamaPasien,
            this.NamaPoli,
            this.NamaDokter});
            this.dgv_pasien.Location = new System.Drawing.Point(218, 277);
            this.dgv_pasien.Name = "dgv_pasien";
            this.dgv_pasien.RowHeadersWidth = 51;
            this.dgv_pasien.RowTemplate.Height = 24;
            this.dgv_pasien.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_pasien.Size = new System.Drawing.Size(796, 274);
            this.dgv_pasien.TabIndex = 50;
            this.dgv_pasien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pasien_CellClick);
            // 
            // txt_no_kartu
            // 
            this.txt_no_kartu.Enabled = false;
            this.txt_no_kartu.Location = new System.Drawing.Point(224, 128);
            this.txt_no_kartu.Name = "txt_no_kartu";
            this.txt_no_kartu.Size = new System.Drawing.Size(201, 22);
            this.txt_no_kartu.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Nomor Kartu";
            // 
            // NomorKartu
            // 
            this.NomorKartu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomorKartu.DataPropertyName = "no_kartu_berobat";
            this.NomorKartu.HeaderText = "Nomor Kartu";
            this.NomorKartu.MinimumWidth = 6;
            this.NomorKartu.Name = "NomorKartu";
            // 
            // NoBPJS
            // 
            this.NoBPJS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NoBPJS.DataPropertyName = "no_bpjs";
            this.NoBPJS.HeaderText = "BPJS";
            this.NoBPJS.MinimumWidth = 6;
            this.NoBPJS.Name = "NoBPJS";
            // 
            // NamaPasien
            // 
            this.NamaPasien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamaPasien.DataPropertyName = "nama";
            this.NamaPasien.HeaderText = "Nama Pasien";
            this.NamaPasien.MinimumWidth = 6;
            this.NamaPasien.Name = "NamaPasien";
            // 
            // NamaPoli
            // 
            this.NamaPoli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamaPoli.DataPropertyName = "nama_poli";
            this.NamaPoli.HeaderText = "Poli";
            this.NamaPoli.MinimumWidth = 6;
            this.NamaPoli.Name = "NamaPoli";
            // 
            // NamaDokter
            // 
            this.NamaDokter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamaDokter.DataPropertyName = "nama_dokter";
            this.NamaDokter.HeaderText = "Dokter";
            this.NamaDokter.MinimumWidth = 6;
            this.NamaDokter.Name = "NamaDokter";
            // 
            // SearchPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 640);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_no_kartu);
            this.Controls.Add(this.dgv_pasien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_cetak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchPasien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchPasien";
            this.Load += new System.EventHandler(this.SearchPasien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pasien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_keluar;
        private System.Windows.Forms.Button btn_cetak;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_pasien;
        private System.Windows.Forms.TextBox txt_no_kartu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomorKartu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoBPJS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaPasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaPoli;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaDokter;
    }
}