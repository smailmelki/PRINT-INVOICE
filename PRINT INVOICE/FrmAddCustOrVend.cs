using PRINT_INVOICE.DAL;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace PRINT_INVOICE
{
    public partial class FrmAddCustOrVend : Form
    {
        DBContext db = new DBContext();
        CustAndVend custAndVend;
        PartType type;
        public FrmAddCustOrVend(PartType Type)
        {
            InitializeComponent();
            this.type = Type;
            custAndVend = new CustAndVend();
        }
        public FrmAddCustOrVend(int ID)
        {
            InitializeComponent();
            custAndVend = db.CustAndVends.Find(ID);
            this.type = custAndVend.PartType;
            GetData();
        }

        private void FrmAddCustOrVend_Load(object sender, EventArgs e)
        {
            this.Text = type == PartType.Customer ? "العملاء" : "الموردون";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("أدخل كل البيانات");
            }
            else
            {
                try
                {
                    setdata();
                    db.CustAndVends.AddOrUpdate(custAndVend);
                    db.SaveChanges();
                    Util.CustAndVends.Remove(Util.CustAndVends.Where(x => x.ID == custAndVend.ID).FirstOrDefault());
                    Util.CustAndVends.Add(custAndVend);
                    this.Close();
                }
                catch (Exception)
                {

                }
            }
        }
        void setdata()
        {            
            custAndVend.Name = txtName.Text;
            custAndVend.Phone = txtPhone.Text;
            custAndVend.Address = txtAddress.Text;
            custAndVend.PartType = type;
        }
        private void GetData()
        {
            txtName.Text = custAndVend.Name;
            txtPhone.Text = custAndVend.Phone;
            txtAddress.Text = custAndVend.Address;
        }
    }
}
