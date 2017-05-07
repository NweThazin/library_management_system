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
    public partial class FormBookSearch : Form
    {
        LibrarySystemEntities view;
        List<Book> bList = new List<Book>();

        public FormBookSearch()
        {
            InitializeComponent();
        }

        private void FormBookSearch_Load(object sender, EventArgs e)
        {
            view = new LibrarySystemEntities();
            //    var grid = from x in view.Books
            //            select x;
            //dataGridViewSearch.DataSource = grid.ToList<Book>();

            //RETURNING SELECTED FIELDS ONLY
            dataGridViewSearch.DataSource = view.Books.Select(x =>
            new { x.BookISBN, x.BookTitle, x.BookAuthor, x.BookCategory, x.BookFormat, x.ShelfDetails }).ToList();


            var l = (from x in view.Books select new { x.BookCategory }).Distinct();
            cboCategory.DataSource = l.ToList();
            cboCategory.ValueMember = "BookCategory";
            cboCategory.DisplayMember = "BookCategory";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTitle.Text.Length != 0 || txtAuthor.Text.Length != 0 || cboCategory.Text.Length != 0)
                {

                    if (txtTitle.Text.Length != 0)
                    {
                        view = new LibrarySystemEntities();
                        var bt = from x in view.Books
                                 where x.BookTitle.Contains(txtTitle.Text)
                                 select new
                  { x.BookISBN, x.BookTitle, x.BookAuthor, x.BookCategory, x.BookFormat, x.ShelfDetails};
                        dataGridViewSearch.DataSource = bt.ToList();
                    }
                    else if (txtAuthor.Text.Length != 0)
                    {

                        var ba = from x in view.Books
                                 where x.BookAuthor.Contains(txtAuthor.Text)
                                 select new { x.BookISBN, x.BookTitle, x.BookAuthor, x.BookCategory, x.BookFormat, x.ShelfDetails };
                        dataGridViewSearch.DataSource = ba.ToList();
                    }
                    else if (cboCategory.Text.Length != 0)
                    {
                        var bc = from x in view.Books
                                 where x.BookCategory.Contains(cboCategory.Text)
                                 select new { x.BookISBN, x.BookTitle, x.BookAuthor, x.BookCategory, x.BookFormat, x.ShelfDetails };
                        dataGridViewSearch.DataSource = bc.ToList();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid search criteria!");
                }
            }catch
            (Exception)
            { 
               
                MessageBox.Show("Please enter avalid  search criteria!");
            }            
           
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;
            
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(Controls);

            // to clear category-list
            cboCategory.SelectedIndex = -1;

            //to clear list in gridview
            view = new LibrarySystemEntities();
            var q = from x in view.Books
                    where x.BookTitle == " " || x.BookAuthor == " "
                    select new { x.BookISBN, x.BookTitle, x.BookAuthor, x.BookCategory, x.BookFormat, x.ShelfDetails };
            dataGridViewSearch.DataSource = q.ToList();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                string ava = dataGridViewSearch.CurrentRow.Cells[5].Value.ToString();

                if (ava.ToString() != "Unavailable")

                {

                    if (txtAvailability.Text != null)
                    {
                        string row = dataGridViewSearch.CurrentRow.Cells[0].Value.ToString();

                        FormBookLoaned loanform = new FormBookLoaned(row);
                        loanform.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Book unavailable for loan.");
                }

        }catch
            (Exception)
            {
                MessageBox.Show("Please run a valid search to query for availability.");
            }
}

        private void dataGridViewSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // to handle availability for each selection
            try
            {
                string row = dataGridViewSearch.CurrentRow.Cells[0].Value.ToString();

                int ava = view.Books.Where(x => x.BookISBN == row).Sum(y => y.BookStockNum - y.BookNumberRented);
                txtAvailability.Text = ava.ToString();
            }catch(Exception)
            {
                
            }
        }

        private void dataGridViewSearch_CellContentClick(object sender, EventArgs e)
        {
            // to handle availability for each selection
            try
            {
                string row = dataGridViewSearch.CurrentRow.Cells[0].Value.ToString();

                int ava = view.Books.Where(x => x.BookISBN == row).Sum(y => y.BookStockNum - y.BookNumberRented);
                txtAvailability.Text = ava.ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}
