using System;
using System.Data;
using System.Windows.Forms;

namespace SIPEKA.view
{
    using model;
    public partial class ResepFrm : Form
    {
        ResepCls resep = new ResepCls();
        Obat obat = new Obat();
        Dokter dokter = new Dokter();
        pendaftaran1 daftar = new pendaftaran1();
        int baris = -1;
        public ResepFrm()
        {
            InitializeComponent();
        }
        void bersihkanObat()
        {
            txt_aturanpakai.Clear();
            cmb_kodeobat.Items.Clear();
            txt_namaobat.Clear();
            txt_jmlobat.Clear();
        }

        void bersihkanResep()
        {
            txt_kodersp.Clear();
            cmb_dokter.Items.Clear();
            cmb_daftar.Items.Clear();
            txt_namapasien.Clear();
        }
        void insertRow()
        {
            dgv_resep.Rows.Add();
            baris++;
            dgv_resep.Rows[baris].Cells[0].Value = cmb_kodeobat.Text;
            dgv_resep.Rows[baris].Cells[1].Value = txt_namaobat.Text;
            dgv_resep.Rows[baris].Cells[2].Value = txt_aturanpakai.Text;
            dgv_resep.Rows[baris].Cells[3].Value = txt_jmlobat.Text;

        }
        void DeleteRow()
        {
            if (dgv_resep.Rows.Count > 0)
            {
                for (int i = dgv_resep.Rows.Count - 1; i >= 0; i--)
                {
                    dgv_resep.Rows.RemoveAt(i);
                }
                baris=-1;
            }
        }

        void isiKodeObat()
        {
            DataTable data = new DataTable();
            data = obat.tampilSemua();
            if (data.Rows.Count>0)
            {
                cmb_kodeobat.Items.Clear();
                foreach (DataRow dt in data.Rows)
                {
                    cmb_kodeobat.Items.Add(dt[0].ToString());
                }
            }
        }
        void isiKodeDokter()
        {
            DataTable data = new DataTable();
            data = dokter.tampilkanSemua();
            if (data.Rows.Count>0)
            {
                cmb_dokter.Items.Clear();
                foreach (DataRow dt in data.Rows)
                {
                    cmb_dokter.Items.Add(dt[1].ToString());
                }
            }
        }
        void isiKodePendaftaran()
        {
            DataTable data = new DataTable();
            data = daftar.tampilBerelasi(cmb_dokter.Text);
            if (data.Rows.Count==0)
            {
                cmb_daftar.Items.Clear();
            }
            if (data.Rows.Count>0)
            {
                foreach (DataRow dt in data.Rows)
                {
                    cmb_daftar.Items.Add(dt[0].ToString());
                }
            }
        }
        void HapusKodePendaftaran()
        {
            DataTable data = new DataTable();
            data = daftar.tampilBerelasi(cmb_dokter.Text);
            if (data.Rows.Count>0)
            {
                for (int i = cmb_daftar.Items.Count - 1; i >= 0; i--)
                {
                    cmb_daftar.Items.RemoveAt(i);
                    txt_namapasien.Clear();
                }
            }
        }


        private void simpan_btn_Click(object sender, EventArgs e)
        {
            if (cmb_dokter.SelectedItem==null && cmb_daftar.SelectedItem==null)
            {
                MessageBox.Show("Data tidak boleh kosong.", "Informasi");
            }
            else if (cmb_dokter.SelectedItem==null)
            {
                MessageBox.Show("Anda harus menginputkan nama dokter terlebih dahulu.", "Informasi");
            }
            else if (cmb_daftar.SelectedItem==null)
            {
                MessageBox.Show("Data kode pendaftaran tidak boleh kosong.", "Informasi");
            }
            else
            {
                if (!resep.apakahAda(txt_kodersp.Text))
                {
                    resep.Kode_Resep = txt_kodersp.Text;
                    resep.Kode_Dokter = resep.ambilKodeDokterbyNama(cmb_dokter.Text);
                    resep.Kode_Pendaftaran = cmb_daftar.Text;
                    resep.SimpanResep();

                    if (dgv_resep.Rows.Count > -1)
                    {
                        for (int i = 0; i <= dgv_resep.Rows.Count -1; i++)
                        {
                            resep.Kode_Resep = txt_kodersp.Text;
                            resep.Kode_Obat = dgv_resep.Rows[i].Cells[0].Value.ToString();
                            resep.Aturan_pakai = dgv_resep.Rows[i].Cells[2].Value.ToString();
                            resep.Jml_obat = Convert.ToInt32(dgv_resep.Rows[i].Cells[3].Value.ToString());
                            resep.SimpanDetailResep();
                        }
                        DeleteRow();
                    }
                    MessageBox.Show("Tambah data berhasil.", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                bersihkanObat();
                bersihkanResep();
                txt_kodersp.Text = resep.buatKode();
                isiKodeObat();
                isiKodeDokter();
            }
        }


        private void ResepFrm_Load(object sender, EventArgs e)
        {
            txt_kodersp.Text = resep.buatKode();
            isiKodeObat();
            isiKodeDokter();
        }



        private void btn_keluar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah yakin anda akan keluar dari Form Resep?",
                    "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
            {
                Close();
            }
        }


        private void cmb_kodeobat_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_namaobat.Text = obat.tampilNamaByKode(cmb_kodeobat.Text);
            if (!(cmb_kodeobat.SelectedItem==null))
            {
                txt_aturanpakai.Focus();
            }
        }



        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cmb_kodeobat.SelectedItem==null && txt_aturanpakai.Text=="" && txt_jmlobat.Text=="")
            {
                MessageBox.Show("Data tidak boleh kosong.", "Informasi");
            }
            else if (cmb_kodeobat.SelectedItem==null)
            {
                MessageBox.Show("Anda harus isi data obat terlebih dahulu.", "Informasi");
            }
            else if (txt_aturanpakai.Text=="")
            {
                MessageBox.Show("Anda harus menginputkan aturan pakai.", "Informasi");
            }
            else if (txt_jmlobat.Text=="")
            {
                MessageBox.Show("Anda harus menginputkan jumlah obat.", "Informasi");
            }
            else
            {
                insertRow();
                bersihkanObat();
                isiKodeObat();
            }

        }

        private void batal_btn_Click(object sender, EventArgs e)
        {
            bersihkanResep();
            txt_kodersp.Text = resep.buatKode();
            isiKodeDokter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteRow();
            bersihkanObat();
            isiKodeObat();
        }

        private void dgv_resep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = this.dgv_resep.Rows[e.RowIndex];
            cmb_kodeobat.Text = baris.Cells[0].Value.ToString();
            txt_namaobat.Text = baris.Cells[1].Value.ToString();
            txt_aturanpakai.Text = baris.Cells[2].Value.ToString();
            txt_jmlobat.Text = baris.Cells[3].Value.ToString();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            bersihkanObat();
            isiKodeObat();
        }

        private void txt_jmlobat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false          // -- jika bukan digit
                && (int)e.KeyChar != (int)Keys.Back)     // -- dan bukan backspace
            {
                e.Handled = true;                         // -- membatalkan event keypress         
            }
        }

        private void txt_aturanpakai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//13 adalah kode untuk enter
            {
                txt_jmlobat.Focus();
            }
        }

        private void cmb_daftar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_namapasien.Text = resep.tampilNamaPasien(cmb_daftar.Text);
        }

        private void cmb_dokter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_dokter.Items.Count==0)
            {
                isiKodePendaftaran();
            }
            else if (cmb_dokter.Items.Count>0)
            {
                HapusKodePendaftaran();
                isiKodePendaftaran();
            }

        }

        private void ResepFrm_Activated(object sender, EventArgs e)
        {
            cmb_dokter.Focus();
        }
    }
}
