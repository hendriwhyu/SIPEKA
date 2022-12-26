namespace SIPEKA
{
    partial class PendaftaranFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PendaftaranFrm));
            this.txt_daftar = new System.Windows.Forms.TextBox();
            this.cmb_kartu = new System.Windows.Forms.ComboBox();
            this.cmb_poli = new System.Windows.Forms.ComboBox();
            this.cmb_dokter = new System.Windows.Forms.ComboBox();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.pendaftaran_dgv = new System.Windows.Forms.DataGridView();
            this.ubah_btn = new System.Windows.Forms.Button();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.tutup_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_tanggal = new System.Windows.Forms.Label();
            this.lbl_hari = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cetak_btn = new System.Windows.Forms.Button();
            this.batal_btn = new System.Windows.Forms.Button();
            this.dgv_dokter = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_poli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckode_daftar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckartu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpoli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pendaftaran_dgv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dokter)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_daftar
            // 
            this.txt_daftar.Enabled = false;
            this.txt_daftar.Location = new System.Drawing.Point(12, 204);
            this.txt_daftar.Name = "txt_daftar";
            this.txt_daftar.Size = new System.Drawing.Size(164, 22);
            this.txt_daftar.TabIndex = 22;
            // 
            // cmb_kartu
            // 
            this.cmb_kartu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_kartu.FormattingEnabled = true;
            this.cmb_kartu.Location = new System.Drawing.Point(12, 280);
            this.cmb_kartu.Name = "cmb_kartu";
            this.cmb_kartu.Size = new System.Drawing.Size(165, 24);
            this.cmb_kartu.TabIndex = 5;
            // 
            // cmb_poli
            // 
            this.cmb_poli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_poli.FormattingEnabled = true;
            this.cmb_poli.Location = new System.Drawing.Point(12, 356);
            this.cmb_poli.Name = "cmb_poli";
            this.cmb_poli.Size = new System.Drawing.Size(165, 24);
            this.cmb_poli.TabIndex = 6;
            this.cmb_poli.SelectedIndexChanged += new System.EventHandler(this.cmb_poli_SelectedIndexChanged);
            // 
            // cmb_dokter
            // 
            this.cmb_dokter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_dokter.FormattingEnabled = true;
            this.cmb_dokter.Location = new System.Drawing.Point(12, 435);
            this.cmb_dokter.Name = "cmb_dokter";
            this.cmb_dokter.Size = new System.Drawing.Size(165, 24);
            this.cmb_dokter.TabIndex = 7;
            // 
            // btn_simpan
            // 
            this.btn_simpan.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_simpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan.Location = new System.Drawing.Point(16, 206);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(84, 34);
            this.btn_simpan.TabIndex = 8;
            this.btn_simpan.Text = "SIMPAN";
            this.btn_simpan.UseVisualStyleBackColor = false;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // pendaftaran_dgv
            // 
            this.pendaftaran_dgv.AllowUserToAddRows = false;
            this.pendaftaran_dgv.AllowUserToDeleteRows = false;
            this.pendaftaran_dgv.ColumnHeadersHeight = 29;
            this.pendaftaran_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.pendaftaran_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ckode_daftar,
            this.ckartu,
            this.cpoli,
            this.cnama});
            this.pendaftaran_dgv.Location = new System.Drawing.Point(231, 291);
            this.pendaftaran_dgv.Name = "pendaftaran_dgv";
            this.pendaftaran_dgv.ReadOnly = true;
            this.pendaftaran_dgv.RowHeadersWidth = 51;
            this.pendaftaran_dgv.RowTemplate.Height = 24;
            this.pendaftaran_dgv.Size = new System.Drawing.Size(666, 175);
            this.pendaftaran_dgv.TabIndex = 11;
            this.pendaftaran_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pendaftaran_dgv_CellClick);
            // 
            // ubah_btn
            // 
            this.ubah_btn.BackColor = System.Drawing.Color.BurlyWood;
            this.ubah_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubah_btn.Location = new System.Drawing.Point(390, 472);
            this.ubah_btn.Name = "ubah_btn";
            this.ubah_btn.Size = new System.Drawing.Size(84, 34);
            this.ubah_btn.TabIndex = 14;
            this.ubah_btn.Text = "UBAH";
            this.ubah_btn.UseVisualStyleBackColor = false;
            this.ubah_btn.Click += new System.EventHandler(this.ubah_btn_Click);
            // 
            // hapus_btn
            // 
            this.hapus_btn.BackColor = System.Drawing.Color.BurlyWood;
            this.hapus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus_btn.Location = new System.Drawing.Point(527, 472);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(84, 34);
            this.hapus_btn.TabIndex = 15;
            this.hapus_btn.Text = "HAPUS";
            this.hapus_btn.UseVisualStyleBackColor = false;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // tutup_btn
            // 
            this.tutup_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.tutup_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutup_btn.Location = new System.Drawing.Point(691, 3);
            this.tutup_btn.Name = "tutup_btn";
            this.tutup_btn.Size = new System.Drawing.Size(34, 33);
            this.tutup_btn.TabIndex = 16;
            this.tutup_btn.Text = "X";
            this.tutup_btn.UseVisualStyleBackColor = false;
            this.tutup_btn.Click += new System.EventHandler(this.tutup_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.lbl_tanggal);
            this.panel1.Controls.Add(this.lbl_hari);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_daftar);
            this.panel1.Controls.Add(this.cmb_kartu);
            this.panel1.Controls.Add(this.cmb_poli);
            this.panel1.Controls.Add(this.cmb_dokter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 540);
            this.panel1.TabIndex = 49;
            // 
            // lbl_tanggal
            // 
            this.lbl_tanggal.AutoSize = true;
            this.lbl_tanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tanggal.Location = new System.Drawing.Point(40, 142);
            this.lbl_tanggal.Name = "lbl_tanggal";
            this.lbl_tanggal.Size = new System.Drawing.Size(63, 20);
            this.lbl_tanggal.TabIndex = 29;
            this.lbl_tanggal.Text = "tanggal";
            // 
            // lbl_hari
            // 
            this.lbl_hari.AutoSize = true;
            this.lbl_hari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hari.Location = new System.Drawing.Point(65, 117);
            this.lbl_hari.Name = "lbl_hari";
            this.lbl_hari.Size = new System.Drawing.Size(104, 25);
            this.lbl_hari.TabIndex = 28;
            this.lbl_hari.Text = "nama_hari";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(7, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "Kode Dokter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(7, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Kode Poli";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(7, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "No Kartu Berobat";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(7, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Kode Pendaftaran";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tutup_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 100);
            this.panel2.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(148, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(433, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pengelolaan Data Pendaftaran";
            // 
            // cetak_btn
            // 
            this.cetak_btn.BackColor = System.Drawing.Color.BurlyWood;
            this.cetak_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cetak_btn.Location = new System.Drawing.Point(795, 472);
            this.cetak_btn.Name = "cetak_btn";
            this.cetak_btn.Size = new System.Drawing.Size(84, 34);
            this.cetak_btn.TabIndex = 51;
            this.cetak_btn.Text = "CETAK";
            this.cetak_btn.UseVisualStyleBackColor = false;
            this.cetak_btn.Click += new System.EventHandler(this.cetak_btn_Click);
            // 
            // batal_btn
            // 
            this.batal_btn.BackColor = System.Drawing.Color.BurlyWood;
            this.batal_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batal_btn.Location = new System.Drawing.Point(664, 472);
            this.batal_btn.Name = "batal_btn";
            this.batal_btn.Size = new System.Drawing.Size(84, 34);
            this.batal_btn.TabIndex = 52;
            this.batal_btn.Text = "BATAL";
            this.batal_btn.UseVisualStyleBackColor = false;
            this.batal_btn.Click += new System.EventHandler(this.batal_btn_Click);
            // 
            // dgv_dokter
            // 
            this.dgv_dokter.AllowUserToAddRows = false;
            this.dgv_dokter.AllowUserToDeleteRows = false;
            this.dgv_dokter.ColumnHeadersHeight = 29;
            this.dgv_dokter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_dokter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.nama_poli,
            this.dataGridViewTextBoxColumn3});
            this.dgv_dokter.Location = new System.Drawing.Point(16, 21);
            this.dgv_dokter.Name = "dgv_dokter";
            this.dgv_dokter.ReadOnly = true;
            this.dgv_dokter.RowHeadersWidth = 51;
            this.dgv_dokter.RowTemplate.Height = 24;
            this.dgv_dokter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_dokter.Size = new System.Drawing.Size(638, 119);
            this.dgv_dokter.TabIndex = 53;
            this.dgv_dokter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dokter_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "kode_dokter";
            this.dataGridViewTextBoxColumn1.HeaderText = "Kode Dokter";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nama_dokter";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nama Dokter";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nama_poli
            // 
            this.nama_poli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama_poli.DataPropertyName = "nama_poli";
            this.nama_poli.HeaderText = "Nama Poli";
            this.nama_poli.MinimumWidth = 6;
            this.nama_poli.Name = "nama_poli";
            this.nama_poli.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "jadwal";
            this.dataGridViewTextBoxColumn3.HeaderText = "Jadwal";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_dokter);
            this.groupBox1.Location = new System.Drawing.Point(225, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 153);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jadwal Dokter Tersedia";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_simpan);
            this.groupBox2.Location = new System.Drawing.Point(225, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(681, 248);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabel Pasien";
            // 
            // ckode_daftar
            // 
            this.ckode_daftar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ckode_daftar.DataPropertyName = "kode_pendaftaran";
            this.ckode_daftar.HeaderText = "Kode Pendaftaran";
            this.ckode_daftar.MinimumWidth = 6;
            this.ckode_daftar.Name = "ckode_daftar";
            this.ckode_daftar.ReadOnly = true;
            // 
            // ckartu
            // 
            this.ckartu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ckartu.DataPropertyName = "nama";
            this.ckartu.HeaderText = "Nama Pasien";
            this.ckartu.MinimumWidth = 6;
            this.ckartu.Name = "ckartu";
            this.ckartu.ReadOnly = true;
            // 
            // cpoli
            // 
            this.cpoli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cpoli.DataPropertyName = "nama_poli";
            this.cpoli.HeaderText = "Nama Poli";
            this.cpoli.MinimumWidth = 6;
            this.cpoli.Name = "cpoli";
            this.cpoli.ReadOnly = true;
            // 
            // cnama
            // 
            this.cnama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cnama.DataPropertyName = "nama_dokter";
            this.cnama.HeaderText = "Nama Dokter";
            this.cnama.MinimumWidth = 6;
            this.cnama.Name = "cnama";
            this.cnama.ReadOnly = true;
            // 
            // PendaftaranFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 540);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.batal_btn);
            this.Controls.Add(this.cetak_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.ubah_btn);
            this.Controls.Add(this.pendaftaran_dgv);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PendaftaranFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pendaftaran_dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dokter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_daftar;
        private System.Windows.Forms.ComboBox cmb_kartu;
        private System.Windows.Forms.ComboBox cmb_poli;
        private System.Windows.Forms.ComboBox cmb_dokter;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.DataGridView pendaftaran_dgv;
        private System.Windows.Forms.Button ubah_btn;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.Button tutup_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cetak_btn;
        private System.Windows.Forms.Button batal_btn;
        private System.Windows.Forms.DataGridView dgv_dokter;
        private System.Windows.Forms.Label lbl_hari;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_poli;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckode_daftar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckartu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpoli;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnama;
    }
}

