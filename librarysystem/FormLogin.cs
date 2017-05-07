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
    public partial class FormLogin : Form
    {
        protected Form mCaller = null;
        public string MemberType = "";
        public string UserID = "";
        public FormLogin() : this(null) { }
        public FormLogin(Form caller)
        {
            mCaller = caller;
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //grey out buttons when entry
            this.buttonLogin.Enabled = false;
            this.buttonChangePassword.Enabled = false;
        }
        // serves to grey buttons if no input
        private void textBoxUserID_TextChanged(object sender, EventArgs e)
        {
            if ((this.textBoxUserID.TextLength>0) && (this.textBoxPassword.TextLength>0))
            {
                this.buttonLogin.Enabled = true;
                this.buttonChangePassword.Enabled = true;
            }
            else
            {
                this.buttonLogin.Enabled = false;
                this.buttonChangePassword.Enabled = false;
            }
        }
        // serves to grey buttons if no input
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if ((this.textBoxUserID.TextLength > 0) && (this.textBoxPassword.TextLength > 0))
            {
                this.buttonLogin.Enabled = true;
                this.buttonChangePassword.Enabled = true;
            }
            else
            {
                this.buttonLogin.Enabled = false;
                this.buttonChangePassword.Enabled = false;
            }
        }
        // when click login
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                LibrarySystemEntities lib = new LibrarySystemEntities();
                LogInInfo login1 = lib.LogInInfoes.Where(x => x.UserID.ToUpper() == this.textBoxUserID.Text.ToUpper()).FirstOrDefault();
                if (login1 != null)
                {
                    // compare password type in with password in database
                    if (this.textBoxPassword.Text == login1.LoginPassword)
                    {
                        // log in successful
                        this.UserID = login1.UserID;
                        this.MemberType = login1.UserType;
                        this.Close();
                        return;
                    }
                }
                MessageBox.Show("Invalid Username or Password.\nPlease check.");
            }
            catch (Exception except)
            {
                MessageBox.Show(except.ToString());
            }
        }
        // when click change password
        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            FormChangePassword f = new FormChangePassword(this, this.textBoxUserID.Text, this.textBoxPassword.Text);
            f.ShowDialog();
        }

    }
}
