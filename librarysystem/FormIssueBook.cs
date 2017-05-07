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
    public partial class FormIssueBook : Form
    {
        //Declare the entities and list
        LibrarySystemEntities context = new LibrarySystemEntities();
        List<BookIssue> bk = new List<BookIssue>();
        List<IssueDetail> isLst = new List<IssueDetail>();
        int countNumber;

        public FormIssueBook()
        {
            InitializeComponent();
        }
        public FormIssueBook(string psUserID)
        {
            InitializeComponent();
            // Fill in the EmployeeID and set it read only
            txtEmployeeID.Text = psUserID;
            txtEmployeeID.ReadOnly = true;
        }

        private void FormIssueBook_Load(object sender, EventArgs e)
        {
            //This is page load event
            // First, Load IssueID by +1 to last IssueID in database
            try
            {
                IncreaseIssueID();
                isLst.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot increase issue id");
            }
        }
                
        private void IncreaseIssueID()
        {
            //Method to increase the Issue ID
            var q = context.BookIssues.Max(x => x.IssueID);
            int num = Convert.ToInt32(q);
            num = num + 1;
            txtIssueID.Text = num.ToString();
        }
        
        private void ClearAllTextBox()
        {
            //Method for clear all textboxes
            txtBookNumber.Text = "";
            txtCategory.Text = "";
            txtRemark.Text = "";
            txtTitle.Text = "";
            txtMemberID.Text = "";
            txtMemberType.Text = "";
            dtpDueDate.Value = DateTime.Now;
            dtpIssueDate.Value = DateTime.Now;
            this.dataGridView1.DataSource = null;
            isLst.Clear();
        }

        // <Event Handle>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //This is Cancel Button
            ClearAllTextBox();
        }
        private void txtBookNumber_Leave(object sender, EventArgs e)
        {
            /*
             * This is for text book number leave event.
             * After filling data at book number textbox and tab key, the data of input data will shown in textboxes
             */
            try
            {
                if (txtBookNumber.Text == "")
                {
                    MessageBox.Show("Please enter Book ISBN");
                }
                else
                {
                    var q = context.Books.Where(x => x.BookISBN == txtBookNumber.Text).First();
                    txtTitle.Text = q.BookTitle;
                    txtCategory.Text = q.BookCategory;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong Book ISBN Number");
            }
        }
        private void txtMemberID_Leave(object sender, EventArgs e)
        {
            //This is for member id textbox
            //After filling member in textbox, the data of the inputed member id will show in textboxes
            try
            {
                if (txtMemberID.Text == "")
                {
                    MessageBox.Show("Please enter Member ID");
                }
                else
                {
                    var q = context.Members.Where(x => x.MemberID == txtMemberID.Text).First();
                    var categoryData = context.MemberCategories.Where(x => x.MemberType == q.MemberType).First();
                    //txtMemberType.Text = categoryData.MemberType;
                    txtMemberType.Text = q.MemberName;
                    countNumber = categoryData.NumberLimit;
                    
                    dtpDueDate.Value = DateTime.Now.AddDays(Convert.ToInt32(categoryData.DaysLimit));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong Member ID\nIt doen't exit in the database");
            }

        }
        //This is next button for to add more books
        private void btnNextOne_Click(object sender, EventArgs e)
        {
            try
            {
                if (countNumber > 0)
                {
                    IssueDetail id = new IssueDetail();
                    id.IssueID = txtIssueID.Text;
                    id.BookISBN = txtBookNumber.Text;
                    id.IssueDate = dtpIssueDate.Value;
                    id.DueDate = dtpDueDate.Value;
                    id.Remark = txtRemark.Text;
                    id.ReturnDate = DateTime.Now;

                    // check if same book in the list
                    for (int i = 0; i < dataGridView1.Rows.Count; i++ )
                    {
                        string str = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        if (str == txtBookNumber.Text)
                        {
                            MessageBox.Show("Same book exists in borrow list");
                            return;
                        }
                    }
                    //add data to list temporary
                    isLst.Add(id);
                    //Bind in the gridview
                    dataGridView1.DataSource = isLst.ToList();
                    //decrease numbers of books and change in textbox
                    countNumber--;
                    //Clear textboxes for books
                    //txtBookNumber.Text = txtTitle.Text = txtCategory.Text = "";
                }
                else
                {
                    MessageBox.Show("This member cannot borrow books\n over book limits");
                }
            }
            catch (Exception)
            { }

        }
        //This confirm button for issue book
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result=MessageBox.Show("Are you sure to borrow all these books?","Confirmation",MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    int i = 0;
                    //Adding data into the book issue table first
                    BookIssue bi = new BookIssue();
                    bi.IssueID = txtIssueID.Text;
                    bi.MemberID = txtMemberID.Text;
                    bi.EmpID = txtEmployeeID.Text;
                    context.BookIssues.Add(bi);
                    context.SaveChanges();

                    //Add data into the issue details table
                    foreach (IssueDetail it in isLst)
                    {
                        IssueDetail issueD = new IssueDetail();
                        issueD.IssueID = it.IssueID;
                        issueD.BookISBN = it.BookISBN;
                        issueD.IssueDate = it.IssueDate;
                        issueD.ReturnDate = it.ReturnDate;
                        issueD.DueDate = it.DueDate;
                        issueD.Remark = it.Remark;
                        issueD.Availability = 0;
                        context.IssueDetails.Add(issueD);
                        i = context.SaveChanges();

                        //Increase Number of rented times in the book table 
                        Book bk = context.Books.Where(x => x.BookISBN == it.BookISBN).FirstOrDefault();
                        bk.BookNumberRented = bk.BookNumberRented + 1;
                        context.SaveChanges();
                    }
                    if (i == 1)
                    {
                        MessageBox.Show("Successful.."); IncreaseIssueID();
                        DialogResult resultPrint = MessageBox.Show("Do you want to print?", "Confirmation", MessageBoxButtons.YesNoCancel);
                        if (resultPrint == DialogResult.Yes)
                        {
                            FormPrintReceipt fp = new FormPrintReceipt(txtMemberID.Text, dtpIssueDate.Value);
                            fp.Show();
                        }
                        else
                        { }
                        ClearAllTextBox();
                    }
                }
                else if (result == DialogResult.No)
                {
                }
                else
                {
                    this.Close();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Sorry System Error");
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //PrintReceiptForm f = new PrintReceiptForm(txtMemberID.Text,dtpIssueDate.Value);
            //f.Show();
        }
        // </Event Handle>

    }

}
