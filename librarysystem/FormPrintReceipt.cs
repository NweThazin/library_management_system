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
    public partial class FormPrintReceipt : Form
    {
        string memberID;DateTime issDate;
        public FormPrintReceipt()
        {
            InitializeComponent();
        }

        public FormPrintReceipt(string name, DateTime issdate)
        {
            InitializeComponent();
            memberID = name;
            issDate = issdate;
        }
        private void FormPrintReceipt_Load(object sender, EventArgs e)
        {
            PrintReceiptDS prd = new PrintReceiptDS();
            PrintReceiptDSTableAdapters.DataTable1TableAdapter ad = new PrintReceiptDSTableAdapters.DataTable1TableAdapter();
            ad.Fill(prd.DataTable1, memberID, issDate.ToString());

            PrintReceiptCrystalReport prc = new PrintReceiptCrystalReport();
            prc.SetDataSource(prd);
            this.crystalReportViewer1.ReportSource = prc;
            this.crystalReportViewer1.RefreshReport();
        }
    }
}
