using System;
using System.Data;

namespace SIPEKA.model
{
    using config;
    class Pengguna
    {
        ServiceDb dbServer;
        DataTable dtTable;
        string Query = "";

        private string _username;
        private string _password;
        private string _nama_user;

        public Pengguna()
        {
            dbServer = new ServiceDb();
            dtTable = new DataTable();
            _username = "";
            _password = "";
            _nama_user = "";
        }

        public string Username
        {
            set { _username = value; }
        }

        public string Password
        {
            set { _password = value; }
        }

        public string Nama_User
        {
            set { _nama_user = value; }
        }

        //UNTUK CEK USERNAME
        public bool cekUser(string user)
        {
            bool cek = false;
            Query = "select * from user where username='" + user + "'";
            dtTable = dbServer.eksekusiQuery(Query);
            if (dtTable.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        //CEK USERNAME PASSWORD UNTUK LOGIN
        public bool cekMasuk(string user, string pass)
        {
            bool cek = false;
            Query = "select * from user where username='" + user + "' and password='" + pass + "'";
            dtTable = dbServer.eksekusiQuery(Query);
            if (dtTable.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        //UNTUK TAMBAH
        public void simpanPengguna()
        {
            Query = "insert into user values('" + _username + "','" + _password + "','" + _nama_user + "')";
            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data gagal disimpan.");
            }
        }

        //UBAH
        public void ubahPengguna(string user)
        {
            Query = "update user set password= '" + _password + "' ,nama_user= '" + _nama_user + "' where username= '" + user + "' ";
            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data gagal diupdate.");
            }
        }

        //HAPUS
        public void hapusPengguna(string user)
        {
            Query = "delete from user where username ='" + user + "'";

            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Proses hapus data gagal.");
            }
        }

        //MENMAPILKAN SEMUA ISI DATA TABEL
        public DataTable tampilkanSemua()
        {
            Query = "select * from user";

            return dbServer.eksekusiQuery(Query);
        }

        //UNTUK MECARI BERDASARKAN NAMA USER
        public DataTable tampilkanSemua(string nama)
        {
            Query = "select * from user where " + "nama_user like '%" + nama + "%'";
            return dbServer.eksekusiQuery(Query);
        }

    }
}
