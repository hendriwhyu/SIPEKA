using SIPEKA.config;
using System.Data;

namespace SIPEKA.model
{
    internal class searchPasien
    {
        private ServiceDb dbServer;
        private DataTable dtTabel;
        private string Query;
        public searchPasien()
        {
            dbServer= new ServiceDb();
            dtTabel= new DataTable();
            Query="";
        }
        public DataTable tampildataPasien()
        {
            Query = "select * from searchpasien";
            return dbServer.eksekusiQuery(Query);
        }
        public DataTable cariKolom(string cari)
        {
            Query = "select * from searchpasien where nama like'"+cari+"%'";

            return dbServer.eksekusiQuery(Query);
        }
    }
}
