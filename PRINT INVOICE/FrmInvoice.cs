using PRINT_INVOICE.DAL;
using PRINT_INVOICE.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PRINT_INVOICE
{
    public partial class FrmInvoice: Form
    {
        DBContext db = new DBContext();
        products product;
        Invoice_Header header;
        Invoice_Det detailes;
        InvoiceType type;
        PartType partType;
        public FrmInvoice(InvoiceType Type)
        {
            InitializeComponent();
            this.type = Type;
            initialData();
            New();
        }
        public FrmInvoice(int id)
        {
            InitializeComponent();
            header = db.Invoice_Header.SingleOrDefault(h => h.ID == id);
            this.type = header.Invoice_Type;
            initialData();
            getData(id);
        }

        void initialData()
        {
            partType = type == InvoiceType.Sales ? PartType.Customer : PartType.Vendor;
            lblInvoiceTitle.Text = type == InvoiceType.Sales ? "فاتورة مبيعات" : "فاتورة مشتريات";

            cmbItem.DataSource = Util.products.Where(p => p.IsActive).Select(x => new { ID = x.id, Name = x.productName }).ToList();
            cmbItem.ValueMember = "ID";
            cmbItem.DisplayMember = "Name";

            cmbCustomer.DataSource = Util.CustAndVends.Where(p => p.PartType == partType).Select(x => new { x.ID, x.Name }).ToList();
            cmbCustomer.ValueMember = "ID";
            cmbCustomer.DisplayMember = "Name";
            try
            {
                foreach (DataGridViewColumn col in DGVInvoice.Columns)
                {
                    col.DefaultCellStyle.ForeColor = Color.Navy;
                    col.ReadOnly = true;
                }
                DGVInvoice.Columns["ColQTY"].ReadOnly = false;
                DGVInvoice.Columns["ColQTY"].DefaultCellStyle.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void New()
        {
            header = new Invoice_Header();
            product = new products();
            dtp_Date.Value = DateTime.Now;
            DGVInvoice.Rows.Clear();
            txtNum.Text = GetNextNumberInString(db.Invoice_Header.Where(t => t.Invoice_Type == type).OrderByDescending(x => x.ID).Select(x => x.Invoice_Nu ?? "0").FirstOrDefault());
            txtNote.Text = "";
            txtPrice.Text = "";
            txtQty.Text = "1";
            txtTotal.Text = "0";
            txtPaid.Text = "0";
            cmbCustomer.SelectedIndex = -1;
            cmbItem.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public static string GetNextNumberInString(string Number)
        {
            if (Number == string.Empty || Number == null)
                return "1";
            string str1 = string.Empty;
            foreach (char c in Number)
                str1 = char.IsDigit(c) ? str1 + c.ToString() : string.Empty;
            if (str1 == string.Empty)
                return Number + "1";
            string str2 = str1.Insert(0, "1");
            str2 = (Convert.ToInt64(str2) + 1).ToString();
            string str3 = str2[0] == '1' ? str2.Remove(0, 1) : str2.Remove(0, 1).Insert(0, "1");

            int indx = Number.LastIndexOf(str1);
            Number = Number.Remove(indx);
            Number = Number.Insert(indx, str3);
            return Number;
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
            if (IsDataValid())
            {
                string code = txtCode.Text;
                string item = cmbItem.Text;
                decimal price =Convert.ToDecimal( txtPrice.Text);
                int qty = Convert.ToInt32(txtQty.Text);
                decimal subTotal = qty * price;

                object[] row = { code, item, price, qty, subTotal };

                for (int i = 0; i < DGVInvoice.Rows.Count; i++)
                {
                    if (DGVInvoice.Rows[i].Cells["Code"].Value.ToString() == txtCode.Text)
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
        }

        private bool IsDataValid()        
        {
            int errur = 0;
            if (cmbItem.SelectedIndex <= -1 || txtCode.Text.Trim() == "" || txtPrice.Text.Trim() == "" || txtQty.Text.Trim() == "")
                errur++;
            if (!Regex.IsMatch(txtPrice.Text, "\\d+\\.?\\d*")) 
                errur++;
            if (!Regex.IsMatch(txtQty.Text, "\\d+"))
                errur++;
            return errur == 0;
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbItem.SelectedIndex == -1)
                    return;
                product = Util.products.Where(x => x.id == (int)cmbItem.SelectedValue).FirstOrDefault();
                txtCode.Text = product.code.ToString();
                txtPrice.Text = type == InvoiceType.Sales ? product.SalePrice.ToString() : product.BuyPrice.ToString();
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
            if (DGVInvoice.CurrentRow != null)
            {
                oldQTY = DGVInvoice.CurrentRow.Cells["colQTY"].Value.ToString();
            }
        }

        string newQTY;
        private void DGVInvoice_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVInvoice.CurrentRow != null && e.ColumnIndex == DGVInvoice.Columns["colQTY"].Index)
            {
                newQTY = DGVInvoice.CurrentRow.Cells["colQTY"].Value.ToString();
                if ((oldQTY != newQTY && !Regex.IsMatch(newQTY, "^\\d+$")) || (int.TryParse(newQTY, out int qty) && qty == 0))
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
            if (e.ColumnIndex == DGVInvoice.Columns["Delete"].Index && DGVInvoice.Rows.Count > 0 && e.RowIndex >= 0)
            {
                DGVInvoice.Rows.Remove(DGVInvoice.Rows[e.RowIndex]);
                calc();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (isDataValid())
            {
                invoiceSave();
            }
        }

        private void btnSavePrint_Click(object sender, EventArgs e)
        {
            if (isDataValid())
            {
                // إظهار معاينة الطباعة وطباعة الفاتورة
                ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    printDocument1.Print();
                //invoiceSave();
            }
        }

        public bool isDataValid()
        {
            int error = 0;
            string msg = "";
            if (string.IsNullOrEmpty(txtNum.Text)) error++;
            if (cmbCustomer.SelectedIndex == -1)
            {
                msg += "اختر طرف التعامل اولا\n";
                error++;
            };
            if (DGVInvoice.RowCount == 0)
            {
                msg += "لايمكن حفظ فاتورة فارغة\n";
                error++;
            }
            if (msg != "")
                MessageBox.Show(msg, "خطأ");
            return error == 0;
        }

        void getData(int id)
        {
            txtNum.Text = header.Invoice_Nu;
            dtp_Date.Value = header.Invoice_Date;
            cmbCustomer.SelectedValue = header.Customer_ID;
            txtTotal.Text = header.Invoice_Total.ToString();
            txtDiscount.Text = header.Invoice_Discount.ToString();
            txtTax.Text = header.Invoice_Tax.ToString();
            txtNet.Text = header.Invoice_Net.ToString();
            txtPaid.Text = header.Invoice_Paid.ToString();
            txtRemain.Text = header.Invoice_remain.ToString();
            txtNote.Text = header.invoice_Note;

            List<Invoice_Det> detailes = db.Invoice_Det.Where(d => d.InvoiceID == id).ToList();
            for (int i = 0; i < detailes.Count; i++)
            {
                string code = detailes[i].Item_Code;
                string item = Util.products.Where(p => p.code == detailes[i].Item_Code).Select(x => x.productName).FirstOrDefault();
                decimal price = detailes[i].Item_Price;
                int qty = detailes[i].Item_Qty;
                decimal subTotal = detailes[i].total_Price;

                object[] row = { code, item, price, qty, subTotal };
                DGVInvoice.Rows.Add(row);
            }
        }

        private void invoiceSave()
        {
            using (var contexte = new DBContext())
            {
                if (DGVInvoice.RowCount > 0)
                {
                    using (var transaction = contexte.Database.BeginTransaction())
                    {
                        try
                        {
                            header.Invoice_Nu = txtNum.Text;
                            header.Invoice_Date = dtp_Date.Value.Date;
                            header.Customer_ID = (int)cmbCustomer.SelectedValue;
                            header.Invoice_Total = Convert.ToDecimal(txtTotal.Text);
                            header.Invoice_Discount = Convert.ToDecimal(txtDiscount.Text);
                            header.Invoice_Tax = Convert.ToDecimal(txtTax.Text);
                            header.Invoice_Net = Convert.ToDecimal(txtNet.Text);
                            header.Invoice_Paid = Convert.ToDecimal(txtPaid.Text);
                            header.Invoice_remain = Convert.ToDecimal(txtRemain.Text);
                            header.Invoice_Type = type;
                            header.invoice_Note = txtNote.Text;
                            contexte.Invoice_Header.AddOrUpdate(header);
                            contexte.SaveChanges();
                            List<Invoice_Det> Detailes = contexte.Invoice_Det.Where(d => d.InvoiceID == header.ID).ToList();
                            if (Detailes.Any())
                                contexte.Invoice_Det.RemoveRange(Detailes);
                            List<Invoice_Det> list = new List<Invoice_Det>();
                            for (int i = 0; i < DGVInvoice.RowCount; i++)
                            {
                                detailes = new Invoice_Det();
                                detailes.Item_Code = DGVInvoice.Rows[i].Cells["Code"].Value.ToString();
                                detailes.Item_Qty = int.Parse(DGVInvoice.Rows[i].Cells["colQTY"].Value.ToString());
                                detailes.Item_Price = decimal.Parse(DGVInvoice.Rows[i].Cells["colPrice"].Value.ToString());
                                detailes.total_Price = decimal.Parse(DGVInvoice.Rows[i].Cells["ColSubTotal"].Value.ToString());
                                detailes.InvoiceID = header.ID;
                                detailes.IsIN = type == InvoiceType.purchase;
                                list.Add(detailes);
                            }
                            contexte.Invoice_Det.AddRange(list);
                            contexte.SaveChanges();
                            transaction.Commit();
                            MessageBox.Show("تم حفظ الفاتورة");
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            MessageBox.Show("هناك مشكلة في عملية الحفظ");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("الفاتورة فارغة", "خطأ", MessageBoxButtons.OK);
                }
            }
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                try
                {
                    product = Util.products.Where(x => x.code == txtCode.Text).FirstOrDefault();
                    if (product != null)
                    {
                        if (!product.IsActive)
                        {
                            MessageBox.Show("هذا المنتج غير نشط", "خطأ", MessageBoxButtons.OK);
                            return;
                        }
                        cmbItem.Text = product.productName;
                        txtPrice.Text = type == InvoiceType.Sales ? product.SalePrice.ToString() : product.BuyPrice.ToString();
                        btnAdd.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("هذا المنتج غير مسجل", "خطأ", MessageBoxButtons.OK);     
                    }
                    txtCode.SelectAll();
                }
                catch (Exception)
                {

                }
            }
        }

        private void rd_CodeBar_CheckedChanged(object sender, EventArgs e)
        {
            txtCode.Enabled = true;
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
            txtCode.Enabled = false;
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

        private void btnCustAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCustAndVend frm = new FrmCustAndVend(type == InvoiceType.Sales ? PartType.Customer : PartType.Vendor,this);
                frm.ShowDialog();
                cmbCustomer.DataSource = Util.CustAndVends.Where(p => p.PartType == partType).Select(x => new { x.ID, x.Name }).ToList();
                cmbCustomer.ValueMember = "ID";
                cmbCustomer.DisplayMember = "Name";
                cmbCustomer.SelectedValue = Util.CustomerId;
            }
            catch (Exception)
            {
            }

        }

        #region report

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // تعريف الخط للطباعة
            Font font = new Font("Arial", 18, FontStyle.Bold);

            // رسم الرأس والجدول والتذييل
            DrawHeader(e.Graphics, font, e.PageBounds);
            DrawTable(e.Graphics, font, e.PageBounds);
            DrawFooter(e.Graphics, font, e.PageBounds);
        }

        // تعريف ثوابت للهوامش وعرض الأعمدة                               
        private const float margin = 20;                                  // الهوامش
        private const float imgHeight = 200;                              // ارتفاع الصورة
        private const float ColumnHeight = 50;                            // ارتفاع الأعمدة
        private const float ColumnWidth = 150;                            // عرض العمود
        private const float Column1Width = 300;                           // عرض العمود الأول
        private const float Column2Width = ColumnWidth + Column1Width;    // عرض العمود الثاني
        private const float Column3Width = ColumnWidth + Column2Width;    // عرض العمود الثالث
        private const float Column4Width = ColumnWidth + Column3Width;    // عرض العمود الرابع
        private float HeaderHeight = 0;
        private float TableHeight = 0;
        private float FooterHeight = 0;



        // رسم جزء الرأس من الفاتورة
        private void DrawHeader(Graphics graphics, Font font, RectangleF pageBounds)
        {
            // تعريف النصوص لرقم الفاتورة والتاريخ واسم العميل
            string strNO = "#NO " + txtNum.Text;
            string strDate = " التاريخ :" + dtp_Date.Value.ToString("dd-MM-yyyy");
            string strName = " : الاســـم";
            string strNameValue = cmbCustomer.Text;
            string InvoiceTitle = lblInvoiceTitle.Text;

            // قياس حجم النصوص
            SizeF fontSizeNO = graphics.MeasureString(strNO, font);
            SizeF fontSizeDate = graphics.MeasureString(strDate, font);
            SizeF fontSizeName = graphics.MeasureString(strName, font);
            SizeF fontSizeNameValue = graphics.MeasureString(strNameValue, font);
            Font fontTitle = new Font("Arial", 35, FontStyle.Bold);
            SizeF fontSizeInvoiceTitle = graphics.MeasureString(InvoiceTitle, fontTitle);

            // رسم الشعار ورقم الفاتورة والتاريخ واسم العميل
            graphics.DrawImage(Resources.logo, margin, margin, imgHeight, imgHeight);
            graphics.DrawString(strNO, font, Brushes.Red, (pageBounds.Width - fontSizeNO.Width) / 2, margin);
            graphics.DrawString(strDate, font, Brushes.Black, (pageBounds.Width - fontSizeDate.Width - margin), margin + fontSizeNO.Height);
            graphics.DrawString(strName, font, Brushes.Black, (pageBounds.Width - fontSizeName.Width - margin), margin + fontSizeNO.Height + fontSizeDate.Height);
            graphics.DrawString(strNameValue, font, Brushes.Black, (pageBounds.Width - fontSizeName.Width - fontSizeNameValue.Width - margin), margin + fontSizeNO.Height + fontSizeDate.Height);
            graphics.DrawString(InvoiceTitle, fontTitle, Brushes.Black, (pageBounds.Width - fontSizeInvoiceTitle.Width) / 2, margin + fontSizeNO.Height + fontSizeDate.Height + fontSizeName.Height + 100);
            HeaderHeight = margin + fontSizeNO.Height + fontSizeDate.Height + fontSizeName.Height + 100 + fontSizeInvoiceTitle.Height;
        }

        // رسم جزء الجدول من الفاتورة
        float preHeights = 0;
        private void DrawTable(Graphics graphics, Font font, RectangleF pageBounds)
        {
            // حساب ارتفاع الجدول
            preHeights = Math.Max(HeaderHeight, imgHeight) + 20;

            // رسم مستطيل الجدول وعناوين الأعمدة
            float x1 = pageBounds.Width - margin * 2;
            float y1 = pageBounds.Height - margin;
            graphics.DrawRectangle(Pens.Black, margin, preHeights, x1, y1 - preHeights);

            graphics.DrawString("الصنف", font, Brushes.Navy, x1 - Column1Width / 2 - graphics.MeasureString("الصنف", font).Width / 2, preHeights + 15);
            graphics.DrawLine(Pens.Black, x1 - Column1Width, preHeights, x1 - Column1Width, y1);

            graphics.DrawString("السعر", font, Brushes.Navy, x1 - Column2Width + (ColumnWidth - graphics.MeasureString("السعر", font).Width) / 2, preHeights + 15);
            graphics.DrawLine(Pens.Black, x1 - Column2Width, preHeights, x1 - Column2Width, y1);

            graphics.DrawString("الكمية", font, Brushes.Navy, x1 - Column3Width + (ColumnWidth - graphics.MeasureString("الكمية", font).Width) / 2, preHeights + 15);
            graphics.DrawLine(Pens.Black, x1 - Column3Width, preHeights, x1 - Column3Width, y1);

            graphics.DrawString("اجمالي", font, Brushes.Navy, x1 - Column4Width + (pageBounds.Width - (margin * 2) - 690 - graphics.MeasureString("اجمالي", font).Width) / 2, preHeights + 15);

            // رسم خط تحت صف العناوين
            graphics.DrawLine(Pens.Black, margin, preHeights + ColumnHeight, pageBounds.Width - margin, preHeights + ColumnHeight);


            // رسم صفوف الجدول
            float rowsHeight = ColumnHeight;
            for (int x = 0; x < DGVInvoice.Rows.Count; x++)
            {
                string item = DGVInvoice.Rows[x].Cells[1].Value.ToString();
                graphics.DrawString(item, font, Brushes.Black, x1 - Column1Width + (Column1Width - graphics.MeasureString(item, font).Width) / 2, preHeights + rowsHeight + 15);
                string qty = DGVInvoice.Rows[x].Cells[2].Value.ToString();
                graphics.DrawString(qty, font, Brushes.Black, x1 - Column2Width + (ColumnWidth - graphics.MeasureString(qty, font).Width) / 2, preHeights + rowsHeight + 15);
                string price = DGVInvoice.Rows[x].Cells[3].Value.ToString();
                graphics.DrawString(price, font, Brushes.Black, x1 - Column3Width + (ColumnWidth - graphics.MeasureString(price, font).Width) / 2, preHeights + rowsHeight + 15);
                string total = DGVInvoice.Rows[x].Cells[4].Value.ToString();
                graphics.DrawString(total, font, Brushes.Black, x1 - Column4Width + (ColumnWidth - graphics.MeasureString(total, font).Width) / 2, preHeights + rowsHeight + 15);

                graphics.DrawLine(Pens.Black, margin, preHeights + rowsHeight + ColumnHeight, pageBounds.Width - margin, preHeights + rowsHeight + ColumnHeight);
                rowsHeight += ColumnHeight;
            }
            TableHeight = ColumnHeight * (DGVInvoice.Rows.Count + 1) + preHeights + 10;
        }

        // رسم جزء التذييل من الفاتورة
        private void DrawFooter(Graphics graphics, Font font, RectangleF pageBounds)
        {
            // حساب ارتفاع الجدول
            int a = 15;
            // رسم الإجمالي
            graphics.DrawString(" الاجمالي", font, Brushes.Navy, pageBounds.Width - margin * 2 - Column3Width, TableHeight);
            graphics.DrawString(txtTotal.Text, font, Brushes.Blue, pageBounds.Width - margin * 2 - Column4Width, TableHeight);

            // رسم خط فاصل تحت الإجمالي
            //graphics.DrawLine(Pens.Black, margin, preHeights + rowsHeight + ColumnHeight, pageBounds.Width - margin, preHeights + rowsHeight + ColumnHeight);

            // رسم ضربية المبيعات
            float taxY = TableHeight + ColumnHeight;
            graphics.DrawString(" ضربية المبيعات", font, Brushes.Navy, pageBounds.Width - margin * 2 - Column3Width, taxY - a);
            graphics.DrawString(txtTax.Text, font, Brushes.Blue, pageBounds.Width - margin * 2 - Column4Width, taxY - a);

            // رسم قيمة الخصم
            float DiscountY = taxY + ColumnHeight;
            graphics.DrawString(" قيمة الخصم", font, Brushes.Navy, pageBounds.Width - margin * 2 - Column3Width, DiscountY - 2 * a);
            graphics.DrawString(txtDiscount.Text, font, Brushes.Blue, pageBounds.Width - margin * 2 - Column4Width, DiscountY - 2 * a);

            // رسم صافي الفاتورة
            float NetY = DiscountY + ColumnHeight;
            graphics.DrawString(" صافي الفاتورة", font, Brushes.Navy, pageBounds.Width - margin * 2 - Column3Width, NetY - 3 * a);
            graphics.DrawString(txtNet.Text, font, Brushes.DarkRed, pageBounds.Width - margin * 2 - Column4Width, NetY - 3 * a);

            // رسم المدفوع
            float PaidY = NetY + ColumnHeight;
            graphics.DrawString(" صافي المدفوع", font, Brushes.Navy, pageBounds.Width - margin * 2 - Column3Width, PaidY - 4 * a);
            graphics.DrawString(txtPaid.Text, font, Brushes.DarkGreen, pageBounds.Width - margin * 2 - Column4Width, PaidY - 4 * a);

            // رسم الباقي
            float RemainY = PaidY + ColumnHeight;
            graphics.DrawString(" الباقي", font, Brushes.Navy, pageBounds.Width - margin * 2 - Column3Width, RemainY - 5 * a);
            graphics.DrawString(txtRemain.Text, font, Brushes.Blue, pageBounds.Width - margin * 2 - Column4Width, RemainY - 5 * a);

            // رسم خط فاصل تحت الباقي
            graphics.DrawLine(Pens.Black, margin, RemainY - 6 * a + ColumnHeight, pageBounds.Width - Column2Width - 2 * margin, RemainY - 6 * a + ColumnHeight);
        }
        #endregion

    }
}
