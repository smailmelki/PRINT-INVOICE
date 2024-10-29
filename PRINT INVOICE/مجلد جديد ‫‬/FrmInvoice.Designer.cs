namespace PRINT_INVOICE
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNameClien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.DGVInvoice = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTaxP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtDiscountP = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtRemain = new System.Windows.Forms.TextBox();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.txtNet = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btnSavePrint = new System.Windows.Forms.Button();
            this.rd_CodeBar = new System.Windows.Forms.RadioButton();
            this.rd_Manuel = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbInvoiceType = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInvoice)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1128, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 38);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "رقم الفاتورة :";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(14, 9);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(189, 27);
            this.txtNum.TabIndex = 0;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "تاريخ الفاتورة :";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(14, 50);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(189, 27);
            this.txtDate.TabIndex = 1;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbInvoiceType);
            this.panel1.Controls.Add(this.txtNum);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.txtNameClien);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(318, 216);
            this.panel1.TabIndex = 0;
            // 
            // txtNameClien
            // 
            this.txtNameClien.Location = new System.Drawing.Point(14, 91);
            this.txtNameClien.Name = "txtNameClien";
            this.txtNameClien.Size = new System.Drawing.Size(189, 27);
            this.txtNameClien.TabIndex = 2;
            this.txtNameClien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNameClien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNameClien_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "اسم الزبون :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "الصنف :";
            // 
            // cmbItem
            // 
            this.cmbItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(625, 277);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(196, 27);
            this.cmbItem.TabIndex = 2;
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            this.cmbItem.Enter += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            this.cmbItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbItem_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(824, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "السعر :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(888, 277);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(108, 27);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(999, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "الكمية :";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(1065, 277);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(60, 27);
            this.txtQty.TabIndex = 4;
            this.txtQty.Text = "1";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // DGVInvoice
            // 
            this.DGVInvoice.AllowUserToAddRows = false;
            this.DGVInvoice.AllowUserToDeleteRows = false;
            this.DGVInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVInvoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVInvoice.BackgroundColor = System.Drawing.Color.White;
            this.DGVInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.colItem,
            this.ColQTY,
            this.colPrice,
            this.ColSubTotal,
            this.delete});
            this.DGVInvoice.Location = new System.Drawing.Point(352, 314);
            this.DGVInvoice.Name = "DGVInvoice";
            this.DGVInvoice.Size = new System.Drawing.Size(856, 343);
            this.DGVInvoice.TabIndex = 9;
            this.DGVInvoice.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DGVInvoice_CellBeginEdit);
            this.DGVInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVInvoice_CellContentClick);
            this.DGVInvoice.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVInvoice_CellEndEdit);
            // 
            // Code
            // 
            this.Code.HeaderText = "كود الصنف";
            this.Code.Name = "Code";
            // 
            // colItem
            // 
            this.colItem.FillWeight = 105.3371F;
            this.colItem.HeaderText = "الصنف";
            this.colItem.Name = "colItem";
            // 
            // ColQTY
            // 
            this.ColQTY.FillWeight = 96.35976F;
            this.ColQTY.HeaderText = "الكمية";
            this.ColQTY.Name = "ColQTY";
            // 
            // colPrice
            // 
            this.colPrice.FillWeight = 96.35976F;
            this.colPrice.HeaderText = "سعر الوحدة";
            this.colPrice.Name = "colPrice";
            // 
            // ColSubTotal
            // 
            this.ColSubTotal.FillWeight = 96.35976F;
            this.ColSubTotal.HeaderText = "الاجمالي الفرعي";
            this.ColSubTotal.Name = "ColSubTotal";
            // 
            // delete
            // 
            this.delete.FillWeight = 25.58376F;
            this.delete.HeaderText = "حذف";
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delete.Text = "X";
            this.delete.ToolTipText = "حذف سطر";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtTax);
            this.panel2.Controls.Add(this.txtTaxP);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtDiscount);
            this.panel2.Controls.Add(this.txtDiscountP);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.txtRemain);
            this.panel2.Controls.Add(this.txtPaid);
            this.panel2.Controls.Add(this.txtNet);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(12, 321);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(318, 272);
            this.panel2.TabIndex = 6;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(14, 51);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(100, 27);
            this.txtTax.TabIndex = 10;
            this.txtTax.Text = "0";
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTax.TextChanged += new System.EventHandler(this.txtTax_TextChanged);
            this.txtTax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTax_KeyPress);
            // 
            // txtTaxP
            // 
            this.txtTaxP.Location = new System.Drawing.Point(131, 51);
            this.txtTaxP.Name = "txtTaxP";
            this.txtTaxP.Size = new System.Drawing.Size(53, 27);
            this.txtTaxP.TabIndex = 9;
            this.txtTaxP.Text = "19";
            this.txtTaxP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTaxP.TextChanged += new System.EventHandler(this.txtTaxP_TextChanged);
            this.txtTaxP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTax_KeyPress);
            this.txtTaxP.Leave += new System.EventHandler(this.txtTaxP_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "ضربية المبيعات :";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(14, 95);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 27);
            this.txtDiscount.TabIndex = 6;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTax_KeyPress);
            // 
            // txtDiscountP
            // 
            this.txtDiscountP.Location = new System.Drawing.Point(131, 95);
            this.txtDiscountP.Name = "txtDiscountP";
            this.txtDiscountP.Size = new System.Drawing.Size(53, 27);
            this.txtDiscountP.TabIndex = 1;
            this.txtDiscountP.Text = "10";
            this.txtDiscountP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiscountP.TextChanged += new System.EventHandler(this.txtDiscountP_TextChanged);
            this.txtDiscountP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTax_KeyPress);
            this.txtDiscountP.Leave += new System.EventHandler(this.txtDiscountP_Leave);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(14, 10);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(170, 27);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // txtRemain
            // 
            this.txtRemain.Location = new System.Drawing.Point(14, 225);
            this.txtRemain.Name = "txtRemain";
            this.txtRemain.ReadOnly = true;
            this.txtRemain.Size = new System.Drawing.Size(170, 27);
            this.txtRemain.TabIndex = 5;
            this.txtRemain.Text = "0";
            this.txtRemain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPaid
            // 
            this.txtPaid.Location = new System.Drawing.Point(14, 182);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(170, 27);
            this.txtPaid.TabIndex = 4;
            this.txtPaid.Text = "0";
            this.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaid.TextChanged += new System.EventHandler(this.txtPaid_TextChanged);
            this.txtPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTax_KeyPress);
            // 
            // txtNet
            // 
            this.txtNet.Location = new System.Drawing.Point(14, 139);
            this.txtNet.Name = "txtNet";
            this.txtNet.ReadOnly = true;
            this.txtNet.Size = new System.Drawing.Size(170, 27);
            this.txtNet.TabIndex = 3;
            this.txtNet.Text = "0";
            this.txtNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNet.TextChanged += new System.EventHandler(this.txtNet_TextChanged);
            this.txtNet.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtNet_MouseDoubleClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(188, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "الباقي :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(188, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "قيمة الخصم :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "صافي الفاتورة :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(188, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "المدفوع :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "اجمالي الفاتورة :";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Silver;
            this.label13.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(643, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(281, 52);
            this.label13.TabIndex = 1;
            this.label13.Text = "فاتور مبيعات";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(358, 281);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 19);
            this.label14.TabIndex = 1;
            this.label14.Text = "كود الصنف :";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(449, 277);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(108, 27);
            this.txtCode.TabIndex = 1;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(20, 611);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(102, 38);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "حفظ";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btnSavePrint
            // 
            this.btnSavePrint.Location = new System.Drawing.Point(214, 611);
            this.btnSavePrint.Name = "btnSavePrint";
            this.btnSavePrint.Size = new System.Drawing.Size(102, 38);
            this.btnSavePrint.TabIndex = 8;
            this.btnSavePrint.Text = "حفظ وطباعة";
            this.btnSavePrint.UseVisualStyleBackColor = true;
            this.btnSavePrint.Click += new System.EventHandler(this.btnSavePrint_Click);
            // 
            // rd_CodeBar
            // 
            this.rd_CodeBar.AutoSize = true;
            this.rd_CodeBar.Location = new System.Drawing.Point(47, 286);
            this.rd_CodeBar.Name = "rd_CodeBar";
            this.rd_CodeBar.Size = new System.Drawing.Size(108, 23);
            this.rd_CodeBar.TabIndex = 10;
            this.rd_CodeBar.Text = "بيع بالكود بار";
            this.rd_CodeBar.UseVisualStyleBackColor = true;
            this.rd_CodeBar.CheckedChanged += new System.EventHandler(this.rd_CodeBar_CheckedChanged);
            // 
            // rd_Manuel
            // 
            this.rd_Manuel.AutoSize = true;
            this.rd_Manuel.Checked = true;
            this.rd_Manuel.Location = new System.Drawing.Point(198, 286);
            this.rd_Manuel.Name = "rd_Manuel";
            this.rd_Manuel.Size = new System.Drawing.Size(103, 23);
            this.rd_Manuel.TabIndex = 11;
            this.rd_Manuel.TabStop = true;
            this.rd_Manuel.Text = "ادخال يدوي";
            this.rd_Manuel.UseVisualStyleBackColor = true;
            this.rd_Manuel.CheckedChanged += new System.EventHandler(this.rd_Manuel_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(216, 176);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 19);
            this.label15.TabIndex = 1;
            this.label15.Text = "ملاحظات :";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(14, 173);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(189, 27);
            this.txtNote.TabIndex = 2;
            this.txtNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNameClien_KeyDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(216, 135);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 19);
            this.label16.TabIndex = 3;
            this.label16.Text = "نوع الفاتورة :";
            // 
            // cmbInvoiceType
            // 
            this.cmbInvoiceType.FormattingEnabled = true;
            this.cmbInvoiceType.Items.AddRange(new object[] {
            "مشتريات",
            "مبيعات"});
            this.cmbInvoiceType.Location = new System.Drawing.Point(14, 132);
            this.cmbInvoiceType.Name = "cmbInvoiceType";
            this.cmbInvoiceType.Size = new System.Drawing.Size(188, 27);
            this.cmbInvoiceType.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1230, 671);
            this.Controls.Add(this.rd_Manuel);
            this.Controls.Add(this.rd_CodeBar);
            this.Controls.Add(this.DGVInvoice);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSavePrint);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInvoice)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNameClien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.DataGridView DGVInvoice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtNet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiscountP;
        private System.Windows.Forms.TextBox txtRemain;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btnSavePrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.RadioButton rd_CodeBar;
        private System.Windows.Forms.RadioButton rd_Manuel;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTaxP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbInvoiceType;
        private System.Windows.Forms.Label label16;
    }
}

