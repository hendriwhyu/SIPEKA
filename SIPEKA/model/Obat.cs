using System;
using System.Data;


namespace SIPEKA.model
{
    using config;
    internal class Obat
    {
        private string _kode_obat;
        private string _nama_obat;
        private string _exp_date;
        private string _jns_obat;
        private string _stok;

        private ServiceDb dbServer;
        private DataTable dtTabel;
        private string Query;
        public Obat()
        {
            _kode_obat = "";
            _nama_obat = "";
            _exp_date ="";
            _jns_obat = "";
            _stok = "";

            dbServer = new ServiceDb();
            dtTabel = new DataTable();
            Query = "";
        }
        public string Kode_Obat
        {
            set { _kode_obat = value; }
        }
        public string Nama_Obat
        {
            set { _nama_obat = value; }
        }
        public string Exp_Date
        {
            set { _exp_date = value; }
        }
        public string Jns_Obat
        {
            set { _jns_obat = value; }
        }
        public string Stok
        {
            set { _stok = value; }
        }

        public bool apakahAda(string kode)
        {
            bool cek = false;
            Query = "select * from obat where kode_obat='"+kode+"'";
            dtTabel = dbServer.eksekusiQuery(Query);
            if (dtTabel.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }
        public string buatKode()
        {
            string kode = "";
            int indek = 0;
            Query = "select ifnull(max(right(kode_obat,2)),0)+1 as kode from obat";
            dtTabel = dbServer.eksekusiQuery(Query);
            if (dtTabel.Rows.Count>0)
            {
                foreach (DataRow data in dtTabel.Rows)
                {
                    indek = Convert.ToInt32(data[0]);
                }
                if (indek>0 && indek<10)
                {
                    kode ="O00" + indek.ToString();
                }
                else if (indek>=10 && indek<100)
                {
                    kode = indek.ToString();
                }
            }
            return kode;
        }
        public void simpan()
        {
            Query = "insert into obat values('"+_kode_obat+"','"+_jns_obat+"','"+_nama_obat+"','"+_exp_date+"','"+_stok+"')";
            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data Gagal disimpan. ");
            }
        }
        public void ubah(string kode)
        {
            Query = "update obat set jenis_obat='"+_jns_obat+"',nama_obat='"+_nama_obat+"',ex_date='"+_exp_date+"'," +
                "stok='"+_stok+"'where kode_obat ='"+kode+"'";
            if (!(dbServer.eksekusiNonQuery(Query)>0))
            {
                throw new Exception("Proses ubah data gagal");
            }
        }
        public void hapus(string kode)
        {
            Query = "delete from obat where kode_obat ='"+kode+"'";
            if (!(dbServer.eksekusiNonQuery(Query)>0))
            {
                throw new Exception("Proses hapus data gagal");
            }
        }
        public DataTable tampilSemua()
        {
            Query = "select * from obat";

            return dbServer.eksekusiQuery(Query);
        }
        public DataTable tampilSemuaGrid()
        {
            Query = "select * from obat";

            return dbServer.eksekusiQuery(Query);
        }
        public DataTable cariNama(string nama)
        {
            Query = "select * from obat where nama_obat like'"+nama+"%'";

            return dbServer.eksekusiQuery(Query);
        }
        public string tampilNamaByKode(string kode)
        {
            string nama = "";
            Query = "select nama_obat from obat where kode_obat='"+kode+"'";
            dtTabel = dbServer.eksekusiQuery(Query);
            if (dtTabel.Rows.Count>0)
            {
                foreach (DataRow data in dtTabel.Rows)
                {
                    nama = data[0].ToString();
                }
            }
            return nama;
        }
    }
}
