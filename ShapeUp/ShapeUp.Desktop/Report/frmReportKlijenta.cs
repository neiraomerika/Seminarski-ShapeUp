using Microsoft.Reporting.WinForms;
using ShapeUp.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeUp.Desktop.Report
{
    public partial class frmReportKlijenta : Form
    {
        private APIService _klijentService = new APIService("Users");
        public MKlijent _klijent;
        public frmReportKlijenta(MKlijent klijent)
        {
            InitializeComponent();
            _klijent = klijent;
        }

        private void frmReportKlijenta_Load(object sender, EventArgs e)
        {
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("ImePrezime", $"{_klijent.FirstName} {_klijent.LastName}"));

            dsKlijent.PlanoviDataTable tabel = new dsKlijent.PlanoviDataTable();
            foreach (var item in _klijent.Plans)
            {
                dsKlijent.PlanoviRow red = tabel.NewPlanoviRow();
                red.Id = item.Id;
                red.Datum = item.Datum.ToString("dd.MM.yyyy");
                red.Trening = item.Trening.Opis;
                red.Obrok = item.PlanPrehrane.Opis;
                red.Mentorstvo = $"{item.Mentorstvo.NazivKlijenta} {item.Mentorstvo.DatumPocetka} | {item.Mentorstvo.DatumZavrsetka}";
                tabel.Rows.Add(red);
            }


            ReportDataSource rds = new ReportDataSource();
            rds.Name = "Planovi";
            rds.Value = tabel;

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
