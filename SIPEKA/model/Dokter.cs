using System;

namespace SIPEKA.model
{
    using config;
    using System.Data;
    internal class Dokter
    {
        ServiceDb dbServer;
        DataTable temp;
        string Query = "";

        private string kode_dokter;
        private string nama_dokter;
        private string poli;
        private string no_telepon;
        private string jadwal;

        public Dokter()
        {
            dbServer = new ServiceDb();
            temp = new DataTable();

            kode_dokter = "";
            nama_dokter = "";
            poli = "";
            no_telepon = "";
            jadwal = "";
        }

        public string Kode_Dokter
        {
            set { kode_dokter = value; }
        }

        public string Nama_Dokter
        {
            set { nama_dokter = value; }
        }

        public string Poli
        {
            set { poli = value; }
        }

        public string No_Telepon
        {
            set { no_telepon = value; }
        }

        public string Jadwal
        {
            set { jadwal = value; }
        }


        public bool cekKode(string kode)
        {
            bool cek = false;
            Query = "select * from dokter where kode_dokter='" + kode + "'";

            temp = dbServer.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public void simpanData()
        {
            Query = "insert into dokter values ('" + kode_dokter + "', '" + nama_dokter + "', '" + poli + "', '" + no_telepon + "', '" + jadwal + "')";

            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data Gagal Disimpan.");
            }
        }

        public void ubahData(string kode)
        {
            Query = "update dokter set nama_dokter='" + nama_dokter + "', kode_poli='" + poli + "', no_telepon='" + no_telepon + "', jadwal='" + jadwal + "' where kode_dokter='" + kode + "'";

            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data Gagal Diubah.");
            }
        }

        public void hapusData(string kode)
        {
            Query = "delete from dokter where kode_dokter='" + kode + "'";

            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data Gagal Dihapus.");
            }
        }

        public DataTable tampilkanSemua()
        {
            Query = "select d.kode_dokter, d.nama_dokter, p.nama_poli, d.no_telepon,d.jadwal from dokter d " +
                "JOIN poli p ON d.kode_poli=p.kode_poli";

            return dbServer.eksekusiQuery(Query);
        }

        public DataTable tampilkanSemua(string nama)
        {
            Query = "select d.kode_dokter, d.nama_dokter, p.nama_poli, d.no_telepon,d.jadwal from dokter d " +
                "JOIN poli p where d.nama_dokter like '%" + nama + "%'";

            return dbServer.eksekusiQuery(Query);
        }

        public string buatKode()
        {
            string kode = "";
            int indek = 0;

            Query = "select IFNULL (MAX(RIGHT(kode_dokter,2)),0) + 1 AS kode FROM dokter";

            temp = dbServer.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    indek = Convert.ToInt32(data[0]);
                }
                if (indek > 0 && indek < 10)
                {
                    kode = "D00" + indek.ToString();
                }
                else if (indek >= 10 && indek < 100)
                {
                    kode = indek.ToString();
                }
            }

            return kode;
        }

        public string ambilKodeDokterbyNama(string nama)
        {
            string kd = "";

            Query = "select kode_dokter from dokter where nama_dokter='" + nama + "'";
            temp = dbServer.eksekusiQuery(Query);

            if (temp.Rows.Count > 0)
            {
                foreach (DataRow dt in temp.Rows)
                {
                    kd = dt[0].ToString();
                }
            }
            return kd;
        }

    }
}
