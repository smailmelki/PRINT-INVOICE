using PRINT_INVOICE.DAL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PRINT_INVOICE
{
    public partial class frmLogIn : Form
    {
        bool correctUser = false;
        DBContext db = new DBContext();
        User user;
        public frmLogIn()
        {
            InitializeComponent();
        }

        public void btnLogIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("أدخل بيانات الدخول");
                return;
            }
            else
            {
                user = db.Users.Where(x => x.Username == txtUsername.Text.Trim()).FirstOrDefault();
                if (user != null)
                {
                    if (user.Password == txtPassword.Text)
                    {
                        correctUser = true;
                        this.Cursor = Cursors.WaitCursor;
                        Util.UserName = user.Name;
                        main main = new main();
                        main.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("password not correct");
                    }
                }
                else
                {
                    MessageBox.Show("user name not exist");
                }
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!correctUser)
                Application.Exit();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
