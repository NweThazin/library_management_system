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
    public partial class FormManagementReport : Form
    {
        public FormManagementReport()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ManagementReportDS ds = new ManagementReportDS();
            ManagementReportDSTableAdapters.BooksBorrowTableAdapter adapter = new ManagementReportDSTableAdapters.BooksBorrowTableAdapter();
            adapter.Fill(ds.BooksBorrow);

            ManagementCrystalReport bksBorrow = new ManagementCrystalReport();
            bksBorrow.SetDataSource(ds);
            crystalReportViewer1.ReportSource = bksBorrow;
            crystalReportViewer1.RefreshReport();
        }
    }
}
