using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SA43Team4B
{
    public partial class _01_MainMenu : SA43Team4B.TemplateForm
    {
        //public _01_MainMenu() : this(null) { }
        //public _01_MainMenu(FormLogin caller)
        //{ 
        //    mCaller = caller; 
        //    InitializeComponent(); 
        //}
        public _01_MainMenu() { InitializeComponent(); }
        private void _01_MainMenu_Load(object sender, EventArgs e)
        {
            this.Text = "Have a good day, " + base.UserID;
            // TODO : change userID into name by search database
        }
    }
}
