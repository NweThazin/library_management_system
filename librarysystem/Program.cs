using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA43Team4B
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormMemberMaintenance(1));
            ///*
            FormLogin fl = new FormLogin();
            fl.ShowDialog();
            if (fl.MemberType == "Member")
            {
                FormMemberMain fm = new FormMemberMain();
                fm.UserID = fl.UserID;
                Application.Run(fm);
            }
            if (fl.MemberType == "Staff")
            {
                _01_MainMenu mm = new _01_MainMenu();
                mm.UserID = fl.UserID;
                Application.Run(mm);
            }
            if (fl.MemberType == "Admin")
            {
                _01_MainMenu mm = new _01_MainMenu();
                mm.UserID = fl.UserID;
                Application.Run(mm);
            }
            //*/
        }
    }
}
