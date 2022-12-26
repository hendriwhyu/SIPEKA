namespace SIPEKA.view
{
    partial class ResepFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResepFrm));
            this.batal_btn = new System.Windows.Forms.Button();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_resep = new System.Windows.Forms.DataGridView();
            this.KodeObat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JenisObat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaObat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmb_kodeobat = new System.Windows.Forms.ComboBox();
            this.btn_keluar = new System.Windows.Forms.Button();
            this.txt_aturanpakai = new System.Windows.Forms.TextBox();
            this.txt_jmlobat = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_batal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_dokter = new System.Windows.Forms.ComboBox();
            this.cmb_daftar = new System.Windows.Forms.ComboBox();
            this.txt_kodersp = new System.Windows.Forms.TextBox();
            this.txt_namaobat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_namapasien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // batal_btn
            // 
            this.batal_btn.Location = new System.Drawing.Point(352, 343);
            this.batal_btn.Name = "batal_btn";
            this.batal_btn.Size = new System.Drawing.Size(88, 32);
            this.batal_btn.TabIndex = 55;
            this.batal_btn.Text = "Batal";
            this.batal_btn.UseVisualStyleBackColor = true;
            this.batal_btn.Click += new System.EventHandler(this.batal_btn_Click);
            // 
            // simpan_btn
            // 
            this.simpan_btn.Location = new System.Drawing.Point(229, 343);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(88, 32);
            this.simpan_btn.TabIndex = 51;
            this.simpan_btn.Text = "Simpan";
            this.simpan_btn.UseVisualStyleBackColor = true;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(607, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Jumlah Obat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(479, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Aturan Pakai";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(349, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Nama Obat";
            // 
            // dgv_resep
            // 
            this.dgv_resep.AllowUserToAddRows = false;
            this.dgv_resep.AllowUserToDeleteRows = false;
            this.dgv_resep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KodeObat,
            this.JenisObat,
            this.NamaObat,
            this.ExpiredDate});
            this.dgv_resep.Location = new System.Drawing.Point(217, 476);
            this.dgv_resep.Name = "dgv_resep";
            this.dgv_resep.ReadOnly = true;
            this.dgv_resep.RowHeadersWidth = 51;
            this.dgv_resep.RowTemplate.Height = 24;
            this.dgv_resep.Size = new System.Drawing.Size(833, 183);
            this.dgv_resep.TabIndex = 50;
            this.dgv_resep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_resep_CellClick);
            // 
            // KodeObat
            // 
            this.KodeObat.HeaderText = "Kode Obat";
            this.KodeObat.MinimumWidth = 6;
            this.KodeObat.Name = "KodeObat";
            this.KodeObat.ReadOnly = true;
            this.KodeObat.Width = 125;
            // 
            // JenisObat
            // 
            this.JenisObat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JenisObat.HeaderText = "Nama Obat";
            this.JenisObat.MinimumWidth = 6;
            this.JenisObat.Name = "JenisObat";
            this.JenisObat.ReadOnly = true;
            // 
            // NamaObat
            // 
            this.NamaObat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamaObat.HeaderText = "Aturan Pakai";
            this.NamaObat.MinimumWidth = 6;
            this.NamaObat.Name = "NamaObat";
            this.NamaObat.ReadOnly = true;
            // 
            // ExpiredDate
            // 
            this.ExpiredDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExpiredDate.HeaderText = "Jumlah Obat";
            this.ExpiredDate.MinimumWidth = 6;
            this.ExpiredDate.Name = "ExpiredDate";
            this.ExpiredDate.ReadOnly = true;
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
            // cmb_kodeobat
            // 
            this.cmb_kodeobat.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmb_kodeobat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_kodeobat.FormattingEnabled = true;
            this.cmb_kodeobat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_kodeobat.ItemHeight = 16;
            this.cmb_kodeobat.Location = new System.Drawing.Point(229, 445);
            this.cmb_kodeobat.Name = "cmb_kodeobat";
            this.cmb_kodeobat.Size = new System.Drawing.Size(112, 24);
            this.cmb_kodeobat.TabIndex = 25;
            this.cmb_kodeobat.SelectedIndexChanged += new System.EventHandler(this.cmb_kodeobat_SelectedIndexChanged);
            // 
            // btn_keluar
            // 
            this.btn_keluar.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_keluar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_keluar.FlatAppearance.BorderSize = 0;
            this.btn_keluar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btn_keluar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_keluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_keluar.Location = new System.Drawing.Point(818, 3);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(39, 31);
            this.btn_keluar.TabIndex = 57;
            this.btn_keluar.Text = "X";
            this.btn_keluar.UseVisualStyleBackColor = false;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // txt_aturanpakai
            // 
            this.txt_aturanpakai.Location = new System.Drawing.Point(482, 446);
            this.txt_aturanpakai.Multiline = true;
            this.txt_aturanpakai.Name = "txt_aturanpakai";
            this.txt_aturanpakai.Size = new System.Drawing.Size(112, 24);
            this.txt_aturanpakai.TabIndex = 22;
            this.txt_aturanpakai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_aturanpakai_KeyPress);
            // 
            // txt_jmlobat
            // 
            this.txt_jmlobat.Location = new System.Drawing.Point(610, 446);
            this.txt_jmlobat.Multiline = true;
            this.txt_jmlobat.Name = "txt_jmlobat";
            this.txt_jmlobat.Size = new System.Drawing.Size(112, 24);
            this.txt_jmlobat.TabIndex = 24;
            this.txt_jmlobat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_jmlobat_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 675);
            this.panel2.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(275, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pengelolaan Data Resep";
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
            this.panel1.Size = new System.Drawing.Size(862, 100);
            this.panel1.TabIndex = 59;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.Info;
            this.btn_add.Location = new System.Drawing.Point(751, 445);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(52, 24);
            this.btn_add.TabIndex = 60;
            this.btn_add.Text = "add..";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.SystemColors.Info;
            this.btn_del.Location = new System.Drawing.Point(867, 444);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(52, 24);
            this.btn_del.TabIndex = 61;
            this.btn_del.Text = "del..";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_batal
            // 
            this.btn_batal.BackColor = System.Drawing.SystemColors.Info;
            this.btn_batal.Location = new System.Drawing.Point(809, 444);
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.Size = new System.Drawing.Size(52, 24);
            this.btn_batal.TabIndex = 62;
            this.btn_batal.Text = "batal";
            this.btn_batal.UseVisualStyleBackColor = false;
            this.btn_batal.Click += new System.EventHandler(this.btn_batal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(226, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "Kode Resep";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(226, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 64;
            this.label5.Text = "Nama Dokter";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(226, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 16);
            this.label9.TabIndex = 66;
            this.label9.Text = "Kode Pendaftaran";
            // 
            // cmb_dokter
            // 
            this.cmb_dokter.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmb_dokter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_dokter.FormattingEnabled = true;
            this.cmb_dokter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_dokter.ItemHeight = 16;
            this.cmb_dokter.Location = new System.Drawing.Point(229, 212);
            this.cmb_dokter.Name = "cmb_dokter";
            this.cmb_dokter.Size = new System.Drawing.Size(161, 24);
            this.cmb_dokter.TabIndex = 67;
            this.cmb_dokter.SelectedIndexChanged += new System.EventHandler(this.cmb_dokter_SelectedIndexChanged);
            // 
            // cmb_daftar
            // 
            this.cmb_daftar.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmb_daftar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_daftar.FormattingEnabled = true;
            this.cmb_daftar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_daftar.ItemHeight = 16;
            this.cmb_daftar.Location = new System.Drawing.Point(229, 270);
            this.cmb_daftar.Name = "cmb_daftar";
            this.cmb_daftar.Size = new System.Drawing.Size(161, 24);
            this.cmb_daftar.TabIndex = 68;
            this.cmb_daftar.SelectedIndexChanged += new System.EventHandler(this.cmb_daftar_SelectedIndexChanged);
            // 
            // txt_kodersp
            // 
            this.txt_kodersp.Enabled = false;
            this.txt_kodersp.Location = new System.Drawing.Point(229, 151);
            this.txt_kodersp.Multiline = true;
            this.txt_kodersp.Name = "txt_kodersp";
            this.txt_kodersp.Size = new System.Drawing.Size(161, 24);
            this.txt_kodersp.TabIndex = 70;
            // 
            // txt_namaobat
            // 
            this.txt_namaobat.Location = new System.Drawing.Point(352, 447);
            this.txt_namaobat.Multiline = true;
            this.txt_namaobat.Name = "txt_namaobat";
            this.txt_namaobat.ReadOnly = true;
            this.txt_namaobat.Size = new System.Drawing.Size(112, 24);
            this.txt_namaobat.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(226, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 72;
            this.label2.Text = "Kode Obat";
            // 
            // txt_namapasien
            // 
            this.txt_namapasien.Location = new System.Drawing.Point(412, 270);
            this.txt_namapasien.Name = "txt_namapasien";
            this.txt_namapasien.ReadOnly = true;
            this.txt_namapasien.Size = new System.Drawing.Size(182, 22);
            this.txt_namapasien.TabIndex = 73;
            // 
            // ResepFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 675);
            this.Controls.Add(this.txt_namapasien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_namaobat);
            this.Controls.Add(this.txt_kodersp);
            this.Controls.Add(this.cmb_daftar);
            this.Controls.Add(this.cmb_dokter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_batal);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.batal_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.simpan_btn);
            this.Controls.Add(this.dgv_resep);
            this.Controls.Add(this.cmb_kodeobat);
            this.Controls.Add(this.txt_aturanpakai);
            this.Controls.Add(this.txt_jmlobat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResepFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResepFrm";
            this.Load += new System.EventHandler(this.ResepFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button batal_btn;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_resep;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmb_kodeobat;
        private System.Windows.Forms.Button btn_keluar;
        private System.Windows.Forms.TextBox txt_aturanpakai;
        private System.Windows.Forms.TextBox txt_jmlobat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_batal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_dokter;
        private System.Windows.Forms.ComboBox cmb_daftar;
        private System.Windows.Forms.TextBox txt_kodersp;
        private System.Windows.Forms.TextBox txt_namaobat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodeObat;
        private System.Windows.Forms.DataGridViewTextBoxColumn JenisObat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaObat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiredDate;
        private System.Windows.Forms.TextBox txt_namapasien;
    }
}