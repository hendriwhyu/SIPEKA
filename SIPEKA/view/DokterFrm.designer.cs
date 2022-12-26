namespace SIPEKA.view
{
    partial class DokterFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DokterFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_keluar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_dokter = new System.Windows.Forms.TextBox();
            this.jadwal_cmb = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_poli = new System.Windows.Forms.ComboBox();
            this.nama_dokter_txt = new System.Windows.Forms.TextBox();
            this.telepon_txt = new System.Windows.Forms.TextBox();
            this.btn_cetak = new System.Windows.Forms.Button();
            this.batal_btn = new System.Windows.Forms.Button();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.ubah_btn = new System.Windows.Forms.Button();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.dokter_dgv = new System.Windows.Forms.DataGridView();
            this.kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JenisObat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaObat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokter_dgv)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(880, 100);
            this.panel1.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(275, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pengelolaan Data Dokter";
            // 
            // btn_keluar
            // 
            this.btn_keluar.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_keluar.Location = new System.Drawing.Point(845, 3);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(30, 32);
            this.btn_keluar.TabIndex = 47;
            this.btn_keluar.Text = "X";
            this.btn_keluar.UseVisualStyleBackColor = false;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Location = new System.Drawing.Point(216, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 49);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(6, 21);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(315, 22);
            this.txt_search.TabIndex = 40;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(7, 500);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "Jadwal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(7, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "No Telp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(7, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Poli";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(7, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Nama Dokter";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.txt_dokter);
            this.panel2.Controls.Add(this.jadwal_cmb);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmb_poli);
            this.panel2.Controls.Add(this.nama_dokter_txt);
            this.panel2.Controls.Add(this.telepon_txt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 713);
            this.panel2.TabIndex = 48;
            // 
            // txt_dokter
            // 
            this.txt_dokter.CausesValidation = false;
            this.txt_dokter.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_dokter.Enabled = false;
            this.txt_dokter.Location = new System.Drawing.Point(12, 204);
            this.txt_dokter.Multiline = true;
            this.txt_dokter.Name = "txt_dokter";
            this.txt_dokter.Size = new System.Drawing.Size(164, 30);
            this.txt_dokter.TabIndex = 30;
            // 
            // jadwal_cmb
            // 
            this.jadwal_cmb.Cursor = System.Windows.Forms.Cursors.Default;
            this.jadwal_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jadwal_cmb.FormattingEnabled = true;
            this.jadwal_cmb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.jadwal_cmb.ItemHeight = 16;
            this.jadwal_cmb.Location = new System.Drawing.Point(12, 528);
            this.jadwal_cmb.Name = "jadwal_cmb";
            this.jadwal_cmb.Size = new System.Drawing.Size(164, 24);
            this.jadwal_cmb.TabIndex = 3;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(7, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Dokter";
            // 
            // cmb_poli
            // 
            this.cmb_poli.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmb_poli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_poli.FormattingEnabled = true;
            this.cmb_poli.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_poli.ItemHeight = 16;
            this.cmb_poli.Location = new System.Drawing.Point(12, 356);
            this.cmb_poli.Name = "cmb_poli";
            this.cmb_poli.Size = new System.Drawing.Size(164, 24);
            this.cmb_poli.TabIndex = 1;
            // 
            // nama_dokter_txt
            // 
            this.nama_dokter_txt.Location = new System.Drawing.Point(12, 280);
            this.nama_dokter_txt.Multiline = true;
            this.nama_dokter_txt.Name = "nama_dokter_txt";
            this.nama_dokter_txt.Size = new System.Drawing.Size(164, 30);
            this.nama_dokter_txt.TabIndex = 0;
            this.nama_dokter_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nama_dokter_txt_KeyPress);
            // 
            // telepon_txt
            // 
            this.telepon_txt.Location = new System.Drawing.Point(12, 444);
            this.telepon_txt.MaxLength = 15;
            this.telepon_txt.Multiline = true;
            this.telepon_txt.Name = "telepon_txt";
            this.telepon_txt.Size = new System.Drawing.Size(164, 30);
            this.telepon_txt.TabIndex = 2;
            this.telepon_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telepon_txt_KeyPress);
            // 
            // btn_cetak
            // 
            this.btn_cetak.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_cetak.Location = new System.Drawing.Point(742, 123);
            this.btn_cetak.Name = "btn_cetak";
            this.btn_cetak.Size = new System.Drawing.Size(87, 40);
            this.btn_cetak.TabIndex = 46;
            this.btn_cetak.Text = "Cetak";
            this.btn_cetak.UseVisualStyleBackColor = false;
            this.btn_cetak.Click += new System.EventHandler(this.btn_cetak_Click);
            // 
            // batal_btn
            // 
            this.batal_btn.BackColor = System.Drawing.Color.BurlyWood;
            this.batal_btn.Location = new System.Drawing.Point(612, 123);
            this.batal_btn.Name = "batal_btn";
            this.batal_btn.Size = new System.Drawing.Size(87, 40);
            this.batal_btn.TabIndex = 45;
            this.batal_btn.Text = "Batal";
            this.batal_btn.UseVisualStyleBackColor = false;
            this.batal_btn.Click += new System.EventHandler(this.batal_btn_Click);
            // 
            // hapus_btn
            // 
            this.hapus_btn.BackColor = System.Drawing.Color.BurlyWood;
            this.hapus_btn.Location = new System.Drawing.Point(482, 123);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(87, 40);
            this.hapus_btn.TabIndex = 44;
            this.hapus_btn.Text = "Hapus";
            this.hapus_btn.UseVisualStyleBackColor = false;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // ubah_btn
            // 
            this.ubah_btn.BackColor = System.Drawing.Color.BurlyWood;
            this.ubah_btn.Location = new System.Drawing.Point(352, 123);
            this.ubah_btn.Name = "ubah_btn";
            this.ubah_btn.Size = new System.Drawing.Size(87, 40);
            this.ubah_btn.TabIndex = 43;
            this.ubah_btn.Text = "Ubah";
            this.ubah_btn.UseVisualStyleBackColor = false;
            this.ubah_btn.Click += new System.EventHandler(this.ubah_btn_Click);
            // 
            // simpan_btn
            // 
            this.simpan_btn.BackColor = System.Drawing.Color.BurlyWood;
            this.simpan_btn.Location = new System.Drawing.Point(222, 123);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(87, 40);
            this.simpan_btn.TabIndex = 41;
            this.simpan_btn.Text = "Simpan";
            this.simpan_btn.UseVisualStyleBackColor = false;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // dokter_dgv
            // 
            this.dokter_dgv.AllowUserToAddRows = false;
            this.dokter_dgv.AllowUserToDeleteRows = false;
            this.dokter_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dokter_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kode,
            this.JenisObat,
            this.NamaObat,
            this.ExpiredDate,
            this.Stok});
            this.dokter_dgv.Location = new System.Drawing.Point(216, 224);
            this.dokter_dgv.Name = "dokter_dgv";
            this.dokter_dgv.ReadOnly = true;
            this.dokter_dgv.RowHeadersWidth = 51;
            this.dokter_dgv.RowTemplate.Height = 24;
            this.dokter_dgv.Size = new System.Drawing.Size(836, 452);
            this.dokter_dgv.TabIndex = 39;
            this.dokter_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dokter_dgv_CellClick);
            // 
            // kode
            // 
            this.kode.DataPropertyName = "kode_dokter";
            this.kode.HeaderText = "Kode Dokter";
            this.kode.MinimumWidth = 6;
            this.kode.Name = "kode";
            this.kode.ReadOnly = true;
            this.kode.Width = 125;
            // 
            // JenisObat
            // 
            this.JenisObat.DataPropertyName = "nama_dokter";
            this.JenisObat.HeaderText = "Nama Dokter";
            this.JenisObat.MinimumWidth = 6;
            this.JenisObat.Name = "JenisObat";
            this.JenisObat.ReadOnly = true;
            this.JenisObat.Width = 150;
            // 
            // NamaObat
            // 
            this.NamaObat.DataPropertyName = "nama_poli";
            this.NamaObat.HeaderText = "Poli";
            this.NamaObat.MinimumWidth = 6;
            this.NamaObat.Name = "NamaObat";
            this.NamaObat.ReadOnly = true;
            this.NamaObat.Width = 120;
            // 
            // ExpiredDate
            // 
            this.ExpiredDate.DataPropertyName = "no_telepon";
            this.ExpiredDate.HeaderText = "No. Telp";
            this.ExpiredDate.MinimumWidth = 6;
            this.ExpiredDate.Name = "ExpiredDate";
            this.ExpiredDate.ReadOnly = true;
            this.ExpiredDate.Width = 120;
            // 
            // Stok
            // 
            this.Stok.DataPropertyName = "jadwal";
            this.Stok.HeaderText = "Jadwal";
            this.Stok.MinimumWidth = 6;
            this.Stok.Name = "Stok";
            this.Stok.ReadOnly = true;
            this.Stok.Width = 125;
            // 
            // DokterFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 713);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_cetak);
            this.Controls.Add(this.batal_btn);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.ubah_btn);
            this.Controls.Add(this.simpan_btn);
            this.Controls.Add(this.dokter_dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DokterFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DokterFrm";
            this.Activated += new System.EventHandler(this.DokterFrm_Activated);
            this.Load += new System.EventHandler(this.DokterFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokter_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_poli;
        private System.Windows.Forms.TextBox nama_dokter_txt;
        private System.Windows.Forms.TextBox telepon_txt;
        private System.Windows.Forms.Button btn_keluar;
        private System.Windows.Forms.Button btn_cetak;
        private System.Windows.Forms.Button batal_btn;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.Button ubah_btn;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.DataGridView dokter_dgv;
        private System.Windows.Forms.ComboBox jadwal_cmb;
        private System.Windows.Forms.TextBox txt_dokter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn JenisObat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaObat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stok;
    }
}