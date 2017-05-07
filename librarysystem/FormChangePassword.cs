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
    public partial class FormChangePassword : Form
    {
        FormLogin mCaller = null;
        public FormChangePassword() { InitializeComponent();}
        public FormChangePassword(FormLogin caller) : this() { mCaller = caller; }
        public FormChangePassword(FormLogin caller, string strUserID, string strCurrentPassword) : this() 
        { 
            mCaller = caller; 
            // fill the textbox of UserID and CurrentPassword with same text from mCaller
            this.textBoxUserID.Text = strUserID; this.textBoxCurrentPassword.Text = strCurrentPassword;
        }
        private void FormChangePassword_Load(object sender, EventArgs e)
        {
            //grey out buttons when entry
            this.buttonConfirm.Enabled = false;
            
        }
        // serves to grey buttons if no input
        private void textBoxCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxUserID.TextLength * this.textBoxCurrentPassword.TextLength * this.textBoxNewPassword.TextLength * this.textBoxConfirmPassword.TextLength > 0)
            {
                this.buttonConfirm.Enabled = true;
            }
            else
            {
                this.buttonConfirm.Enabled = false;
            }
        }
        // serves to grey buttons if no input
        private void textBoxNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxUserID.TextLength * this.textBoxCurrentPassword.TextLength * this.textBoxNewPassword.TextLength * this.textBoxConfirmPassword.TextLength > 0)
            {
                this.buttonConfirm.Enabled = true;
            }
            else
            {
                this.buttonConfirm.Enabled = false;
            }
        }
        // serves to grey buttons if no input
        private void textBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxUserID.TextLength * this.textBoxCurrentPassword.TextLength * this.textBoxNewPassword.TextLength * this.textBoxConfirmPassword.TextLength > 0)
            {
                this.buttonConfirm.Enabled = true;
            }
            else
            {
                this.buttonConfirm.Enabled = false;
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (this.textBoxNewPassword.Text != this.textBoxConfirmPassword.Text)
            {
                MessageBox.Show("New password do not match.\nPlease check.");
                return;
            }
            if (this.textBoxNewPassword.Text == this.textBoxCurrentPassword.Text)
            {
                MessageBox.Show("New password should not as same as current one.\nPlease check.");
                return;
            }
            // valid userID with CurrentPassword 
            try
            {
                LibrarySystemEntities lib = new LibrarySystemEntities();
                LogInInfo login1 = lib.LogInInfoes.Where(x => x.UserID.ToUpper() == this.textBoxUserID.Text.ToUpper()).FirstOrDefault();
                if (login1 != null)
                {
                    // compare password type in with password in database
                    if (this.textBoxCurrentPassword.Text == login1.LoginPassword)
                    {
                        //update password
                        login1.LoginPassword = this.textBoxNewPassword.Text;
                        lib.SaveChanges();
                        MessageBox.Show("Successfully changed your password.");
                        this.Close();
                        return;
                    }
                }
                MessageBox.Show("Invalid UserID or current password.\nPlease check.");
            }
            catch (Exception except)
            {
                MessageBox.Show(except.ToString());
            }
        }
    }
}
