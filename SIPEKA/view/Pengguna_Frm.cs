using System;
using System.Drawing;
using System.Windows.Forms;

namespace SIPEKA.view
{
    public partial class Pengguna_Frm : Form
    {
        model.Pengguna pengguna = new model.Pengguna();
        public Pengguna_Frm()
        {
            InitializeComponent();
        }

        //BERSIHKAN
        void bersihkan()
        {
            txt_username.Text = "";
            txt_password.Text = "";
            txt_namaPengguna.Text = "";
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            if (!pengguna.cekUser(txt_username.Text))
            {
                pengguna.Username = txt_username.Text;
                pengguna.Password = txt_password.Text;
                pengguna.Nama_User = txt_namaPengguna.Text;
                pengguna.simpanPengguna();
                MessageBox.Show("Data Berhasil disimpan.");
                tampilGrid();
            }
            else
            {
                MessageBox.Show("Data Tidak Berhasil Disimpan");
            }
            bersihkan();
            txt_username.Focus();
        }

        private void btn_ubah_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah yakin anda akan mengubah data?", "KONFIRMASI",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (pengguna.cekUser(txt_username.Text))
                {
                    //jurusan.Kode_Jurusan = textBox1.Text;
                    pengguna.Password = txt_password.Text;
                    pengguna.Nama_User = txt_namaPengguna.Text;
                    pengguna.ubahPengguna(txt_username.Text);
                    MessageBox.Show("Data Berhasil diupdate.");
                    tampilGrid();
                    bersihkan();
                }
                else
                {
                    MessageBox.Show("Data Tidak Berhasil Diupdate");
                }
            }
            txt_username.Focus();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah yakin anda akan menghapus data?", "KONFIRMASI",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (pengguna.cekUser(txt_username.Text))
                {
                    //jurusan.Kode_Jurusan = textBox1.Text;
                    //jurusan.Nama_Jurusan = textBox2.Text;
                    pengguna.hapusPengguna(txt_username.Text);
                    MessageBox.Show("Data Berhasil dihapus.");
                    tampilGrid();
                }
                else
                {
                    MessageBox.Show("Data Tidak Berhasil Dihapus");
                }
            }
            txt_username.Focus();
            bersihkan();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            txt_username.Focus();
            bersihkan();
        }

        //VOID TAMPIL GRID
        void tampilGrid()
        {
            dgv_Pengguna.DataSource = pengguna.tampilkanSemua();
            if (txt_cariPengguna.Text.Trim() == "")
            {
                dgv_Pengguna.DataSource = pengguna.tampilkanSemua();
            }
            else
            {
                dgv_Pengguna.DataSource = pengguna.tampilkanSemua(txt_cariPengguna.Text);
            }
            belangBelang(dgv_Pengguna);
        }

        //WARNA TABEL BELANG
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

        private void dgv_Pengguna_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            belangBelang(dgv_Pengguna);
        }

        private void dgv_Pengguna_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow baris = this.dgv_Pengguna.Rows[e.RowIndex];
                txt_username.Text = baris.Cells["cUser"].Value.ToString();
                txt_password.Text = baris.Cells[1].Value.ToString();
                txt_namaPengguna.Text = baris.Cells[2].Value.ToString();
            }
        }

        private void txt_cariPengguna_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

        private void Pengguna_Frm_Load_1(object sender, EventArgs e)
        {
            tampilGrid();
            txt_username.Focus();
        }

        private void txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//13 adalah kode untuk enter
            {
                txt_password.Focus();
            }
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//13 adalah kode untuk enter
            {
                txt_namaPengguna.Focus();
            }
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah yakin anda akan keluar dari Form Pengguna?",
                    "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
