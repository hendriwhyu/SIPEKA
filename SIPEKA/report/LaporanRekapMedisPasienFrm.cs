using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Windows.Forms;

namespace SIPEKA.report
{
    public partial class LaporanRekapMedisPasienFrm : Form
    {
        ReportDocument repDok = new ReportDocument();
        string kode;
        public LaporanRekapMedisPasienFrm(string kode)
        {
            InitializeComponent();
            this.kode=kode;
        }

        private void LaporanRekapMedisPasienFrm_Load(object sender, EventArgs e)
        {
            repDok.Load(@"D:\VSCode\PBO\SIPEKA\SIPEKA\report\LaporanRekapMedisPasienCrp.rpt");
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

            rekapmedis_crv.ReportSource = repDok;
            rekapmedis_crv.Refresh();

        }

    }
}
