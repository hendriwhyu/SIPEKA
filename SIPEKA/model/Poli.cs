using System;

namespace SIPEKA.model
{
    using config;
    using System.Data;
    internal class Poli
    {
        ServiceDb dbServer;
        DataTable temp;
        string Query = "";

        private string kode_poli;
        private string nama_poli;
        public Poli()
        {
            dbServer = new ServiceDb();
            temp = new DataTable();

            kode_poli = "";
            nama_poli = "";
        }

        public string Kode_Poli
        {
            set { kode_poli =value; }
        }

        public string Nama_Poli
        {
            set { nama_poli =value; }
        }

        public bool cekKode(string kode)
        {
            bool cek = false;
            Query = "select * from poli where kode_poli='" + kode + "'";

            temp = dbServer.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public string buatKode()
        {
            string kode = "";
            int indek = 0;

            Query = "select IFNULL (MAX(RIGHT(kode_poli,2)),0) + 1 AS kode FROM poli";

            temp = dbServer.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    indek = Convert.ToInt32(data[0]);
                }
                if (indek > 0 && indek < 10)
                {
                    kode = "P00" + indek.ToString();
                }
                else if (indek >= 10 && indek < 100)
                {
                    kode = indek.ToString();
                }
            }

            return kode;
        }

        public DataTable tampilkanSemua()
        {
            Query = "select kode_poli, nama_poli from poli";

            return dbServer.eksekusiQuery(Query);
        }

        public DataTable SearchSemua(string nama)
        {
            Query = "select * from poli where p.nama_poli like'%" + nama + "%'";

            return dbServer.eksekusiQuery(Query);
        }

        public void simpanData()
        {
            Query = "insert into poli values ('" + kode_poli + "','" + nama_poli + "')";

            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data Gagal Disimpan.");
            }
        }

        public void ubahData(string kode)
        {
            Query = "update poli set nama_poli='" + nama_poli + "' where kode_poli='" + kode + "'";

            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data Gagal Diubah.");
            }
        }

        public void hapusData(string kode)
        {
            Query = "delete from poli where kode_poli='" + kode + "'";

            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data Gagal Dihapus.");
            }
        }

        public string ambilKodePolibyNama(string nama)
        {
            string kd = "";

            Query = "select kode_poli from poli where nama_poli='" + nama + "'";
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
