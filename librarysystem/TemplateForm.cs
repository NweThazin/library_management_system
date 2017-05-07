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
    public partial class TemplateForm : Form
    {
        protected Form mCaller = null;
        public string UserID;

        public TemplateForm()
        {
            InitializeComponent();
        }

        private void AddBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMaintenanceBook fs = new FormMaintenanceBook("0");
            fs.ShowDialog();
        }

        private void modifyBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMaintenanceBook fs = new FormMaintenanceBook("1");
            fs.ShowDialog();
        }

        private void addNewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMaintenanceMember fs = new FormMaintenanceMember(1);
            fs.ShowDialog(this);
        }
        private void modifyMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMaintenanceMember fs = new FormMaintenanceMember(2);
            fs.ShowDialog(this);
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIssueBook fs = new FormIssueBook(UserID);
            fs.ShowDialog(this);
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReturnBook fs = new FormReturnBook();
            fs.ShowDialog(this);
        }
        
        private void bookListReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBookListReport f = new FormBookListReport();
            f.Show();
        }

        private void bookCategoryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChartReport ct = new FormChartReport();
            ct.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void searchBookToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormBookSearch fs = new FormBookSearch();
            fs.ShowDialog(this);
        }

        private void managementReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManagementReport fm = new FormManagementReport();
            fm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("You really want to log out?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            this.Close();
        }

        private void TemplateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("You really want to log out?", "eLibrary", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

    }
}
