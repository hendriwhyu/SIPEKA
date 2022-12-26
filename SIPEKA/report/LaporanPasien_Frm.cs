using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Windows.Forms;

namespace SIPEKA.report
{
    public partial class LaporanPasien_Frm : Form
    {
        ReportDocument repDok = new ReportDocument();
        public LaporanPasien_Frm()
        {
            InitializeComponent();
        }

        private void LaporanPasien_Frm_Load(object sender, EventArgs e)
        {
            repDok.Load(@"C:\Kuliah\SEMESTER 3\Pa Wahyu (Praktek_PBO 2)\SIPEKA\SIPEKA\report\LaporanPasien_Crp.rpt");
            repDok.SetDatabaseLogon("root", "");
            repDok.Refresh();

            pasien_crv.ReportSource = repDok;
            pasien_crv.Refresh();
        }


    }
}
