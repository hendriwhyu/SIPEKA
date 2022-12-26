using SIPEKA.model;
using System;
using System.Windows.Forms;

namespace SIPEKA.view
{
    public partial class HomeDokter : Form
    {
        model.Login home = new model.Login();
        string user;
        string pass;
        string level;
        public HomeDokter(string user, string pass, string level)
        {
            this.user = user;
            this.pass = pass;
            InitializeComponent();
            nama_lbl.Text = home.tampilNamaByKode(user, pass);
            this.level=level;
        }

        private void Home_Activated(object sender, EventArgs e)
        {
            nama_lbl.Text = home.tampilNamaByKode(user, pass);
        }


        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void close_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah yakin anda akan keluar dari Homepage?",
                   "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                   == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_sizable_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }


        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void dokter_btn_Click(object sender, EventArgs e)
        {
            DokterFrm dokter = new DokterFrm();
            dokter.ShowDialog();
        }

        private void caripasien_btn_Click(object sender, EventArgs e)
        {
            SearchPasien pasien = new SearchPasien();
            pasien.ShowDialog();
        }

        private void obat_btn_Click(object sender, EventArgs e)
        {
            ObatFrm obat = new ObatFrm();
            obat.ShowDialog();
        }

        private void poli_btn_Click(object sender, EventArgs e)
        {
            Poli_Frm poli = new Poli_Frm();
            poli.ShowDialog();
        }

        private void pengguna_btn_Click(object sender, EventArgs e)
        {
            Pengguna_Frm pengguna = new Pengguna_Frm();
            pengguna.ShowDialog();
        }

        private void master_data_btn_Click(object sender, EventArgs e)
        {

            pnlTop.Visible = true;
            pnl_header.Visible = true;
            pnlLeft.Visible = true;
            pnlmasterdata.Visible = true;
            pnl_Tentang.Visible = false;
        }

        private void lainnya_btn_Click(object sender, EventArgs e)
        {
            pnlTop.Visible = true;
            pnl_header.Visible = true;
            pnlLeft.Visible = true;
            pnlmasterdata.Visible = false;
            pnl_Tentang.Visible = false;
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login_frm login = new Login_frm();
            this.Hide();
            login.ShowDialog();
        }

        private void aplikasi_btn_Click(object sender, EventArgs e)
        {
            pnlTop.Visible = true;
            pnl_header.Visible = true;
            pnlLeft.Visible = true;
            pnlmasterdata.Visible = false;
            pnl_Tentang.Visible = true;
        }


        private void btn_resep_Click(object sender, EventArgs e)
        {
            ResepFrm resep = new ResepFrm();
            resep.ShowDialog();
        }


        private void btn_pasien_Click(object sender, EventArgs e)
        {
            SearchPasien search = new SearchPasien();
            search.ShowDialog();
        }
    }
}
