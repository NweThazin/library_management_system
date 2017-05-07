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
    public partial class FormBookLoaned : Form
    {
        LibrarySystemEntities query = new LibrarySystemEntities();
        string bk;
              

        public FormBookLoaned(string bk)
        {
            InitializeComponent();
            this.bk = bk;
        }

        private void FormBookLoaned_Load(object sender, EventArgs e)
        {

            //List<IssueDetail> isuDet = query.IssueDetails.Where(x => x.BookISBN == bk).ToList();           
            //dataGridViewBkLoan.DataSource = isuDet;
            //dataGridViewBkLoan.DataSource = query.IssueDetails.Where(x => x.BookISBN == bk).ToList();
            try
            {
                dataGridViewBkLoan.DataSource = query.IssueDetails.Where(x => x.BookISBN == bk).
                    Select(y => new { y.IssueID, y.BookISBN, y.IssueDate, y.DueDate, y.Remark }).ToList();
            }
            catch (Exception except)
            {
                MessageBox.Show(except.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
