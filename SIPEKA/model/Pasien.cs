using System;
using System.Data;

namespace SIPEKA.model
{
    using config;
    class Pasien
    {
        private KonfigDb dbServer;
        private DataTable dtTable;
        private string Query;

        private string _NoKartu;
        private string _NoIdentitas;
        private string _NoBpjs;
        private string _NamaPasien;
        private string _TanggalLahir;
        private string _JenisKelamin;
        private string _Umur;
        private string _Agama;
        private string _Telepon;
        private string _Alamat;

        public Pasien()
        {
            _NoKartu = "";
            _NoIdentitas = "";
            _NoBpjs = "";
            _NamaPasien = "";
            _TanggalLahir = "";
            _JenisKelamin = "";
            _Umur = "";
            _Agama = "";
            _Telepon = "";
            _Alamat = "";

            dbServer = new ServiceDb();
            dtTable = new DataTable();
            Query = "";
        }

        public string No_Kartu
        {
            set { _NoKartu = value; }
        }

        public string No_Identitas
        {
            set { _NoIdentitas = value; }
        }

        public string No_BPJS
        {
            set { _NoBpjs = value; }
        }

        public string Nama_Pasien
        {
            set { _NamaPasien = value; }
        }

        public string Tanggal_Lahir
        {
            set { _TanggalLahir = value; }
        }

        public string Jenis_Kelamin
        {
            set { _JenisKelamin = value; }
        }

        public string Umur
        {
            set { _Umur = value; }
        }

        public string Agama
        {
            set { _Agama = value; }
        }

        public string Telepon
        {
            set { _Telepon = value; }
        }

        public string Alamat
        {
            set { _Alamat = value; }
        }



        public bool apakahAda(string noKartu)
        {
            bool cek = false;
            Query = "select * from pasien where no_kartu_berobat='" + noKartu + "'";
            dtTable = dbServer.eksekusiQuery(Query);

            if (dtTable.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        public void simpan()
        {
            Query = "insert into pasien values('" + _NoKartu + "','" + _NoIdentitas + "','" + _NoBpjs + "','" + _NamaPasien + "','" + _TanggalLahir + "','" + _JenisKelamin + "','" + _Umur + "','" + _Agama + "','" + _Telepon + "','" + _Alamat + "')";

            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Proses tambah data gagal.");
            }
        }

        public void ubah()
        {
            Query = "update pasien set no_identitas='" + _NoIdentitas + "',no_bpjs='" + _NoBpjs + "',nama='" + _NamaPasien + "',ttl='" + _TanggalLahir + "',jk='" + _JenisKelamin + "',umur='" + _Umur + "',agama='" + _Agama + "',no_telepon='" + _Telepon + "',alamat='" + _Alamat + "' where no_kartu_berobat='" + _NoKartu + "'";
            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Proses ubah data gagal.");
            }
        }

        public void hapus()
        {
            Query = "delete from pasien where no_kartu_berobat ='" + _NoKartu + "'";

            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Proses hapus data gagal.");
            }
        }

        public DataTable tampilSemua()
        {
            Query = "select * from pasien";

            return dbServer.eksekusiQuery(Query);
        }


        public DataTable tampilkanSemua(string nama)
        {
            Query = "select * from pasien where " + "nama like '%" + nama + "%'";
            return dbServer.eksekusiQuery(Query);
        }

        public string buatKodeKartu()
        {
            string kode = "";
            int indeks = 0;
            Query = "SELECT IFNULL(MAX(RIGHT(no_kartu_berobat,2)),0)+1 AS kartu FROM pasien";
            dtTable = dbServer.eksekusiQuery(Query);
            if (dtTable.Rows.Count > 0)
            {
                foreach (DataRow data in dtTable.Rows)
                {
                    indeks = Convert.ToInt32(data[0]);
                }

                if (indeks > 0 && indeks < 10)
                {
                    kode = "A00" + indeks.ToString();
                }
                else if (indeks >= 10 && indeks < 100)
                {
                    kode = "A0" + indeks.ToString();
                }
            }

            return kode;
        }

        public string buatKodeIdentitas()
        {
            string kode = "";
            int indeks = 0;
            Query = "SELECT IFNULL(MAX(RIGHT(no_identitas,2)),0)+1 AS kartu FROM pasien";
            dtTable = dbServer.eksekusiQuery(Query);
            if (dtTable.Rows.Count > 0)
            {
                foreach (DataRow data in dtTable.Rows)
                {
                    indeks = Convert.ToInt32(data[0]);
                }

                if (indeks > 0 && indeks < 10)
                {
                    kode = "B00" + indeks.ToString();
                }
                else if (indeks >= 10 && indeks < 100)
                {
                    kode = "B0" + indeks.ToString();
                }
            }

            return kode;
        }

        public string ambilnoKartubyNama(string nama)
        {
            string kd = "";

            Query = "select no_kartu_berobat from pasien where nama='" + nama + "'";
            dtTable = dbServer.eksekusiQuery(Query);

            if (dtTable.Rows.Count > 0)
            {
                foreach (DataRow dt in dtTable.Rows)
                {
                    kd = dt[0].ToString();
                }
            }
            return kd;
        }

    }
}
