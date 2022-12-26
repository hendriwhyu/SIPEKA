using CrystalDecisions.Shared;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SIPEKA
{
    public partial class PendaftaranFrm : Form
    {
        model.pendaftaran1 daftar = new model.pendaftaran1();
        model.Pasien pasien = new model.Pasien();
        model.Poli poli = new model.Poli();
        model.Dokter dokter = new model.Dokter();
        public PendaftaranFrm()
        {
            InitializeComponent();
        }
        void Hari()
        {
            DayOfWeek dwk = DateTime.Today.DayOfWeek;
            if (dwk == DayOfWeek.Sunday)
            {
                lbl_hari.Text = "Minggu";
            }
            else if (dwk == DayOfWeek.Monday)
            {
                lbl_hari.Text = "Senin";
            }
            else if (dwk== DayOfWeek.Tuesday)
            {
                lbl_hari.Text = "Selasa";
            }
            else if (dwk==DayOfWeek.Wednesday)
            {
                lbl_hari.Text = "Rabu";
            }
            else if (dwk==DayOfWeek.Thursday)
            {
                lbl_hari.Text = "Kamis";
            }
            else if (dwk==DayOfWeek.Friday)
            {
                lbl_hari.Text = "Jumat";
            }
            else if (dwk==DayOfWeek.Saturday)
            {
                lbl_hari.Text = "Sabtu";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Hari();
            lbl_tanggal.Text = DateTime.Now.ToShortDateString();
            
            daftar.Hari = lbl_hari.Text;
            txt_daftar.Text = daftar.buatKodeDaftar();
            isiKartu();
            pasien.ambilnoKartubyNama(cmb_kartu.Text);
            isikodePoli();
            isikodeDokter();
            tampildata();
        }
        string ambilTanggal(DateTime tgl)
        {
            string stgl = "";
            stgl = tgl.Year.ToString() + "/" + tgl.Month.ToString() + "/" + tgl.Day.ToString();

            return stgl;
        }
        void bersihkan()
        {
            txt_daftar.Clear();
            cmb_dokter.Items.Clear();
            cmb_kartu.Items.Clear();
            cmb_poli.Items.Clear();
        }

        void isiKartu()
        {
            DataTable data = new DataTable();
            data = pasien.tampilSemua();

            if (data.Rows.Count > 0)
            {
                cmb_kartu.Items.Clear();
                foreach (DataRow dt in data.Rows)
                {
                    cmb_kartu.Items.Add(dt[3].ToString());
                }
            }
        }

        void isikodePoli()
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
        void isikodeDokter()
        {
            DataTable data = new DataTable();
            data = daftar.tampilIsiDokterByHari(cmb_poli.Text);
            if(data.Rows.Count == 0)
            {
                cmb_dokter.Items.Clear();
            }
            if (data.Rows.Count > 0)
            {
                cmb_dokter.Items.Clear();
                foreach (DataRow dt in data.Rows)
                {
                    cmb_dokter.Items.Add(dt[1].ToString());
                }
            }
        }
        void HapuskodeDokter()
        {
            DataTable data = new DataTable();
            data = daftar.tampilIsiDokterByHari(cmb_poli.Text);

            if (data.Rows.Count > 0)
            {
                for (int i = cmb_dokter.Items.Count - 1; i >= 0; i--)
                {
                    cmb_dokter.Items.RemoveAt(i);
                }
            }
        }

        void tampildata()
        {
            dgv_dokter.DataSource=daftar.tampilIsiDokterByHari();
            pendaftaran_dgv.DataSource = daftar.tampilSemua();
            belangBelang(pendaftaran_dgv);
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
        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (!daftar.apakahAda(txt_daftar.Text))
            {
                daftar.KD_Daftar = txt_daftar.Text;
                daftar.Nokartu_berobat = pasien.ambilnoKartubyNama(cmb_kartu.Text);
                daftar.KD_POLI = poli.ambilKodePolibyNama(cmb_poli.Text);
                daftar.Kd_Dokter = dokter.ambilKodeDokterbyNama(cmb_dokter.Text);
                daftar.Tanggal_daftar=ambilTanggal(DateTime.Parse(lbl_tanggal.Text));
                daftar.simpanData();

                MessageBox.Show("Tambah data berhasil disimpan. ", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bersihkan();
                isiKartu();
                isikodeDokter();
                isikodePoli();
                tampildata();
                txt_daftar.Text = daftar.buatKodeDaftar();
            }
        }

        private void ubah_btn_Click(object sender, EventArgs e)
        {
            if (daftar.apakahAda(txt_daftar.Text))
            {
                if (MessageBox.Show("Yakin akan diubah?", "Ubah Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    daftar.KD_Daftar = txt_daftar.Text;
                    daftar.Nokartu_berobat = pasien.ambilnoKartubyNama(cmb_kartu.Text);
                    daftar.KD_POLI = poli.ambilKodePolibyNama(cmb_poli.Text);
                    daftar.Kd_Dokter = dokter.ambilKodeDokterbyNama(cmb_dokter.Text);
                    daftar.ubah(txt_daftar.Text);

                    MessageBox.Show("Data berhasil diubah. ", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihkan();
                    isiKartu();
                    isikodeDokter();
                    isikodePoli();
                    txt_daftar.Text = daftar.buatKodeDaftar();
                    tampildata();
                }
            }
        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            if (daftar.apakahAda(txt_daftar.Text))
            {
                if (MessageBox.Show("Yakin akan dihapus?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    daftar.KD_Daftar = txt_daftar.Text;
                    daftar.Nokartu_berobat = pasien.ambilnoKartubyNama(cmb_kartu.Text);
                    daftar.KD_POLI = poli.ambilKodePolibyNama(cmb_poli.Text);
                    daftar.Kd_Dokter = dokter.ambilKodeDokterbyNama(cmb_dokter.Text);
                    daftar.hapus(txt_daftar.Text);

                    MessageBox.Show("Data berhasil dihapus. ", "Hapus Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihkan();
                    isiKartu();
                    isikodeDokter();
                    isikodePoli();
                    txt_daftar.Text = daftar.buatKodeDaftar();
                    tampildata();
                }
            }
        }

        private void tutup_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah yakin anda akan keluar dari Form Pendaftaran?",
                   "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                   == DialogResult.Yes)
            {
                Close();
            }
        }

        private void pendaftaran_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = this.pendaftaran_dgv.Rows[e.RowIndex];

            txt_daftar.Text = baris.Cells[0].Value.ToString();
            cmb_kartu.Text = baris.Cells[1].Value.ToString();
            cmb_poli.Text = baris.Cells[2].Value.ToString();
            cmb_dokter.Text = baris.Cells[3].Value.ToString();
          
        }

        private void cetak_btn_Click(object sender, EventArgs e)
        {
            if (cmb_kartu.Text=="" && cmb_poli.Text=="" && cmb_dokter.Text == "")
            {
                MessageBox.Show("Data Tidak ditemukan.");
            }
            else
            {
                report.LaporanPendaftaranPasienFrm laporan = new report.LaporanPendaftaranPasienFrm(txt_daftar.Text);
                laporan.ShowDialog();
            }
        }

        private void batal_btn_Click(object sender, EventArgs e)
        {
            bersihkan();
            isiKartu();
            isikodePoli();
            isikodeDokter();
            txt_daftar.Text = daftar.buatKodeDaftar();
        }

        private void dgv_dokter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = this.dgv_dokter.Rows[e.RowIndex];
            cmb_dokter.Text = baris.Cells[0].Value.ToString();
            cmb_dokter.Text = baris.Cells[1].Value.ToString();
            cmb_poli.Text = baris.Cells[2].Value.ToString();
        }

        private void cmb_poli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_poli.Items.Count>0)
            {
                HapuskodeDokter();
                isikodeDokter();
            }
        }
    }
}
