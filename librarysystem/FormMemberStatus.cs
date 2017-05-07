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
    public partial class FormMemberStatus : Form
    {
        string UserID = "";
        LibrarySystemEntities context = new LibrarySystemEntities();

        public FormMemberStatus()
        {
            InitializeComponent();
        }
        public FormMemberStatus(string strUserID)
        {
            this.UserID = strUserID;
            InitializeComponent();
        }

        private void FormMemberStatus_Load(object sender, EventArgs e)
        {
            var qry = from x in context.IssueDetails where x.BookIssue.MemberID == UserID select x;
            dataGridView1.DataSource = qry.ToList();
        }
    }
}
