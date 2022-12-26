using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIPEKA.view
{
    using model;
 
    public partial class Pasien_Frm : Form
    {
        Pasien pasien = new Pasien();
        public Pasien_Frm()
        {
            InitializeComponent();
        }

        void bersihkan()
        {
            txt_NoKartu.Text = "";
            txt_NoIdentitas.Text = "";
            txt_NoBPJS.Text="";
            txt_NamaPasien.Text = "";
            date_Lahir.Value = DateTime.Now;
            rdbtn_Laki.Checked = false;
            rdbtn_perempuan.Checked = false;
            txt_umur.Text ="";
            cmb_Agama.Items.Clear();
            txt_telp.Text = "";
            txt_alamat.Text = "";
            txt_NoKartu.Text = pasien.buatKodeKartu();
            txt_NoIdentitas.Text = pasien.buatKodeIdentitas();
        }

        void isiAgama()
        {
            cmb_Agama.Items.Add("Islam");
            cmb_Agama.Items.Add("Kriten");
            cmb_Agama.Items.Add("Katolik");
            cmb_Agama.Items.Add("Hindu");
            cmb_Agama.Items.Add("Budha");
            cmb_Agama.Items.Add("Protestan");
            cmb_Agama.Items.Add("Konghucu");
        }

        void tampilData()
        {
            dgv_Pasien.DataSource = pasien.tampilSemua();

            if (txt_cariPasien.Text.Trim() == "")
            {
                dgv_Pasien.DataSource = pasien.tampilSemua();
            }
            else
            {
                dgv_Pasien.DataSource = pasien.tampilkanSemua(txt_cariPasien.Text);
            }
            belangBelang(dgv_Pasien);
        }

        void belangBelang(DataGridView dgv)
        {
            foreach (DataGridViewRow baris in dgv.Rows)
            {
                foreach (DataGridViewCell kolom in baris.Cells)
                {
                    if (baris.Index % 2 == 0)
                    {
                        kolom.Style.BackColor = Color.LightSkyBlue;

                    }
                    else
                    {
                        kolom.Style.BackColor = Color.LightBlue;
                    }
                }
            }
        }

        string ambilTanggal(DateTime tgl)
        {
            string stgl = "";
            stgl = tgl.Year.ToString() + "/" + tgl.Month.ToString() + "/" + tgl.Day.ToString();

            return stgl;
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            if (!pasien.apakahAda(txt_NoKartu.Text))
            {
                pasien.No_Kartu = txt_NoKartu.Text;
                pasien.No_Identitas = txt_NoIdentitas.Text;
                pasien.No_BPJS = txt_NoBPJS.Text;
                pasien.Nama_Pasien = txt_NamaPasien.Text;
                pasien.Tanggal_Lahir = ambilTanggal(date_Lahir.Value);
                if (rdbtn_Laki.Checked==true)
                {
                    pasien.Jenis_Kelamin = "Laki-Laki";
                }
                else if (rdbtn_perempuan.Checked==true)
                {
                    pasien.Jenis_Kelamin = "Perempuan";
                }
                pasien.Umur=txt_umur.Text;
                pasien.Agama = cmb_Agama.Text;
                pasien.Telepon = txt_telp.Text;
                pasien.Alamat = txt_alamat.Text;
                pasien.simpan();

                MessageBox.Show("Tambah data berhasil.", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tampilData();
            }
            else
            {
                MessageBox.Show("Data Tidak Berhasil Disimpan");
            }
            bersihkan();
            isiAgama();
            txt_NoBPJS.Focus();
        }

        private void Pasien_Frm_Load(object sender, EventArgs e)
        {
            isiAgama();
            tampilData();
            txt_NoBPJS.Focus();
            txt_NoKartu.Text = pasien.buatKodeKartu();
            txt_NoIdentitas.Text = pasien.buatKodeIdentitas();
        }

        private void btn_ubah_Click(object sender, EventArgs e)
        {
            if (pasien.apakahAda(txt_NoKartu.Text))
            {
                pasien.No_Kartu = txt_NoKartu.Text;
                pasien.No_Identitas = txt_NoIdentitas.Text;
                pasien.No_BPJS = txt_NoBPJS.Text;
                pasien.Nama_Pasien = txt_NamaPasien.Text;
                pasien.Tanggal_Lahir = ambilTanggal(date_Lahir.Value);
                if (rdbtn_Laki.Checked == true)
                {
                    pasien.Jenis_Kelamin = "Laki-Laki";
                }
                else if (rdbtn_perempuan.Checked == true)
                {
                    pasien.Jenis_Kelamin = "Perempuan";
                }
                pasien.Umur = txt_umur.Text;
                pasien.Agama = cmb_Agama.Text;
                pasien.Telepon = txt_telp.Text;
                pasien.Alamat = txt_alamat.Text;
                pasien.ubah();

                MessageBox.Show("Ubah data berhasil.", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //bersihkan();
                tampilData();
            }
            else
            {
                MessageBox.Show("Data Tidak Berhasil Diubah");
            }
            bersihkan();
            isiAgama();
            txt_NoBPJS.Focus();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (pasien.apakahAda(txt_NoKartu.Text))
            {
                if (MessageBox.Show("Apakah yakin anda akan menghapus data", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    pasien.No_Kartu = txt_NoKartu.Text;
                    pasien.hapus();

                    MessageBox.Show("Hapus data berhasil.", "Hapus Data"
                       , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tampilData();
                }
            }
            else
            {
                MessageBox.Show("Data tidak berhasil dihapus");
            }
            bersihkan();
            isiAgama();
            txt_NoBPJS.Focus();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            bersihkan();
            isiAgama();
            txt_NoBPJS.Focus();
        }

        private void txt_cariPasien_TextChanged(object sender, EventArgs e)
        {
            tampilData();
        }

        //KLIK TERUS TAMPIL
        private void dgv_Pasien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = this.dgv_Pasien.Rows[e.RowIndex];
            txt_NoKartu.Text = baris.Cells[0].Value.ToString();
            txt_NoIdentitas.Text = baris.Cells[1].Value.ToString();
            txt_NoBPJS.Text = baris.Cells[2].Value.ToString();
            txt_NamaPasien.Text = baris.Cells[3].Value.ToString();
            date_Lahir.Text = baris.Cells[4].Value.ToString();
            if (baris.Cells[5].Value.ToString() == "Laki-Laki")
            {
                rdbtn_Laki.Checked = true;
            }
            else
            {
                rdbtn_perempuan.Checked = true;
            }
            txt_umur.Text = baris.Cells[6].Value.ToString();
            cmb_Agama.Text = baris.Cells[7].Value.ToString();
            txt_telp.Text = baris.Cells[8].Value.ToString();
            txt_alamat.Text = baris.Cells[9].Value.ToString();
        }

        private void dgv_Pasien_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            belangBelang(dgv_Pasien);
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah yakin anda akan keluar dari Form Pasien?",
                    "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
            {
                Close();
            } 
        }

        private void txt_NoBPJS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false          // -- jika bukan digit
                && (int)e.KeyChar != (int)Keys.Back)     // -- dan bukan backspace
            {
                e.Handled = true;                         // -- membatalkan event keypress         
            }
            if (e.KeyChar == 13)//13 adalah kode untuk enter
            {
                txt_NamaPasien.Focus();
            }
        }

        private void txt_NamaPasien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//13 adalah kode untuk enter
            {
                rdbtn_Laki.Focus();
            }
        }

        private void rdbtn_Laki_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//13 adalah kode untuk enter
            {
                txt_umur.Focus();
            }
        }

        private void rdbtn_perempuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//13 adalah kode untuk enter
            {
                txt_umur.Focus();
            }
        }

        private void txt_umur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false          // -- jika bukan digit
                && (int)e.KeyChar != (int)Keys.Back)     // -- dan bukan backspace
            {
                e.Handled = true;                         // -- membatalkan event keypress         
            }
            if (e.KeyChar == 13)//13 adalah kode untuk enter
            {
                txt_telp.Focus();

            }
        }

        private void txt_telp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false          // -- jika bukan digit
                && (int)e.KeyChar != (int)Keys.Back)     // -- dan bukan backspace
            {
                e.Handled = true;                         // -- membatalkan event keypress         
            }
            if (e.KeyChar == 13)//13 adalah kode untuk enter
            {
                txt_alamat.Focus();
            }
        }

        

        private void date_Lahir_ValueChanged(object sender, EventArgs e)
        {
            DateTime time_start = Convert.ToDateTime(date_Lahir.Value);
            DateTime time_end = DateTime.Today;
            var age = time_end.Year - time_start.Year;
            TimeSpan span = time_end.Subtract(time_start);
            var days_total = span.TotalDays;
            var yearsTotal = Math.Truncate(days_total / 365);


            txt_umur.Text = Convert.ToString(yearsTotal);
        }

    }
}
