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
    public partial class FormBookListReport : Form
    {
        public FormBookListReport()
        {
            InitializeComponent();
        }

        private void FormBookListReport_Load(object sender, EventArgs e)
        {
            BookListDataSet bk = new BookListDataSet();
            BookListDataSetTableAdapters.BookTableAdapter bt = new BookListDataSetTableAdapters.BookTableAdapter();
            bt.Fill(bk.Book);

            BookListReport prc = new BookListReport();
            prc.SetDataSource(bk);
            this.crystalReportViewer1.ReportSource = prc;
            this.crystalReportViewer1.RefreshReport();
        }
    }
}
