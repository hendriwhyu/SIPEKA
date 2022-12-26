namespace SIPEKA.view
{
    partial class Pengguna_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pengguna_Frm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_namaPengguna = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cariPengguna = new System.Windows.Forms.TextBox();
            this.dgv_Pengguna = new System.Windows.Forms.DataGridView();
            this.cUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_kembali = new System.Windows.Forms.Button();
            this.btn_batal = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pengguna)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.txt_namaPengguna);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 555);
            this.panel1.TabIndex = 0;
            // 
            // txt_namaPengguna
            // 
            this.txt_namaPengguna.Location = new System.Drawing.Point(16, 373);
            this.txt_namaPengguna.Margin = new System.Windows.Forms.Padding(4);
            this.txt_namaPengguna.Name = "txt_namaPengguna";
            this.txt_namaPengguna.Size = new System.Drawing.Size(168, 22);
            this.txt_namaPengguna.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 335);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 35);
            this.label6.TabIndex = 8;
            this.label6.Text = "NAMA PENGGUNA";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(23, 283);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(161, 22);
            this.txt_password.TabIndex = 7;
            this.txt_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_password_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 35);
            this.label5.TabIndex = 6;
            this.label5.Text = "PASSWORD";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(23, 191);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(161, 22);
            this.txt_username.TabIndex = 5;
            this.txt_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_username_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 75);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 35);
            this.label4.TabIndex = 2;
            this.label4.Text = "USERNAME";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_kembali);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(227, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 91);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(171, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(437, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "PENGELOLAAN DATA PENGGUNA";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.dgv_Pengguna);
            this.panel3.Controls.Add(this.btn_batal);
            this.panel3.Controls.Add(this.btn_hapus);
            this.panel3.Controls.Add(this.btn_ubah);
            this.panel3.Controls.Add(this.btn_tambah);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(227, 91);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(829, 464);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cariPengguna);
            this.groupBox1.Location = new System.Drawing.Point(31, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(696, 49);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari";
            // 
            // txt_cariPengguna
            // 
            this.txt_cariPengguna.Location = new System.Drawing.Point(7, 22);
            this.txt_cariPengguna.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cariPengguna.Name = "txt_cariPengguna";
            this.txt_cariPengguna.Size = new System.Drawing.Size(688, 22);
            this.txt_cariPengguna.TabIndex = 10;
            this.txt_cariPengguna.TextChanged += new System.EventHandler(this.txt_cariPengguna_TextChanged);
            // 
            // dgv_Pengguna
            // 
            this.dgv_Pengguna.AllowUserToAddRows = false;
            this.dgv_Pengguna.AllowUserToDeleteRows = false;
            this.dgv_Pengguna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pengguna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cUser,
            this.cPassword,
            this.cNama});
            this.dgv_Pengguna.Location = new System.Drawing.Point(31, 121);
            this.dgv_Pengguna.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Pengguna.Name = "dgv_Pengguna";
            this.dgv_Pengguna.ReadOnly = true;
            this.dgv_Pengguna.RowHeadersWidth = 51;
            this.dgv_Pengguna.Size = new System.Drawing.Size(696, 297);
            this.dgv_Pengguna.TabIndex = 16;
            this.dgv_Pengguna.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Pengguna_CellClick);
            this.dgv_Pengguna.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Pengguna_ColumnHeaderMouseClick);
            // 
            // cUser
            // 
            this.cUser.DataPropertyName = "username";
            this.cUser.HeaderText = "USERNAME";
            this.cUser.MinimumWidth = 6;
            this.cUser.Name = "cUser";
            this.cUser.ReadOnly = true;
            this.cUser.Width = 125;
            // 
            // cPassword
            // 
            this.cPassword.DataPropertyName = "password";
            this.cPassword.HeaderText = "PASSWORD";
            this.cPassword.MinimumWidth = 6;
            this.cPassword.Name = "cPassword";
            this.cPassword.ReadOnly = true;
            this.cPassword.Width = 125;
            // 
            // cNama
            // 
            this.cNama.DataPropertyName = "nama_user";
            this.cNama.HeaderText = "NAMA PENGGUNA";
            this.cNama.MinimumWidth = 6;
            this.cNama.Name = "cNama";
            this.cNama.ReadOnly = true;
            this.cNama.Width = 360;
            // 
            // btn_kembali
            // 
            this.btn_kembali.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_kembali.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kembali.Location = new System.Drawing.Point(790, 4);
            this.btn_kembali.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Size = new System.Drawing.Size(35, 34);
            this.btn_kembali.TabIndex = 15;
            this.btn_kembali.Text = "X";
            this.btn_kembali.UseVisualStyleBackColor = false;
            this.btn_kembali.Click += new System.EventHandler(this.btn_kembali_Click);
            // 
            // btn_batal
            // 
            this.btn_batal.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_batal.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_batal.Location = new System.Drawing.Point(473, 30);
            this.btn_batal.Margin = new System.Windows.Forms.Padding(4);
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.Size = new System.Drawing.Size(109, 34);
            this.btn_batal.TabIndex = 13;
            this.btn_batal.Text = "BATAL";
            this.btn_batal.UseVisualStyleBackColor = false;
            this.btn_batal.Click += new System.EventHandler(this.btn_batal_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_hapus.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.Location = new System.Drawing.Point(325, 30);
            this.btn_hapus.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(109, 34);
            this.btn_hapus.TabIndex = 12;
            this.btn_hapus.Text = "HAPUS";
            this.btn_hapus.UseVisualStyleBackColor = false;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_ubah
            // 
            this.btn_ubah.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_ubah.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ubah.Location = new System.Drawing.Point(177, 30);
            this.btn_ubah.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(109, 34);
            this.btn_ubah.TabIndex = 11;
            this.btn_ubah.Text = "UBAH";
            this.btn_ubah.UseVisualStyleBackColor = false;
            this.btn_ubah.Click += new System.EventHandler(this.btn_ubah_Click);
            // 
            // btn_tambah
            // 
            this.btn_tambah.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_tambah.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tambah.Location = new System.Drawing.Point(31, 30);
            this.btn_tambah.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(109, 34);
            this.btn_tambah.TabIndex = 10;
            this.btn_tambah.Text = "TAMBAH";
            this.btn_tambah.UseVisualStyleBackColor = false;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // Pengguna_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 555);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pengguna_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pengguna_Frm";
            this.Load += new System.EventHandler(this.Pengguna_Frm_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pengguna)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_namaPengguna;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_Pengguna;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNama;
        private System.Windows.Forms.TextBox txt_cariPengguna;
        private System.Windows.Forms.Button btn_kembali;
        private System.Windows.Forms.Button btn_batal;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}