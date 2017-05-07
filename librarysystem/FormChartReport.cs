using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA43Team4B
{
    public partial class FormChartReport : Form
    {
        public FormChartReport()
        {
            InitializeComponent();
        }

        private void FormChartReport_Load(object sender, EventArgs e)
        {
            ChartCrystalReport crt = new ChartCrystalReport();
            ChartCrystalReportTableAdapters.BookTableAdapter bk = new ChartCrystalReportTableAdapters.BookTableAdapter();
            bk.Fill(crt.Book);

            ChartReport ct = new ChartReport();
            ct.SetDataSource(crt);
            this.crystalReportViewer1.ReportSource = ct;
            this.crystalReportViewer1.RefreshReport();
        }
    }
}
