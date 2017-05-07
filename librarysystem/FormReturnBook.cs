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
    public partial class FormReturnBook : Form
    {
        //Declaring the entity object and variables
        LibrarySystemEntities context = new LibrarySystemEntities();
        private static string MemberID = "";
        List<object> lst = new List<object>();
        //List<IssueDetail> lst = new List<IssueDetail>();

        public FormReturnBook()
        {
            InitializeComponent();
        }

        private void BindGridViewIssueDetails()
        {
            lst.Clear();
            //Binding the data into the grid View after clicking Return
            MemberID = txtMemberID.Text;
            var issue = context.BookIssues.Where(x => x.MemberID == MemberID);
            foreach (BookIssue bs in issue)
            {
                var q = context.IssueDetails.Where(x => x.Availability == 0 && x.IssueID == bs.IssueID).Select(x => new { x.IssueID, x.BookISBN, x.IssueDate, x.DueDate, x.Remark });
                foreach (var ist in q)
                {
                    lst.Add(ist);
                }
            }
            dgvReturnList.DataSource = lst.ToList();
        }
       
        //private void txtMemberID_Leave(object sender, EventArgs e)
        //{
        //    //After filling the member id show the data in the gridview
        //    try
        //    {
        //        if (txtMemberID.Text == "")
        //        {
        //            MessageBox.Show("Please enter the member id to show in the lists of books in gridview");
        //        }
        //        else
        //        {
        //            BindGridViewIssueDetails();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("System Error");
        //    }
        //}

        //private void txtBookID_Leave(object sender, EventArgs e)      //After filling issue date and book number, will show the information according to the issue date and book number
        //{
        //    try
        //    {
        //        if (txtBookID.Text == "" && txtIssueID.Text == "")
        //        {
        //            MessageBox.Show("Please enter the book id and issue id");
        //        }
        //        else
        //        {
        //            string issid, booknum;
        //            issid = txtIssueID.Text; booknum = txtBookID.Text;
        //            var q = context.IssueDetails.Where(x => x.IssueID == issid && x.BookISBN == booknum).FirstOrDefault();
        //            IssueDetail id = (IssueDetail)q;
        //            var secondQuery = context.Books.Where(x => x.BookISBN == id.BookISBN).FirstOrDefault();
        //            Book b = (Book)secondQuery;
        //            txtBookTitle.Text = b.BookTitle;
        //            txtIssueDate.Text = id.IssueDate.ToLongDateString();
        //            txtDueDate.Text = id.DueDate.ToLongDateString();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Book ID is wrong.Please check your book number");
        //    }
        //}
        //

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                //When the staff click cancel button, will clear all textboxes
                txtIssueID.Text = "";
                txtIssueDate.Text = "";
                txtDueDate.Text = "";
                txtBookID.Text = "";
                txtBookTitle.Text = "";
                dtpReturnDate.Value = DateTime.Now;
            }
            catch (Exception)
            { }
        }

     
        private void btnReturnNext_Click(object sender, EventArgs e)
        {
            try
            {
                //Clear the gridview
                dgvReturnList.DataSource = null;

                string issid, booknum;
                issid = txtIssueID.Text; booknum = txtBookID.Text;

                //Update the data in IssueDetail Table
                var q = context.IssueDetails.Where(x => x.IssueID == issid && x.BookISBN == booknum).FirstOrDefault();
                IssueDetail id = (IssueDetail)q;
                id.ReturnDate = dtpReturnDate.Value;
                id.Availability = 1;
                context.SaveChanges();

                //Update date in the books table
                var updateQ = context.Books.Where(x => x.BookISBN == booknum).FirstOrDefault();
                updateQ.BookNumberRented = updateQ.BookNumberRented + 1;
                int i=context.SaveChanges();
                if (i == 1)
                {
                    lst.Clear();
                    MessageBox.Show("Return Successful..");
                    //Bind the gridview again
                    BindGridViewIssueDetails();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry!!System Error");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMemberID.Text == "")
                {
                    MessageBox.Show("Please enter the member id to show in the lists of books in gridview");
                }
                else
                {
                    // check MemberID
                    Member mb = context.Members.Where(x => x.MemberID == txtMemberID.Text).FirstOrDefault();
                    if (mb == null)
                    {
                        MessageBox.Show("Cannot find this member. Please check input");
                        return;
                    }
                    // Fill in Member name
                    txtMemberName.Text = mb.MemberName;
                    // Fill in Grid
                    BindGridViewIssueDetails();
                }
            }
            catch (Exception except)
            {
                //MessageBox.Show("System Error");
                MessageBox.Show(except.ToString());
            }
        }

        private void dgvReturnList_SelectARow(object sender, EventArgs e)
        {
            //txtIssueID.Text = dgvReturnList.SelectedRows[0].ToString();
            //txtBookID.Text = dgvReturnList.SelectedRows[1].ToString();
            int indrow = dgvReturnList.CurrentCell.RowIndex;
            txtIssueID.Text = dgvReturnList.Rows[indrow].Cells[0].Value.ToString();
            txtBookID.Text = dgvReturnList.Rows[indrow].Cells[1].Value.ToString();
            try
            {
                //BookIssue bki = context.BookIssues.Where(x => x.IssueID == txtIssueID.Text).FirstOrDefault();
                //if (bki == null)
                //    return;
                Book bk = context.Books.Where(x => x.BookISBN == txtBookID.Text).FirstOrDefault();
                if (bk == null)
                    return;
                IssueDetail isd = context.IssueDetails.Where(x => x.IssueID == txtIssueID.Text).FirstOrDefault();
                if (isd == null)
                    return;
                //issid = txtIssueID.Text; booknum = txtBookID.Text;
                //var q = context.IssueDetails.Where(x => x.IssueID == txtIssueID.Text && x.BookISBN == booknum).FirstOrDefault();
                //IssueDetail id = (IssueDetail)q;
                //var secondQuery = context.Books.Where(x => x.BookISBN == id.BookISBN).FirstOrDefault();
                //Book b = (Book)secondQuery;
                txtBookTitle.Text = bk.BookTitle;
                txtIssueDate.Text = isd.IssueDate.ToLongDateString();
                txtDueDate.Text = isd.DueDate.ToLongDateString();
            }
            catch (Exception except)
            {
                MessageBox.Show(except.ToString());
            }
        }


    }
}
