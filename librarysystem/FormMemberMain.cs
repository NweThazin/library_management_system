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
    public partial class FormMemberMain : Form
    {
        public string UserID = "";
        public FormMemberMain()
        {
            InitializeComponent();
        }

        public FormMemberMain(string strUserID)
        {
            this.UserID = strUserID;
            InitializeComponent();
        }
        private void FormMemberMain_Load(object sender, EventArgs e)
        {
            this.Text = "Have a nice day " + UserID;
        }

        private void bookSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMemberSearchBook fs = new FormMemberSearchBook();
            fs.ShowDialog(this);
        }

        private void myStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMemberStatus fs = new FormMemberStatus(this.UserID);
            fs.ShowDialog(this);
        }


    }
}
