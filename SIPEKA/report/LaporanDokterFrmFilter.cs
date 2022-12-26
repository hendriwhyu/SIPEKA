using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Windows.Forms;

namespace SIPEKA.report
{
    public partial class LaporanDokterFrmFilter : Form
    {
        ReportDocument repDok = new ReportDocument();
        string kode;
        public LaporanDokterFrmFilter(string kode)
        {
            InitializeComponent();
            this.kode = kode;
        }


        private void LaporanDokterFrmFilter_Load_1(object sender, EventArgs e)
        {
            repDok.Load(@"C:\Kuliah\SEMESTER 3\Pa Wahyu (Praktek_PBO 2)\SIPEKA\SIPEKA\report\LaporanDokterRptFilter.rpt");
            repDok.SetDatabaseLogon("root", "");
            repDok.Refresh();

            ParameterFieldDefinitions parFlds;
            ParameterFieldDefinition parFld;
            ParameterValues parVal = new ParameterValues();
            ParameterDiscreteValue parDis = new ParameterDiscreteValue();

            parDis.Value = kode.Trim();
            parFlds = repDok.DataDefinition.ParameterFields;
            parFld = parFlds["pkode"];
            parVal = parFld.CurrentValues;

            parVal.Clear();
            parVal.Add(parDis);
            parFld.ApplyCurrentValues(parVal);

            dokterFilter_crv.ReportSource = repDok;
            dokterFilter_crv.Refresh();
        }
    }
}
