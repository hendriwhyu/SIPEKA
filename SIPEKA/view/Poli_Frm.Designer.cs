namespace SIPEKA.view
{
    partial class Poli_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Poli_Frm));
            this.batal_btn = new System.Windows.Forms.Button();
            this.ubah_btn = new System.Windows.Forms.Button();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kode_poli = new System.Windows.Forms.TextBox();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.poli_dgv = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_keluar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_namapoli = new System.Windows.Forms.TextBox();
            this.kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JenisObat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.poli_dgv)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // batal_btn
            // 
            this.batal_btn.BackColor = System.Drawing.Color.BurlyWood;
            this.batal_btn.Location = new System.Drawing.Point(599, 126);
            this.batal_btn.Name = "batal_btn";
            this.batal_btn.Size = new System.Drawing.Size(88, 32);
            this.batal_btn.TabIndex = 55;
            this.batal_btn.Text = "Batal";
            this.batal_btn.UseVisualStyleBackColor = false;
            this.batal_btn.Click += new System.EventHandler(this.batal_btn_Click);
            // 
            // ubah_btn
            // 
            this.ubah_btn.BackColor = System.Drawing.Color.BurlyWood;
            this.ubah_btn.Location = new System.Drawing.Point(345, 126);
            this.ubah_btn.Name = "ubah_btn";
            this.ubah_btn.Size = new System.Drawing.Size(88, 32);
            this.ubah_btn.TabIndex = 53;
            this.ubah_btn.Text = "Ubah";
            this.ubah_btn.UseVisualStyleBackColor = false;
            this.ubah_btn.Click += new System.EventHandler(this.ubah_btn_Click);
            // 
            // simpan_btn
            // 
            this.simpan_btn.BackColor = System.Drawing.Color.BurlyWood;
            this.simpan_btn.Location = new System.Drawing.Point(222, 126);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(88, 32);
            this.simpan_btn.TabIndex = 51;
            this.simpan_btn.Text = "Simpan";
            this.simpan_btn.UseVisualStyleBackColor = false;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(7, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Poli";
            // 
            // txt_kode_poli
            // 
            this.txt_kode_poli.Enabled = false;
            this.txt_kode_poli.Location = new System.Drawing.Point(12, 204);
            this.txt_kode_poli.Multiline = true;
            this.txt_kode_poli.Name = "txt_kode_poli";
            this.txt_kode_poli.ReadOnly = true;
            this.txt_kode_poli.Size = new System.Drawing.Size(164, 30);
            this.txt_kode_poli.TabIndex = 20;
            // 
            // hapus_btn
            // 
            this.hapus_btn.BackColor = System.Drawing.Color.BurlyWood;
            this.hapus_btn.Location = new System.Drawing.Point(467, 126);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(88, 32);
            this.hapus_btn.TabIndex = 54;
            this.hapus_btn.Text = "Hapus";
            this.hapus_btn.UseVisualStyleBackColor = false;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // poli_dgv
            // 
            this.poli_dgv.AllowUserToAddRows = false;
            this.poli_dgv.AllowUserToDeleteRows = false;
            this.poli_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poli_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kode,
            this.JenisObat});
            this.poli_dgv.Location = new System.Drawing.Point(216, 219);
            this.poli_dgv.Name = "poli_dgv";
            this.poli_dgv.ReadOnly = true;
            this.poli_dgv.RowHeadersWidth = 51;
            this.poli_dgv.RowTemplate.Height = 24;
            this.poli_dgv.Size = new System.Drawing.Size(836, 435);
            this.poli_dgv.TabIndex = 50;
            this.poli_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.poli_dgv_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(12, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Nama Poli";
            // 
            // btn_keluar
            // 
            this.btn_keluar.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_keluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_keluar.Location = new System.Drawing.Point(823, 3);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(34, 32);
            this.btn_keluar.TabIndex = 57;
            this.btn_keluar.Text = "X";
            this.btn_keluar.UseVisualStyleBackColor = false;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.txt_namapoli);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_kode_poli);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 666);
            this.panel2.TabIndex = 58;
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
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(6, 21);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(315, 22);
            this.txt_search.TabIndex = 40;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Location = new System.Drawing.Point(222, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 49);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(275, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pengelolaan Poli";
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
            // txt_namapoli
            // 
            this.txt_namapoli.Location = new System.Drawing.Point(12, 306);
            this.txt_namapoli.Multiline = true;
            this.txt_namapoli.Name = "txt_namapoli";
            this.txt_namapoli.Size = new System.Drawing.Size(164, 30);
            this.txt_namapoli.TabIndex = 31;
            // 
            // kode
            // 
            this.kode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kode.DataPropertyName = "kode_poli";
            this.kode.HeaderText = "Kode Poli";
            this.kode.MinimumWidth = 6;
            this.kode.Name = "kode";
            this.kode.ReadOnly = true;
            // 
            // JenisObat
            // 
            this.JenisObat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JenisObat.DataPropertyName = "nama_poli";
            this.JenisObat.HeaderText = "Nama Poli";
            this.JenisObat.MinimumWidth = 6;
            this.JenisObat.Name = "JenisObat";
            this.JenisObat.ReadOnly = true;
            // 
            // Poli_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 666);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.batal_btn);
            this.Controls.Add(this.ubah_btn);
            this.Controls.Add(this.simpan_btn);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.poli_dgv);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Poli_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Poli_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poli_dgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button batal_btn;
        private System.Windows.Forms.Button ubah_btn;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kode_poli;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.DataGridView poli_dgv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_keluar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn JenisObat;
        private System.Windows.Forms.TextBox txt_namapoli;
    }
}