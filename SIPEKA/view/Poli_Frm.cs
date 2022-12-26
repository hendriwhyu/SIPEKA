using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SIPEKA.view
{
    public partial class Poli_Frm : Form
    {
        model.Poli poli = new model.Poli();

        public Poli_Frm()
        {
            InitializeComponent();
        }
        void tampilGrid()
        {
            if (txt_search.Text.Trim() == "")
            {
                poli_dgv.DataSource = poli.tampilkanSemua();
            }
            else
            {
                poli_dgv.DataSource = poli.SearchSemua(txt_search.Text);
            }
            belangBelang(poli_dgv);
        }

        private void Poli_Frm_Load(object sender, EventArgs e)
        {
            tampilGrid();
            txt_kode_poli.Text = poli.buatKode();
        }

        void bersihkan()
        {
            txt_kode_poli.Text = poli.buatKode();
            txt_namapoli.Text = "";
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

        private void simpan_btn_Click(object sender, EventArgs e)
        {
            if (!poli.cekKode(txt_kode_poli.Text))
            {
                poli.Kode_Poli = txt_kode_poli.Text;
                poli.Nama_Poli = txt_namapoli.Text;

                if (txt_namapoli.Text == "")
                {
                    MessageBox.Show("Data Tidak Boleh Kosong.");
                }
                else
                {
                    poli.simpanData();
                    MessageBox.Show("Data Berhasil Disimpan.");
                }

            }
            tampilGrid();
            txt_kode_poli.Text = poli.buatKode();
            txt_kode_poli.Focus();
            bersihkan();
        }

        private void ubah_btn_Click(object sender, EventArgs e)
        {
            if (poli.cekKode(txt_kode_poli.Text))
            {
                if (MessageBox.Show("Yakin akan diubah ?", "Ubah Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    poli.Kode_Poli = txt_kode_poli.Text;
                    poli.Nama_Poli = txt_namapoli.Text;
                    poli.ubahData(txt_kode_poli.Text);


                    MessageBox.Show("Ubah Data Berhasil.", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tampilGrid();
                    txt_kode_poli.Focus();
                    bersihkan();
                }
            }
        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            if (poli.cekKode(txt_kode_poli.Text))
            {
                if (MessageBox.Show("Yakin akan dihapus ?", "Ubah Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    poli.hapusData(txt_kode_poli.Text);

                    MessageBox.Show("Hapus Data Berhasil.", "Hapus Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tampilGrid();
                    txt_kode_poli.Focus();
                    bersihkan();
                }
            }
        }

        private void batal_btn_Click(object sender, EventArgs e)
        {
            bersihkan();
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah yakin anda akan keluar dari Form Poli?",
                   "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                   == DialogResult.Yes)
            {
                Close();
            }
        }

        private void poli_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = this.poli_dgv.Rows[e.RowIndex];

            txt_kode_poli.Text = baris.Cells[0].Value.ToString();
            txt_namapoli.Text = baris.Cells[1].Value.ToString();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

        private void txt_biaya_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false          // -- jika bukan digit
                && (int)e.KeyChar != (int)Keys.Back)     // -- dan bukan backspace
            {
                e.Handled = true;                         // -- membatalkan event keypress         
            }
        }

    }
}
