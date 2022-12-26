using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Windows.Forms;

namespace SIPEKA.report
{
    public partial class LaporanPendaftaranPasienFrm : Form
    {
        ReportDocument repDok = new ReportDocument();
        string kode;
        public LaporanPendaftaranPasienFrm(string kode)
        {
            InitializeComponent();
            this.kode = kode;
        }

        private void LaporanPendaftaranPasienFrm_Load(object sender, EventArgs e)
        {
            repDok.Load(@"C:\Kuliah\SEMESTER 3\Pa Wahyu (Praktek_PBO 2)\SIPEKA\SIPEKA\report\LaporanPendaftaranPasienCrp.rpt");
            repDok.SetDatabaseLogon("root", "");
            repDok.Refresh();

            ParameterFieldDefinitions parFlds;
            ParameterFieldDefinition parFld;
            ParameterValues parVal = new ParameterValues();
            ParameterDiscreteValue parDis = new ParameterDiscreteValue();

            parDis.Value = kode.Trim();
            parFlds = repDok.DataDefinition.ParameterFields;
            parFld = parFlds["p_kode"];
            parVal = parFld.CurrentValues;

            parVal.Clear();
            parVal.Add(parDis);
            parFld.ApplyCurrentValues(parVal);

            crv_pendaftaran.ReportSource = repDok;
            crv_pendaftaran.Refresh();
        }
    }
}
