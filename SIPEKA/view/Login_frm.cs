using System;
using System.Windows.Forms;

namespace SIPEKA.view
{
    public partial class Login_frm : Form
    {
        model.Login log = new model.Login();
        public Login_frm()
        {
            InitializeComponent();
            isiLevel();
        }
        void isiLevel()
        {
            cmb_level.Items.Add("Dokter");
            cmb_level.Items.Add("Admin");
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah yakin anda akan keluar dari Form Login?",
                   "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                   == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (username_txt.Text=="" && password_txt.Text=="" && cmb_level.Text=="")
            {
                MessageBox.Show("Data tidak boleh kosong", "Informasi");
                username_txt.Focus();
            }
            else if (username_txt.Text=="")
            {
                MessageBox.Show("Masukkan username anda terlebih dahulu", "Informasi");
                username_txt.Focus();
            }
            else if (password_txt.Text=="")
            {
                MessageBox.Show("Masukkan password anda", "Informasi");
                password_txt.Focus();
            }
            else if (cmb_level.Text=="")
            {
                MessageBox.Show("Masukkan level anda", "Informasi");
                password_txt.Focus();
            }
            else
            {
                if (!(log.cekUserPassword(username_txt.Text, password_txt.Text)))
                {
                    MessageBox.Show("Username atau password anda salah", "Informasi");
                    username_txt.Focus();
                    username_txt.Text="";
                    password_txt.Text="";
                    cmb_level.Items.Clear();
                    isiLevel();
                }
                else if(!(log.cekUserLevel(username_txt.Text, password_txt.Text,cmb_level.Text))){
                    MessageBox.Show("Level anda tidak sesuai salah", "Informasi");
                    username_txt.Focus();
                    username_txt.Text="";
                    password_txt.Text="";
                    cmb_level.Items.Clear();
                    isiLevel();
                }
                else if(log.cekUserLevel(username_txt.Text,password_txt.Text,cmb_level.Text))
                {
                    if (cmb_level.Text=="Dokter")
                    {
                        HomeDokter utama = new HomeDokter(username_txt.Text, password_txt.Text, cmb_level.Text);
                        utama.Show();
                        this.Hide();

                    }
                    else if (cmb_level.Text=="Admin")
                    {
                        Home utama = new Home(username_txt.Text, password_txt.Text, cmb_level.Text);
                        utama.Show();
                        this.Hide();
                    }
                    
                }
            }
        }

        private void username_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//13 adalah kode untuk enter
            {
                password_txt.Focus();
            }
        }

        private void password_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//13 adalah kode untuk enter
            {
                login_btn.Focus();
            }
        }
    }
}
