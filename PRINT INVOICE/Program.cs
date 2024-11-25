using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PRINT_INVOICE
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

            var frm = new frmLogIn();
            frm.Show();
            if (Debugger.IsAttached)
            {
                frm.txtUsername.Text = "Admin";
                frm.txtPassword.Text = "admin";
                frm.btnLogIn_Click(null, null);
            }

            Application.Run();
        }
    }
}
