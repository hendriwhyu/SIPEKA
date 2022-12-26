using SIPEKA.model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SIPEKA.view
{
    using report;
    public partial class SearchPasien : Form
    {
        searchPasien pasien = new searchPasien();
        public SearchPasien()
        {
            InitializeComponent();
        }

        private void SearchPasien_Load(object sender, EventArgs e)
        {
            tampilData();
        }
        void tampilData()
        {
            if (txt_search.Text.Trim()=="")
            {
                dgv_pasien.DataSource = pasien.tampildataPasien();
            }
            else
            {
                dgv_pasien.DataSource = pasien.cariKolom(txt_search.Text);
            }
            belangBelang(dgv_pasien);
        }
        void belangBelang(DataGridView dgv)
        {
            foreach (DataGridViewRow baris in dgv.Rows)
            {
                foreach (DataGridViewCell kolom in baris.Cells)
                {
                    if (baris.Index % 2 == 0)
                    {
                        kolom.Style.BackColor = Color.LightGray;
                    }
                    else
                    {
                        kolom.Style.BackColor = Color.WhiteSmoke;
                    }
                }
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            tampilData();
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah yakin anda akan keluar dari Form Search Pasien?",
                   "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                   == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_cetak_Click(object sender, EventArgs e)
        {
            if (txt_no_kartu.Text == "")
            {
                MessageBox.Show("Data Tidak Ditemukan.");
            }
            else
            {
                LaporanRekapMedisPasienFrm cetakRekapPasien = new LaporanRekapMedisPasienFrm(txt_no_kartu.Text);
                cetakRekapPasien.ShowDialog();
            }
        }

        private void dgv_pasien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = this.dgv_pasien.Rows[e.RowIndex];

            txt_no_kartu.Text = baris.Cells[0].Value.ToString();
        }
    }
}
