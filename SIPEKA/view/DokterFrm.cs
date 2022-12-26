using System;
using System.Drawing;
using System.Windows.Forms;


namespace SIPEKA.view
{
    using report;
    using SIPEKA.model;
    using System.Data;

    public partial class DokterFrm : Form
    {

        model.Dokter dokter = new model.Dokter();
        model.Poli poli= new model.Poli();
        public DokterFrm()
        {
            InitializeComponent();
            nama_dokter_txt.Focus();
        }

        void tampilGrid()
        {
            if (txt_search.Text.Trim() == "")
            {
                dokter_dgv.DataSource = dokter.tampilkanSemua();
            }
            else
            {
                dokter_dgv.DataSource = dokter.tampilkanSemua(txt_search.Text);
            }
            belangBelang(dokter_dgv);
        }

        void isiPoli()
        {
            DataTable data = new DataTable();
            data = poli.tampilkanSemua();

            if (data.Rows.Count > 0)
            {
                cmb_poli.Items.Clear();
                foreach (DataRow dt in data.Rows)
                {
                    cmb_poli.Items.Add(dt[1].ToString());
                }
            }
        }

        void isiJadwal()
        {
            jadwal_cmb.Items.Clear();
            jadwal_cmb.Items.Add("Senin");
            jadwal_cmb.Items.Add("Selasa");
            jadwal_cmb.Items.Add("Rabu");
            jadwal_cmb.Items.Add("Kamis");
            jadwal_cmb.Items.Add("Jumat");
            jadwal_cmb.Items.Add("Sabtu");
            jadwal_cmb.Items.Add("Minggu");
        }

        void bersihkan()
        {
            txt_dokter.Clear();
            nama_dokter_txt.Clear();
            cmb_poli.Items.Clear();
            telepon_txt.Clear();
            jadwal_cmb.Items.Clear();
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

        private void DokterFrm_Load(object sender, EventArgs e)
        {
            txt_dokter.Text = dokter.buatKode();
            nama_dokter_txt.Focus();
            tampilGrid();
            isiPoli();
            isiJadwal();
        }

        private void simpan_btn_Click(object sender, EventArgs e)
        {
            if (!dokter.cekKode(txt_dokter.Text))
            {
                dokter.Kode_Dokter = txt_dokter.Text;
                dokter.Nama_Dokter = nama_dokter_txt.Text;
                dokter.Poli = poli.ambilKodePolibyNama(cmb_poli.Text);
                dokter.No_Telepon = telepon_txt.Text;
                dokter.Jadwal = jadwal_cmb.Text;
                dokter.simpanData();
                MessageBox.Show("Data Berhasil Disimpan.");
            }
            tampilGrid();
            bersihkan();
            isiPoli();
            isiJadwal();
            txt_dokter.Text = dokter.buatKode();
            nama_dokter_txt.Focus();
        }

        private void ubah_btn_Click(object sender, EventArgs e)
        {
            if (dokter.cekKode(txt_dokter.Text))
            {
                if (MessageBox.Show("Yakin akan diubah ?", "Ubah Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dokter.Kode_Dokter = txt_dokter.Text;
                    dokter.Nama_Dokter = nama_dokter_txt.Text;
                    dokter.Poli = poli.ambilKodePolibyNama(cmb_poli.Text);
                    dokter.No_Telepon = telepon_txt.Text;
                    dokter.Jadwal = jadwal_cmb.Text;

                    dokter.ubahData(txt_dokter.Text);


                    MessageBox.Show("Ubah Data Berhasil.", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihkan();
                    isiPoli();
                    isiJadwal();
                    tampilGrid();
                    txt_dokter.Text = dokter.buatKode();
                    nama_dokter_txt.Focus();
                }
            }
        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            if (dokter.cekKode(txt_dokter.Text))
            {
                if (MessageBox.Show("Yakin akan dihapus ?", "Ubah Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dokter.hapusData(txt_dokter.Text);

                    MessageBox.Show("Hapus Data Berhasil.", "Hapus Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihkan();
                    isiPoli();
                    isiJadwal();
                    tampilGrid();
                    txt_dokter.Text = dokter.buatKode();
                    nama_dokter_txt.Focus();
                }
            }
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah yakin anda akan keluar dari Form Dokter?",
                    "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
            {
                Close();
            }
        }

        private void batal_btn_Click(object sender, EventArgs e)
        {
            bersihkan();
            isiJadwal();
            isiPoli();
            txt_dokter.Text = dokter.buatKode();
            nama_dokter_txt.Focus();
        }

        private void dokter_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = this.dokter_dgv.Rows[e.RowIndex];

            txt_dokter.Text = baris.Cells[0].Value.ToString();
            nama_dokter_txt.Text = baris.Cells[1].Value.ToString();
            cmb_poli.Text = baris.Cells[2].Value.ToString();
            telepon_txt.Text = baris.Cells[3].Value.ToString();
            jadwal_cmb.Text = baris.Cells[4].Value.ToString();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

        private void btn_cetak_Click(object sender, EventArgs e)
        {
            if (nama_dokter_txt.Text=="")
            {
                LaporanDokterFrm cetakDokter = new LaporanDokterFrm();
                cetakDokter.ShowDialog();
            }
            else
            {
                LaporanDokterFrmFilter cetakDokterFilter = new LaporanDokterFrmFilter(txt_dokter.Text.Trim());
                cetakDokterFilter.ShowDialog();
            }
        }

        private void telepon_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false          // -- jika bukan digit
            && (int)e.KeyChar != (int)Keys.Back)     // -- dan bukan backspace
            {
                e.Handled = true;                         // -- membatalkan event keypress         
            }
        }

        private void DokterFrm_Activated(object sender, EventArgs e)
        {
            nama_dokter_txt.Focus();
        }

        private void nama_dokter_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//13 adalah kode untuk enter
            {
                telepon_txt.Focus();
            }
        }
    }
}
