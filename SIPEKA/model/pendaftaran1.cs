using System;
using System.Data;

namespace SIPEKA.model
{
    using config;
    using System.Windows.Forms;

    class pendaftaran1
    {
        ServiceDb dbServer;
        DataTable temp;
        string Query = "";

        private string _kode_pendaftaran;
        private string _no_kartu_berobat;
        private string _kode_poli;
        private string _kode_dokter;
        private string _hari;
        private string _tanggal_daftar;

        public pendaftaran1()
        {
            _kode_pendaftaran = "";
            _no_kartu_berobat = "";
            _kode_poli = "";
            _kode_dokter = "";
            _hari="";
            _tanggal_daftar="";

            dbServer = new ServiceDb();
            temp = new DataTable();
        }

        public string KD_Daftar
        {
            set { _kode_pendaftaran = value; }
        }
        public string Nokartu_berobat
        {
            set { _no_kartu_berobat = value; }
        }
        public string KD_POLI
        {
            set { _kode_poli = value; }
        }

        public string Kd_Dokter
        {
            set { _kode_dokter = value; }
        }
        public string Hari
        {
            set { _hari = value; }
        }
        public string Tanggal_daftar
        {
            set { _tanggal_daftar = value; }
        }
        public bool apakahAda(string kode)
        {
            bool cek = false;
            Query = "select * from pendaftaran where kode_pendaftaran='" + kode + "'";
            temp = dbServer.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }
        public void simpanData()
        {
            Query = "insert into pendaftaran values ('" + _kode_pendaftaran + "', '" + _no_kartu_berobat + "', '" + _kode_poli + "', '" + _kode_dokter + "','"+_tanggal_daftar+"')";
            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data Gagal disimpan. ");
            }
        }

        public void ubah(string kode)
        {
            Query = "update pendaftaran set no_kartu_berobat='" + _no_kartu_berobat + "', kode_poli='" + _kode_poli + "', kode_dokter ='" + _kode_dokter + "', where kode_pendaftaran='" +_kode_pendaftaran + "'";

            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Proses Ubah data Gagal. ");
            }
        }

        public void hapus(string kode)
        {
            Query = "delete from pendaftaran where kode_pendaftaran='" +kode+"'";
            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Proses Hapus Data Gagal. ");
            }
        }

        public DataTable tampilSemua()
        {
            Query = "SELECT pen.kode_pendaftaran, p.nama, pol.nama_poli, d.nama_dokter FROM pasien p " +
                "JOIN pendaftaran pen ON p.no_kartu_berobat=pen.no_kartu_berobat " +
                "JOIN poli pol ON pol.kode_poli=pen.kode_poli " +
                "JOIN dokter d ON pen.kode_dokter=d.kode_dokter";

            return dbServer.eksekusiQuery(Query);
        }
        public DataTable tampilBerelasi(string kode_dokter)
        {
            Query = "select p.kode_pendaftaran, pas.nama from pendaftaran p JOIN pasien pas ON p.no_kartu_berobat=pas.no_kartu_berobat " +
                "JOIN dokter d ON d.kode_dokter=p.kode_dokter where d.nama_dokter='"+kode_dokter+"'";

            return dbServer.eksekusiQuery(Query);
        }

        public string buatKodeDaftar()
        {
            string kode = "";
            int indeks = 0;
            Query = "SELECT IFNULL(MAX(RIGHT(kode_pendaftaran,2)),0)+1 AS kartu FROM pendaftaran";
            temp = dbServer.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    indeks = Convert.ToInt32(data[0]);
                }

                if (indeks > 0 && indeks < 10)
                {
                    kode = "E00" + indeks.ToString();
                }
                else if (indeks >= 10 && indeks < 100)
                {
                    kode = "E0" + indeks.ToString();
                }else if (indeks > 100 && indeks < 1000)
                {
                    kode = "E" + indeks.ToString();
                }
            }

            return kode;
        }
        public DataTable tampilIsiDokterByHari()
        {
            Query = "select d.kode_dokter,d.nama_dokter,p.nama_poli,d.jadwal from dokter d " +
                "JOIN poli p ON p.kode_poli=d.kode_poli where jadwal='"+_hari+"' ORDER BY d.kode_dokter";
            return dbServer.eksekusiQuery(Query);
        }
        public DataTable tampilIsiDokterByHari(string poli)
        {
            Query = "select d.kode_dokter,d.nama_dokter,d.jadwal from dokter d " +
                "JOIN poli p ON p.kode_poli=d.kode_poli where jadwal='"+_hari+"'&& p.nama_poli='"+poli+"'";
            return dbServer.eksekusiQuery(Query);
        }

    }
}
