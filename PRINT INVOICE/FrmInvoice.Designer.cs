namespace PRINT_INVOICE
{
    partial class FrmInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInvoice));
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCustAdd = new System.Windows.Forms.Button();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
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
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTaxP = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtDiscountP = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtRemain = new System.Windows.Forms.TextBox();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.txtNet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblInvoiceTitle = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btnSavePrint = new System.Windows.Forms.Button();
            this.rd_CodeBar = new System.Windows.Forms.RadioButton();
            this.rd_Manuel = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInvoice)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(78, 15);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 35);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "رقم الفاتورة :";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(12, 9);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(185, 34);
            this.txtNum.TabIndex = 0;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "تاريخ الفاتورة :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCustAdd);
            this.panel1.Controls.Add(this.dtp_Date);
            this.panel1.Controls.Add(this.txtNum);
            this.panel1.Controls.Add(this.cmbCustomer);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(8, 15);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(323, 229);
            this.panel1.TabIndex = 0;
            // 
            // btnCustAdd
            // 
            this.btnCustAdd.Location = new System.Drawing.Point(9, 80);
            this.btnCustAdd.Name = "btnCustAdd";
            this.btnCustAdd.Size = new System.Drawing.Size(64, 37);
            this.btnCustAdd.TabIndex = 4;
            this.btnCustAdd.Text = "Add";
            this.btnCustAdd.UseVisualStyleBackColor = true;
            this.btnCustAdd.Click += new System.EventHandler(this.btnCustAdd_Click);
            // 
            // dtp_Date
            // 
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(12, 47);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(185, 34);
            this.dtp_Date.TabIndex = 3;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(81, 84);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(116, 35);
            this.cmbCustomer.TabIndex = 2;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            this.cmbCustomer.Enter += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            this.cmbCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbItem_KeyDown);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(12, 124);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(185, 99);
            this.txtNote.TabIndex = 2;
            this.txtNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNameClien_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(200, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 27);
            this.label15.TabIndex = 1;
            this.label15.Text = "ملاحظات :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "اسم الزبون :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(709, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 9, 5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "الصنف :";
            // 
            // cmbItem
            // 
            this.cmbItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(524, 17);
            this.cmbItem.Margin = new System.Windows.Forms.Padding(5, 7, 5, 5);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(175, 35);
            this.cmbItem.TabIndex = 2;
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            this.cmbItem.Enter += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            this.cmbItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbItem_KeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 9, 5, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "السعر :";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.Location = new System.Drawing.Point(322, 17);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(5, 7, 5, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(101, 34);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 9, 5, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 27);
            this.label6.TabIndex = 1;
            this.label6.Text = "الكمية :";
            // 
            // txtQty
            // 
            this.txtQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQty.Location = new System.Drawing.Point(162, 17);
            this.txtQty.Margin = new System.Windows.Forms.Padding(5, 7, 5, 5);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(56, 34);
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
            this.DGVInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVInvoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVInvoice.BackgroundColor = System.Drawing.Color.White;
            this.DGVInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.colItem,
            this.colPrice,
            this.ColQTY,
            this.ColSubTotal,
            this.delete});
            this.DGVInvoice.Location = new System.Drawing.Point(6, 280);
            this.DGVInvoice.Name = "DGVInvoice";
            this.DGVInvoice.RowHeadersVisible = false;
            this.DGVInvoice.RowHeadersWidth = 51;
            this.DGVInvoice.Size = new System.Drawing.Size(1051, 319);
            this.DGVInvoice.TabIndex = 9;
            this.DGVInvoice.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DGVInvoice_CellBeginEdit);
            this.DGVInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVInvoice_CellContentClick);
            this.DGVInvoice.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVInvoice_CellEndEdit);
            // 
            // Code
            // 
            this.Code.HeaderText = "كود الصنف";
            this.Code.MaxInputLength = 100;
            this.Code.MinimumWidth = 60;
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // colItem
            // 
            this.colItem.FillWeight = 150F;
            this.colItem.HeaderText = "الصنف";
            this.colItem.MaxInputLength = 150;
            this.colItem.MinimumWidth = 60;
            this.colItem.Name = "colItem";
            this.colItem.ReadOnly = true;
            // 
            // colPrice
            // 
            dataGridViewCellStyle2.NullValue = "0.00";
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.colPrice.HeaderText = "سعر الوحدة";
            this.colPrice.MaxInputLength = 140;
            this.colPrice.MinimumWidth = 60;
            this.colPrice.Name = "colPrice";
            // 
            // ColQTY
            // 
            this.ColQTY.HeaderText = "الكمية";
            this.ColQTY.MaxInputLength = 100;
            this.ColQTY.MinimumWidth = 60;
            this.ColQTY.Name = "ColQTY";
            // 
            // ColSubTotal
            // 
            this.ColSubTotal.HeaderText = "الاجمالي الفرعي";
            this.ColSubTotal.MaxInputLength = 150;
            this.ColSubTotal.MinimumWidth = 60;
            this.ColSubTotal.Name = "ColSubTotal";
            this.ColSubTotal.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.FillWeight = 40F;
            this.delete.HeaderText = "حذف";
            this.delete.MinimumWidth = 40;
            this.delete.Name = "delete";
            this.delete.Text = "X";
            this.delete.ToolTipText = "حذف سطر";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtTax);
            this.panel2.Controls.Add(this.txtTaxP);
            this.panel2.Controls.Add(this.txtDiscount);
            this.panel2.Controls.Add(this.txtDiscountP);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.txtRemain);
            this.panel2.Controls.Add(this.txtPaid);
            this.panel2.Controls.Add(this.txtNet);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(8, 294);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(323, 253);
            this.panel2.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.Location = new System.Drawing.Point(97, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 35);
            this.label16.TabIndex = 11;
            this.label16.Text = "%";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(95, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 35);
            this.label13.TabIndex = 11;
            this.label13.Text = "%";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTax
            // 
            this.txtTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTax.Location = new System.Drawing.Point(6, 47);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(65, 34);
            this.txtTax.TabIndex = 10;
            this.txtTax.Text = "0";
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTax.TextChanged += new System.EventHandler(this.txtTax_TextChanged);
            this.txtTax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTax_KeyPress);
            // 
            // txtTaxP
            // 
            this.txtTaxP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaxP.Location = new System.Drawing.Point(123, 47);
            this.txtTaxP.Name = "txtTaxP";
            this.txtTaxP.Size = new System.Drawing.Size(40, 34);
            this.txtTaxP.TabIndex = 9;
            this.txtTaxP.Text = "19";
            this.txtTaxP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTaxP.TextChanged += new System.EventHandler(this.txtTaxP_TextChanged);
            this.txtTaxP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTax_KeyPress);
            this.txtTaxP.Leave += new System.EventHandler(this.txtTaxP_Leave);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscount.Location = new System.Drawing.Point(6, 88);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(65, 34);
            this.txtDiscount.TabIndex = 6;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTax_KeyPress);
            // 
            // txtDiscountP
            // 
            this.txtDiscountP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscountP.Location = new System.Drawing.Point(123, 88);
            this.txtDiscountP.Name = "txtDiscountP";
            this.txtDiscountP.Size = new System.Drawing.Size(40, 34);
            this.txtDiscountP.TabIndex = 1;
            this.txtDiscountP.Text = "10";
            this.txtDiscountP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscountP.TextChanged += new System.EventHandler(this.txtDiscountP_TextChanged);
            this.txtDiscountP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTax_KeyPress);
            this.txtDiscountP.Leave += new System.EventHandler(this.txtDiscountP_Leave);
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Location = new System.Drawing.Point(6, 9);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(157, 34);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // txtRemain
            // 
            this.txtRemain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemain.Location = new System.Drawing.Point(6, 209);
            this.txtRemain.Name = "txtRemain";
            this.txtRemain.ReadOnly = true;
            this.txtRemain.Size = new System.Drawing.Size(157, 34);
            this.txtRemain.TabIndex = 5;
            this.txtRemain.Text = "0";
            this.txtRemain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPaid
            // 
            this.txtPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaid.Location = new System.Drawing.Point(6, 169);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(157, 34);
            this.txtPaid.TabIndex = 4;
            this.txtPaid.Text = "0";
            this.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaid.TextChanged += new System.EventHandler(this.txtPaid_TextChanged);
            this.txtPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTax_KeyPress);
            // 
            // txtNet
            // 
            this.txtNet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNet.Location = new System.Drawing.Point(6, 129);
            this.txtNet.Name = "txtNet";
            this.txtNet.ReadOnly = true;
            this.txtNet.Size = new System.Drawing.Size(157, 34);
            this.txtNet.TabIndex = 3;
            this.txtNet.Text = "0";
            this.txtNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNet.TextChanged += new System.EventHandler(this.txtNet_TextChanged);
            this.txtNet.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtNet_MouseDoubleClick);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(167, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 27);
            this.label9.TabIndex = 8;
            this.label9.Text = "ضربية المبيعات :";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(167, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 27);
            this.label12.TabIndex = 1;
            this.label12.Text = "الباقي :";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(167, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 27);
            this.label10.TabIndex = 1;
            this.label10.Text = "قيمة الخصم :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 27);
            this.label7.TabIndex = 1;
            this.label7.Text = "صافي الفاتورة :";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(167, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 27);
            this.label11.TabIndex = 1;
            this.label11.Text = "المدفوع :";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 27);
            this.label8.TabIndex = 1;
            this.label8.Text = "اجمالي الفاتورة :";
            // 
            // lblInvoiceTitle
            // 
            this.lblInvoiceTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInvoiceTitle.BackColor = System.Drawing.Color.Silver;
            this.lblInvoiceTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceTitle.Location = new System.Drawing.Point(385, 34);
            this.lblInvoiceTitle.Name = "lblInvoiceTitle";
            this.lblInvoiceTitle.Size = new System.Drawing.Size(268, 89);
            this.lblInvoiceTitle.TabIndex = 1;
            this.lblInvoiceTitle.Text = "فاتور مبيعات";
            this.lblInvoiceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(905, 19);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 9, 5, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 27);
            this.label14.TabIndex = 1;
            this.label14.Text = "كود الصنف :";
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(802, 17);
            this.txtCode.Margin = new System.Windows.Forms.Padding(5, 7, 5, 5);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(93, 34);
            this.txtCode.TabIndex = 1;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(35, 553);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(79, 46);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "حفظ";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btnSavePrint
            // 
            this.btnSavePrint.Location = new System.Drawing.Point(131, 553);
            this.btnSavePrint.Name = "btnSavePrint";
            this.btnSavePrint.Size = new System.Drawing.Size(79, 46);
            this.btnSavePrint.TabIndex = 8;
            this.btnSavePrint.Text = "طباعة ";
            this.btnSavePrint.UseVisualStyleBackColor = true;
            this.btnSavePrint.Click += new System.EventHandler(this.btnSavePrint_Click);
            // 
            // rd_CodeBar
            // 
            this.rd_CodeBar.AutoSize = true;
            this.rd_CodeBar.Location = new System.Drawing.Point(25, 253);
            this.rd_CodeBar.Name = "rd_CodeBar";
            this.rd_CodeBar.Size = new System.Drawing.Size(150, 31);
            this.rd_CodeBar.TabIndex = 10;
            this.rd_CodeBar.Text = "بيع بالكود بار";
            this.rd_CodeBar.UseVisualStyleBackColor = true;
            this.rd_CodeBar.CheckedChanged += new System.EventHandler(this.rd_CodeBar_CheckedChanged);
            // 
            // rd_Manuel
            // 
            this.rd_Manuel.AutoSize = true;
            this.rd_Manuel.Checked = true;
            this.rd_Manuel.Location = new System.Drawing.Point(184, 253);
            this.rd_Manuel.Name = "rd_Manuel";
            this.rd_Manuel.Size = new System.Drawing.Size(141, 31);
            this.rd_Manuel.TabIndex = 11;
            this.rd_Manuel.TabStop = true;
            this.rd_Manuel.Text = "ادخال يدوي";
            this.rd_Manuel.UseVisualStyleBackColor = true;
            this.rd_Manuel.CheckedChanged += new System.EventHandler(this.rd_Manuel_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.rd_Manuel);
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Controls.Add(this.btSave);
            this.panel3.Controls.Add(this.rd_CodeBar);
            this.panel3.Controls.Add(this.btnSavePrint);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 613);
            this.panel3.TabIndex = 12;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(227, 553);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(79, 46);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Controls.Add(this.lblInvoiceTitle);
            this.panel4.Controls.Add(this.DGVInvoice);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(342, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1063, 613);
            this.panel4.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PRINT_INVOICE.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(20, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.label14);
            this.flowLayoutPanel1.Controls.Add(this.txtCode);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.cmbItem);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.txtPrice);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.txtQty);
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 212);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1051, 62);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1410, 623);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmInvoice";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInvoice)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btnSavePrint;
        private System.Windows.Forms.RadioButton rd_CodeBar;
        private System.Windows.Forms.RadioButton rd_Manuel;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTaxP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label lblInvoiceTitle;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Button btnCustAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNew;
    }
}

