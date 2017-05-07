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
    public partial class FormMaintenanceBook : Form
    {
        //public FormBookMaintenance()
        //{
        //    InitializeComponent();
        //    AddBooksList();
        //}

        private void FormBookMaintenance_Load(object sender, EventArgs e)
        {
            try
            {
                if (index == "0")
                {
                    tabBookControl.SelectedTab = tabAddNewBook;
                }
                else
                {
                    tabBookControl.SelectedTab = ModifyTabPage;
                }
                //Clear The Add New Book Textboxes when page load
                ClearTextBox();
                //Load First Value of the Book Table
                ShowDataInModifyBook();
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry!! System Error");
            }
        }

        //private void FormBookMaintenance_Load(object sender, EventArgs e)
        //{

        //}

        LibrarySystemEntities context = new LibrarySystemEntities();
        List<Book> blst; Book b;
        string index;
        int pos = 0;

        public FormMaintenanceBook()
        {
            InitializeComponent();
            AddBooksList();
        }
        //Constructor to pass data
        public FormMaintenanceBook(string index)
        {
            InitializeComponent();
            this.index = index;
            AddBooksList();
        }
        //This is to Adding book lists to the list
        private void AddBooksList()
        {
            try
            {
                var q = from x in context.Books select x;
                blst = q.ToList();
            }
            catch (Exception except)
            {
                MessageBox.Show(except.ToString());
            }

            // update the data source of combobox
            cboMISBN.Items.Clear();
            AutoCompleteStringCollection AutoCollection = new AutoCompleteStringCollection();
            foreach (Book bk in blst)
            {
                cboMISBN.Items.Add(bk.BookISBN.ToString());
                AutoCollection.Add(bk.BookISBN.ToString());
            }
            cboMISBN.AutoCompleteCustomSource = AutoCollection;
            cboMISBN.Text = cboMISBN.Items[0].ToString();
        }
        //Add New Book Function
        private void AddNewBook()
        {
            b = new Book();
            b.BookISBN = txtISBN.Text;
            b.BookTitle = txtTitle.Text;
            b.BookCategory = txtBookCategory.Text;
            b.BookAuthor = txtAuthor.Text;
            b.BookPress = txtPress.Text;
            b.BookEdition = txtEdition.Text;
            b.BookPrice = (decimal)Convert.ToDouble(txtPrice.Text);
            b.BookStockNum = Convert.ToInt32(txtStockNumber.Text);
            b.BookNumberRented = 0;
            b.BookWordNumber = txtWordNumber.Text;
            b.BookFormat = txtFormat.Text;
            b.ShelfDetails = txtSheldDetails.Text;
        }
        //This is clear the textboxes
        private void ClearTextBox()
        {
            txtISBN.Text = "";
            txtTitle.Text = "";
            txtBookCategory.Text = "";
            txtAuthor.Text = "";
            txtPress.Text = "";
            txtEdition.Text = "";
            txtPrice.Text = "";
            txtStockNumber.Text = "";
            txtWordNumber.Text = "";
            txtFormat.Text = "";
            txtSheldDetails.Text = "";
        }
        private void ClearMTextBox()
        {
            txtMISBN.Text = "";
            txtMTitle.Text = "";
            txtMCategory.Text = "";
            txtMAuthor.Text = "";
            txtMPress.Text = "";
            txtMEdition.Text = "";
            txtMPrice.Text = "";
            txtMStock.Text = "";
            txtMWordNumber.Text = "";
            txtMBookFormat.Text = "";
            txtMSheldDetails.Text = "";
        }

        //Show data from the textbox and shown in the textboxes
        private void ShowDataInModifyBook()
        {
            txtMISBN.Text = blst[pos].BookISBN;
            txtMTitle.Text = blst[pos].BookTitle;
            txtMCategory.Text = blst[pos].BookCategory;
            txtMAuthor.Text = blst[pos].BookAuthor;
            txtMPress.Text = blst[pos].BookPress;
            txtMEdition.Text = blst[pos].BookEdition;
            txtMPrice.Text = blst[pos].BookPrice.ToString();
            txtMStock.Text = blst[pos].BookStockNum.ToString();
            txtMRented.Text = blst[pos].BookNumberRented.ToString();
            txtMWordNumber.Text = blst[pos].BookWordNumber;
            txtMBookFormat.Text = blst[pos].BookFormat;
            txtMSheldDetails.Text = blst[pos].ShelfDetails;
        }
        //To show the index of the record
        private void showRecord()
        {
            int show = pos;
            lblShowPosition.Text = "Record: " + (show + 1).ToString();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboMISBN.Items.IndexOf(txtISBN.Text)>=0)
            {
                MessageBox.Show("Book with same ISBN exist in database. Cannot add this book.");
                return;
            }
            try
            {
                //Call AddNewBook Method to add new book to entity and save to the database
                AddNewBook();
                context.Books.Add(b);
                int num = context.SaveChanges();
                if (num == 1)
                {
                  MessageBox.Show("Insert Sucessful");
                  ClearTextBox();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error..Cannot add new book\nPlease check all textboxes");
            }
        }
        //For Cancel Button
        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        //To show the first record of the table
        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                pos = 0;
                ShowDataInModifyBook();
                showRecord();
            }
            catch (Exception)
            {
                MessageBox.Show("The First Record\nCannot Click");
            }
        }
        //To show the last record of the table
        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                pos = blst.Count - 1;
                ShowDataInModifyBook();
                showRecord();
            }
            catch (Exception)
            {
                MessageBox.Show("The last Record\n Cannot Click");
            }
        }
        //To show the previous record of the table
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                if (pos > 0)
                {
                    pos--;
                    ShowDataInModifyBook();
                    showRecord();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot Click..System Error");
            }

        }
        //To show the next record of the table
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (pos < blst.Count - 1)
                {
                    pos++;
                    ShowDataInModifyBook();
                    showRecord();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Cannot Click..System Error");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Book b = context.Books.Where(x => x.BookISBN == txtMISBN.Text).First();
                b.BookTitle = txtMTitle.Text;
                b.BookCategory = txtMCategory.Text;
                b.BookAuthor = txtMCategory.Text;
                b.BookPress = txtMPress.Text;
                b.BookEdition = txtMEdition.Text;
                b.BookPrice = (int)Convert.ToDecimal(txtMPrice.Text);
                b.BookStockNum = Convert.ToInt32(txtMStock.Text);
                b.BookNumberRented = Convert.ToInt32(txtMRented.Text);
                b.BookWordNumber = txtMWordNumber.Text;
                b.BookFormat = txtMBookFormat.Text;
                b.ShelfDetails = txtMSheldDetails.Text;
                int i = context.SaveChanges();
                if (i == 1)
                {
                    MessageBox.Show("Update Successful..");
                }
            }
            catch (Exception)
            { MessageBox.Show("Unsuccessful, nothing updated."); }
        }

        //Decommit Button.. Remove the books from the library
        //but our business rule is we still keep book data in the database and cannot be searched by members
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string str = txtMISBN.Text;
                Book q = context.Books.Where(x => x.BookISBN == str).FirstOrDefault();
                q.BookNumberRented = q.BookStockNum;
                q.ShelfDetails = "Unavailable";
                int i = context.SaveChanges();
                if (i == 1)
                {
                    MessageBox.Show("Update Succesful..");
                    ShowDataInModifyBook();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry!! System Error..");
            }
        }
        //TabBookControlChangeEvent
        private void tabBookControl_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                AddBooksList();
            }
            catch (Exception)
            {
                MessageBox.Show("System Error");
            }
        }

        private void cboMISBN_TextChanged(object sender, EventArgs e)
        {
            int i = cboMISBN.Items.IndexOf(cboMISBN.Text);
            if (i >= 0)
            {
                txtMISBN.Text = cboMISBN.Text;
                pos = i;
                ShowDataInModifyBook();
                showRecord();
            }
            else
            {
                ClearMTextBox();
            }
        }
                
    }
}
