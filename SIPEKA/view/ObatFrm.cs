using System;
using System.Drawing;
using System.Windows.Forms;

namespace SIPEKA.model
{
    public partial class ObatFrm : Form
    {
        Obat obat = new Obat();

        public ObatFrm()
        {
            InitializeComponent();
        }
        void bersihkan()
        {
            txt_kodeobat.Clear();
            cmb_jnsobat.Items.Clear();
            txt_namaobat.Clear();
            date_expired.Value=DateTime.Now;
            txt_stok.Clear();
        }
        void isiJenisObat()
        {
            cmb_jnsobat.Items.Add("Obat Cair");
            cmb_jnsobat.Items.Add("Kapsul");
            cmb_jnsobat.Items.Add("Tablet");
            cmb_jnsobat.Items.Add("Obat Tetes");
            cmb_jnsobat.Items.Add("Obat Suntik");
        }
        void tampilData()
        {
            if (txt_search.Text.Trim()=="")
            {
                dgv_obat.DataSource = obat.tampilSemuaGrid();
            }
            else
            {
                dgv_obat.DataSource = obat.cariNama(txt_search.Text);
            }
            belangBelang(dgv_obat);
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
        string ambilTanggal(DateTime tgl)
        {
            string stgl = "";
            stgl=tgl.Year.ToString()+"/"+tgl.Month.ToString()+"/"+tgl.Day.ToString();


            return stgl;
        }

        private void Obat_Load(object sender, EventArgs e)
        {
            txt_kodeobat.Text = obat.buatKode();
            tampilData();
            isiJenisObat();

        }

        private void simpan_btn_Click(object sender, EventArgs e)
        {
            if (cmb_jnsobat.SelectedItem==null && txt_namaobat.Text=="" && txt_stok.Text=="")
            {
                MessageBox.Show("Data tidak boleh kosong", "Informasi");
            }
            else if (cmb_jnsobat.SelectedItem==null)
            {
                MessageBox.Show("Jenis Obat belum dipilih", "Informasi");
            }
            else if (txt_namaobat.Text=="")
            {
                MessageBox.Show("Nama obat belum diisi", "Informasi");
                txt_namaobat.Focus();
            }
            else if (txt_stok.Text=="")
            {
                MessageBox.Show("Stok obat belum diisi", "Informasi");
                txt_stok.Focus();
            }
            else
            {
                if (!obat.apakahAda(txt_kodeobat.Text))
                {
                    obat.Kode_Obat = txt_kodeobat.Text;
                    obat.Jns_Obat = cmb_jnsobat.Text;
                    obat.Nama_Obat = txt_namaobat.Text;
                    obat.Exp_Date = ambilTanggal(date_expired.Value);
                    obat.Stok = txt_stok.Text;
                    obat.simpan();

                    MessageBox.Show("Tambah data berhasil.", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihkan();
                    txt_kodeobat.Text = obat.buatKode();
                    isiJenisObat();
                    tampilData();
                    txt_namaobat.Focus();
                }
            }
        }
        private void ubah_btn_Click(object sender, EventArgs e)
        {
            if (obat.apakahAda(txt_kodeobat.Text))
            {
                if (MessageBox.Show("Yakin akan diubah ?", "Ubah Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    obat.Kode_Obat = txt_kodeobat.Text;
                    obat.Nama_Obat = txt_namaobat.Text;
                    obat.Jns_Obat = cmb_jnsobat.Text;
                    obat.Exp_Date = ambilTanggal(date_expired.Value);
                    obat.Stok = txt_stok.Text;
                    obat.ubah(txt_kodeobat.Text);
                    MessageBox.Show("Ubah data berhasil.", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihkan();
                    isiJenisObat();
                    txt_kodeobat.Text = obat.buatKode();
                    tampilData();
                    txt_namaobat.Focus();
                }
            }
        }
        private void hapus_btn_Click(object sender, EventArgs e)
        {
            if (obat.apakahAda(txt_kodeobat.Text))
            {
                if (MessageBox.Show("Yakin akan dihapus ?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    obat.hapus(txt_kodeobat.Text);
                    MessageBox.Show("Hapus data berhasil.", "Hapus Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihkan();
                    isiJenisObat();
                    txt_kodeobat.Text = obat.buatKode();
                    tampilData();
                    txt_namaobat.Focus();
                }
            }
        }


        private void dgv_obat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = this.dgv_obat.Rows[e.RowIndex];

            txt_kodeobat.Text = baris.Cells[0].Value.ToString();
            cmb_jnsobat.Text = baris.Cells[1].Value.ToString();
            txt_namaobat.Text = baris.Cells[2].Value.ToString();
            date_expired.Text = baris.Cells[3].Value.ToString();
            txt_stok.Text = baris.Cells[4].Value.ToString();
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah yakin anda akan keluar dari Form Obat?",
                    "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
            {
                Close();
            }
        }

        private void batal_btn_Click(object sender, EventArgs e)
        {
            bersihkan();
            isiJenisObat();
            txt_namaobat.Focus();
            txt_kodeobat.Text = obat.buatKode();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            tampilData();
        }

        private void txt_stok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false          // -- jika bukan digit
                && (int)e.KeyChar != (int)Keys.Back)     // -- dan bukan backspace
            {
                e.Handled = true;                         // -- membatalkan event keypress         
            }
        }

        private void cmb_jnsobat_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_namaobat.Focus();
        }

        private void txt_namaobat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//13 adalah kode untuk enter
            {
                date_expired.Focus();
            }
        }

        private void date_expired_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//13 adalah kode untuk enter
            {
                txt_stok.Focus();
            }
        }
    }
}
