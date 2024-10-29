using PRINT_INVOICE.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PRINT_INVOICE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DBContext db = new DBContext();
        products product = new products();
        Invoice_Header header = new Invoice_Header();
        Invoice_Det det = new Invoice_Det();
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {                
                cmbItem.DataSource = db.products.Select(x => new { name = x.productName, id = x.id }).ToList();
                cmbItem.DisplayMember = "name";
                cmbItem.ValueMember = "id";
                txtDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
                foreach (DataGridViewColumn col in DGVInvoice.Columns)
                {
                    col.DefaultCellStyle.ForeColor = Color.Navy;
                }
                DGVInvoice.Columns[0].ReadOnly = true;
                DGVInvoice.Columns[1].ReadOnly = true;
                DGVInvoice.Columns[2].ReadOnly = false;
                DGVInvoice.Columns[2].DefaultCellStyle.ForeColor = Color.Red;
                DGVInvoice.Columns[3].ReadOnly = true;
                DGVInvoice.Columns[4].ReadOnly = true;
                DGVInvoice.Columns[5].ReadOnly = true;

                txtNameClien.Select();
                txtNameClien.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=true;
        }

        private void txtNameClien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Enter)
            {
                if (rd_CodeBar.Checked)
                {
                    txtCode.Focus();
                    txtCode.SelectAll();
                }
                else
                {
                    cmbItem.Focus();
                    cmbItem.SelectAll();
                }
            }
        }

        private void cmbItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (cmbItem.SelectedIndex <= -1)
                {
                    MessageBox.Show("من فضلك اختر عنصر من القائمة");
                    return;
                }
                txtQty.Focus();
                txtQty.SelectAll();
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnAdd.PerformClick();
                cmbItem.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addRow();
            calc();
        }

        private void addRow()
        {
            if (cmbItem.SelectedIndex <= -1 || txtCode.Text.Trim() == "" || txtPrice.Text.Trim() == "" || txtQty.Text.Trim() == "") return;
            string code = txtCode.Text;
            string item = cmbItem.Text;
            int qty = Convert.ToInt32(txtQty.Text);
            decimal price = Convert.ToDecimal(txtPrice.Text);
            decimal subTotal = qty * price;

            object[] row = { code, item, qty, price, subTotal };

            for (int i = 0; i < DGVInvoice.Rows.Count; i++)
            {
                if (DGVInvoice.Rows[i].Cells["colItem"].Value.ToString() == cmbItem.Text)
                {
                    DGVInvoice.Rows[i].Cells["colQTY"].Value = Convert.ToInt32(DGVInvoice.Rows[i].Cells["colQTY"].Value) + Convert.ToInt32(txtQty.Text);
                    int q = Convert.ToInt32(DGVInvoice.Rows[i].Cells["colQTY"].Value);
                    decimal p = Convert.ToDecimal(DGVInvoice.Rows[i].Cells["colPrice"].Value);
                    DGVInvoice.Rows[i].Cells["colSubTotal"].Value = p * q;
                    calc();
                    return;
                }
            }
            DGVInvoice.Rows.Add(row);
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                product = db.products.Where(x => x.id == (int)cmbItem.SelectedValue).FirstOrDefault();
                txtCode.Text = product.code.ToString();
                txtPrice.Text = product.productPrice.ToString();
            }
            catch (Exception)
            {
                
            }
            
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        string oldQTY ="0";
        private void DGVInvoice_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (DGVInvoice.CurrentRow !=null)
            {
                oldQTY = DGVInvoice.CurrentRow.Cells["colQTY"].Value + "";
            }
        }

        string newQTY;
        private void DGVInvoice_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVInvoice.CurrentRow != null)
            {
                newQTY = DGVInvoice.CurrentRow.Cells["colQTY"].Value + "";
                if (oldQTY != newQTY && !Regex.IsMatch(newQTY, "^\\d+$"))
                {
                    DGVInvoice.CurrentRow.Cells["colQTY"].Value = oldQTY;                    
                }
                else
                {
                    calc();
                }
            }            
        }

        private void calc()
        {
            if (DGVInvoice.Rows.Count<1)
            {
                txtTotal.Text = "0";
                return;
            }
            decimal newTotal = 0;
            for (int i = 0; i < DGVInvoice.Rows.Count; i++)
            {
                decimal p = Convert.ToDecimal(DGVInvoice.Rows[i].Cells["colPrice"].Value);
                int q = Convert.ToInt32(DGVInvoice.Rows[i].Cells["colQTY"].Value);
                DGVInvoice.Rows[i].Cells["colSubTotal"].Value = p * q;
                DGVInvoice.Rows[i].Cells["Delete"].Value = "X";
                newTotal += Convert.ToDecimal(DGVInvoice.Rows[i].Cells["colSubTotal"].Value);
            }
            txtTotal.Text = newTotal + "";            
        }

        /// <summary>
        /// حذف سطر من الجدول
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGVInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGVInvoice.Columns["Delete"].Index)
            {
                DGVInvoice.Rows.Remove(DGVInvoice.Rows[e.RowIndex]);
                calc();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            invoiceSave();
        }

        private void btnSavePrint_Click(object sender, EventArgs e)
        {
            invoiceSave();
        }

        private void invoiceSave()
        {
            try
            {
                header.Invoice_Nu = txtNum.Text;
                header.Invoice_Date = Convert.ToDateTime(txtDate.Text);
                header.Cus_Name = txtNameClien.Text;
                header.Invoice_Total = Convert.ToDecimal(txtTotal.Text);
                header.Invoice_Discount = Convert.ToDecimal(txtDiscount.Text);
                header.Invoice_Tax = Convert.ToDecimal(txtTax.Text);
                header.Invoice_Net = Convert.ToDecimal(txtNet.Text);
                header.Invoice_Paid = Convert.ToDecimal(txtPaid.Text);
                header.Invoice_remain = Convert.ToDecimal(txtRemain.Text);
                header.invoice_Type = cmbInvoiceType.Text;
                header.invoice_Note = txtNote.Text;
                db.Invoice_Header.Add(header);
                db.SaveChanges();
                for (int i = 0; i < DGVInvoice.RowCount; i++)
                {
                    det.Item_Code = DGVInvoice.Rows[i].Cells["Code"].Value.ToString();
                    det.Item_Qty = (int)DGVInvoice.Rows[i].Cells["colQTY"].Value;
                    det.Item_Price = (decimal)DGVInvoice.Rows[i].Cells["colPrice"].Value;
                    det.total_Price = (decimal)DGVInvoice.Rows[i].Cells["ColSubTotal"].Value;
                    det.InvoiceNu = txtNum.Text;
                    db.Invoice_Det.Add(det);
                    db.SaveChanges();
                }
                MessageBox.Show("تم حفظ الفاتورة");
            }
            catch (Exception)
            {
                MessageBox.Show("هناك مشكلة في عملية الحفظ");
            }
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                try
                {
                    product = db.products.Where(x => x.code == txtCode.Text).FirstOrDefault();
                    cmbItem.Text = product.productName;
                    txtPrice.Text = product.productPrice.ToString();
                    btnAdd.PerformClick();
                    txtCode.SelectAll();
                }
                catch (Exception)
                {

                }
            }
        }

        private void rd_CodeBar_CheckedChanged(object sender, EventArgs e)
        {
            cmbItem.Enabled = false;
            txtPrice.Enabled = false;
            txtQty.Text = "1";
            txtQty.Enabled = false;
            txtCode.Focus();
            txtCode.SelectAll();
        }

        private void rd_Manuel_CheckedChanged(object sender, EventArgs e)
        {
            cmbItem.Enabled = true;
            txtPrice.Enabled = true;
            txtQty.Enabled = true;
            cmbItem.Focus();
            cmbItem.SelectAll();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            txtTax.Text = (Convert.ToDecimal(txtTotal.Text) *(Convert.ToDecimal(txtTaxP.Text)/100)).ToString("0.00");
        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {
            if (txtTax.Text.Trim()!="" )
            {
                txtDiscount.Text = ((Convert.ToDecimal(txtTotal.Text) + Convert.ToDecimal(txtTax.Text)) * (Convert.ToDecimal(txtDiscountP.Text) / 100)).ToString("0.00");
                if (txtTax.Focused)
                {
                    txtTaxP.Text = (Convert.ToDecimal(txtTax.Text) * 100 / Convert.ToDecimal(txtTotal.Text)).ToString("0.00");
                }                
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtNet.Text = (Convert.ToDecimal(txtTotal.Text) + Convert.ToDecimal(txtTax.Text) - Convert.ToDecimal(txtDiscount.Text)).ToString("0.00");
                if (txtDiscount.Focused)
                {
                    txtDiscountP.Text = (Convert.ToDecimal(txtDiscount.Text) * 100 / (Convert.ToDecimal(txtTotal.Text)+ Convert.ToDecimal(txtTax.Text))).ToString("0.00");
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            if (txtNet.Text.Trim() != "" && txtPaid.Text.Trim() != "")
            { 
                txtRemain.Text = (Convert.ToDecimal(txtNet.Text) - Convert.ToDecimal(txtPaid.Text)).ToString("0.00");
            }
        }

        private void txtNet_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtPaid.Text = txtNet.Text;
        }

        private void txtTax_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender,e);
        }

        private void OnlyDigit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.')
            {
                if (((TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtTaxP_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtTaxP.Text)>100)
            {
                txtTaxP.Focus();
                txtTaxP.SelectAll();
            }
        }

        private void txtTaxP_TextChanged(object sender, EventArgs e)
        {
            if (txtTaxP.Text.Trim() != "" && Convert.ToDecimal(txtTaxP.Text) <= 100 && txtTaxP.Focused)
            {
                txtTax.Text = (Convert.ToDecimal(txtTotal.Text) * (Convert.ToDecimal(txtTaxP.Text) / 100)).ToString("0.00");
            }
        }

        private void txtDiscountP_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtDiscountP.Text) > 100)
            {
                txtDiscountP.Focus();
                txtDiscountP.SelectAll();
            }
        }

        private void txtDiscountP_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscountP.Text.Trim() != "" && txtDiscountP.Focused && Convert.ToDecimal(txtDiscountP.Text) <= 100)
            {
                txtDiscount.Text = ((Convert.ToDecimal(txtTotal.Text)+ Convert.ToDecimal(txtTax.Text)) * (Convert.ToDecimal(txtDiscountP.Text) / 100)).ToString("0.00");
            }
        }

        private void txtNet_TextChanged(object sender, EventArgs e)
        {
            txtRemain.Text = (Convert.ToDecimal(txtNet.Text) - Convert.ToDecimal(txtPaid.Text)).ToString();
        }
    }
}
