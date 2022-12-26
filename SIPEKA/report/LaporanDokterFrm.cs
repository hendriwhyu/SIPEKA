using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Windows.Forms;

namespace SIPEKA.report
{
    public partial class LaporanDokterFrm : Form
    {
        ReportDocument repDok = new ReportDocument();

        public LaporanDokterFrm()
        {
            InitializeComponent();
        }

        private void LaporanDokterFrm_Load(object sender, EventArgs e)
        {
            repDok.Load(@"C:\Kuliah\SEMESTER 3\Pa Wahyu (Praktek_PBO 2)\SIPEKA\SIPEKA\report\LaporanDokterRpt.rpt");
            repDok.SetDatabaseLogon("root", "");
            repDok.Refresh();

            dokter_crv.ReportSource = repDok;
            dokter_crv.Refresh();
        }
    }
}
