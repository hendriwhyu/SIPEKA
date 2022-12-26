using SIPEKA.config;
using System;
using System.Data;

namespace SIPEKA.model
{
    internal class ResepCls
    {
        ServiceDb dbServer;
        DataTable temp;
        string Query;

        private string _kode_resep;
        private string _kode_dokter;
        private string _kode_pendaftaran;
        private string _kode_obat;
        private string _aturan_pakai;
        private int _jml_obat;
        public ResepCls()
        {
            dbServer = new ServiceDb();
            temp = new DataTable();
            _kode_resep="";
            _kode_dokter = "";
            _kode_pendaftaran = "";
            _kode_obat="";
            _aturan_pakai="";
            _jml_obat=0;

            dbServer = new ServiceDb();
            temp = new DataTable();
            Query = "";
        }
        public string Kode_Resep
        {
            set { _kode_resep = value; }
        }

        public string Kode_Dokter
        {
            set { _kode_dokter = value; }
        }

        public string Kode_Pendaftaran
        {
            set { _kode_pendaftaran = value; }
        }

        public string Kode_Obat
        {
            set { _kode_obat = value; }
        }
        public string Aturan_pakai
        {
            set { _aturan_pakai= value; }
        }
        public int Jml_obat
        {
            set { _jml_obat=value; }
        }
        public bool apakahAda(string kode)
        {
            bool cek = false;
            Query = "select * from resep where kode_resep='"+kode+"'";
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
            Query = "select ifnull(max(right(kode_resep,2)),0)+1 as kode from resep";
            temp = dbServer.eksekusiQuery(Query);
            if (temp.Rows.Count>0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    indek = Convert.ToInt32(data[0]);
                }
                if (indek>0 && indek<10)
                {
                    kode ="R00" + indek.ToString();
                }
                else if (indek>=10 && indek<100)
                {
                    kode = "R0"+indek.ToString();
                }
            }
            return kode;
        }

        public void SimpanDetailResep()
        {
            Query = "insert into detail_resep values('" + _kode_resep + "', '" + _kode_obat + "', '" + _aturan_pakai + "', '" + _jml_obat + "')";
            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Gagal Simpan");
            }
        }

        public void SimpanResep()
        {
            Query = "insert into resep values ('" + _kode_resep + "', '" + _kode_dokter + "', '" + _kode_pendaftaran +"')";
            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Gagal Simpan");
            }
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
        public string tampilNamaPasien(string kode)
        {
            string nama = "";
            Query = "select pen.kode_pendaftaran,p.nama from pasien p JOIN pendaftaran pen ON pen.no_kartu_berobat=p.no_kartu_berobat where pen.kode_pendaftaran='"+kode+"'";
            temp = dbServer.eksekusiQuery(Query);
            if (temp.Rows.Count>0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    nama = data[1].ToString();
                }
            }
            return nama;
        }

    }
}
