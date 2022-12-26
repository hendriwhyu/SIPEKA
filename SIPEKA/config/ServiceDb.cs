using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace SIPEKA.config
{
    internal class ServiceDb : KonfigDb
    {
        MySqlConnection sqlCon;
        MySqlCommand sqlCom;
        MySqlDataAdapter sqlDta;

        //string lokasi = "server=192.168.0.13;port=3306;database=sirema;uid=wahyu;pwd=rahadi";
        string lokasi = "server=localhost;port=3306;database=db_sipeka;uid=root;pwd=";
        public ServiceDb()
        {
            sqlCon = new MySqlConnection(lokasi);
            sqlCom = new MySqlCommand(lokasi);
            sqlDta = new MySqlDataAdapter();
        }

        private void bukaKoneksi()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                try
                {
                    sqlCon.Open();
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void tutupKoneksi()
        {
            sqlCon.Close();
        }
        public override int eksekusiNonQuery(string query)
        {
            int nilaiKembali = -1;
            try
            {
                bukaKoneksi();
                sqlCom.Connection = sqlCon;
                sqlCom.CommandText = query;
                nilaiKembali = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally
            {
                tutupKoneksi();
            }
            return nilaiKembali;
        }

        public override DataTable eksekusiQuery(string query)
        {
            DataTable nilaiKembali = new DataTable();
            try
            {
                bukaKoneksi();
                sqlCom.Connection = sqlCon;
                sqlCom.CommandText = query;
                sqlDta.SelectCommand = sqlCom;
                sqlDta.Fill(nilaiKembali);
            }
            catch (Exception ex) { }
            finally
            {
                tutupKoneksi();
            }
            return nilaiKembali;
        }
    }
}
