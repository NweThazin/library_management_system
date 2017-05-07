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
    public partial class FormMemberSearchBook : Form
    {
        LibrarySystemEntities context = new LibrarySystemEntities();
        public FormMemberSearchBook()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //string keyISBN = "%" + textBoxISBN.Text + "%";
            //string keyBook = "%" + textBoxBookTitle.Text + "%";
            //string keyCate = "%" + textBoxBookCategory.Text + "%";
            //string keyAuth = "%" + textBoxAuthor.Text + "%";
            string keyISBN = textBoxISBN.Text;
            string keyBook = textBoxBookTitle.Text;
            string keyCate = textBoxBookCategory.Text;
            string keyAuth = textBoxAuthor.Text;
            try
            {
                var qry = from x in context.Books 
                          where x.BookISBN.Contains(keyISBN) && x.BookTitle.Contains(keyBook) 
                          && x.BookCategory.Contains(keyCate) && x.BookAuthor.Contains(keyAuth)
                          select x;

                dataGridView1.DataSource = qry.ToList();
                    //context.Books.Where(x => x.BookISBN == keyISBN && x.BookTitle == keyBook
                    //&& x.BookCategory == keyCate && x.BookAuthor == keyAuth).ToList();
            }
            catch (Exception except)
            {
                MessageBox.Show(except.ToString());
            }
        }

        private void FormSearchBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
