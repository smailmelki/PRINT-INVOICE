namespace PRINT_INVOICE
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            this.PnlMainIcon = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCollebs = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.LogoPictor = new System.Windows.Forms.PictureBox();
            this.btnItem = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnbtnVendor = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnbelList = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PnlMainIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictor)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMainIcon
            // 
            this.PnlMainIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlMainIcon.Controls.Add(this.btnCollebs);
            this.PnlMainIcon.Controls.Add(this.lblUserName);
            this.PnlMainIcon.Controls.Add(this.LogoPictor);
            this.PnlMainIcon.Controls.Add(this.btnItem);
            this.PnlMainIcon.Controls.Add(this.btnCustomer);
            this.PnlMainIcon.Controls.Add(this.btnbtnVendor);
            this.PnlMainIcon.Controls.Add(this.btnBuy);
            this.PnlMainIcon.Controls.Add(this.btnSales);
            this.PnlMainIcon.Controls.Add(this.btnbelList);
            this.PnlMainIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlMainIcon.Location = new System.Drawing.Point(1106, 20);
            this.PnlMainIcon.Name = "PnlMainIcon";
            this.PnlMainIcon.Padding = new System.Windows.Forms.Padding(5);
            this.PnlMainIcon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PnlMainIcon.Size = new System.Drawing.Size(230, 612);
            this.PnlMainIcon.TabIndex = 3;
            // 
            // btnCollebs
            // 
            this.btnCollebs.Image = global::PRINT_INVOICE.Properties.Resources.collabseIcon;
            this.btnCollebs.Location = new System.Drawing.Point(148, 8);
            this.btnCollebs.Name = "btnCollebs";
            this.btnCollebs.Size = new System.Drawing.Size(67, 45);
            this.btnCollebs.TabIndex = 5;
            this.btnCollebs.UseVisualStyleBackColor = true;
            this.btnCollebs.Click += new System.EventHandler(this.btnCollebs_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(21, 5);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(121, 37);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "UserName";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogoPictor
            // 
            this.LogoPictor.Image = global::PRINT_INVOICE.Properties.Resources.logo;
            this.LogoPictor.Location = new System.Drawing.Point(10, 59);
            this.LogoPictor.Name = "LogoPictor";
            this.LogoPictor.Size = new System.Drawing.Size(205, 133);
            this.LogoPictor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictor.TabIndex = 3;
            this.LogoPictor.TabStop = false;
            // 
            // btnItem
            // 
            this.btnItem.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnItem.Image = global::PRINT_INVOICE.Properties.Resources.productIcon2;
            this.btnItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItem.Location = new System.Drawing.Point(14, 200);
            this.btnItem.Margin = new System.Windows.Forms.Padding(5);
            this.btnItem.Name = "btnItem";
            this.btnItem.Padding = new System.Windows.Forms.Padding(2);
            this.btnItem.Size = new System.Drawing.Size(199, 55);
            this.btnItem.TabIndex = 1;
            this.btnItem.Text = "المنتجات";
            this.btnItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnItem, "المنتجات");
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnCustomer.Image = global::PRINT_INVOICE.Properties.Resources.clientIcon;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(14, 265);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(2);
            this.btnCustomer.Size = new System.Drawing.Size(199, 55);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "العملاء";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnCustomer, "العملاء");
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnbtnVendor
            // 
            this.btnbtnVendor.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnbtnVendor.Image = global::PRINT_INVOICE.Properties.Resources.supplire;
            this.btnbtnVendor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbtnVendor.Location = new System.Drawing.Point(14, 330);
            this.btnbtnVendor.Margin = new System.Windows.Forms.Padding(5);
            this.btnbtnVendor.Name = "btnbtnVendor";
            this.btnbtnVendor.Padding = new System.Windows.Forms.Padding(2);
            this.btnbtnVendor.Size = new System.Drawing.Size(199, 55);
            this.btnbtnVendor.TabIndex = 2;
            this.btnbtnVendor.Text = "الموردون";
            this.btnbtnVendor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnbtnVendor, "الموردون");
            this.btnbtnVendor.UseVisualStyleBackColor = true;
            this.btnbtnVendor.Click += new System.EventHandler(this.btnbtnVendor_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnBuy.Image = global::PRINT_INVOICE.Properties.Resources.invoice;
            this.btnBuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuy.Location = new System.Drawing.Point(14, 395);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Padding = new System.Windows.Forms.Padding(2);
            this.btnBuy.Size = new System.Drawing.Size(199, 55);
            this.btnBuy.TabIndex = 0;
            this.btnBuy.Text = "فاتورة شراء";
            this.btnBuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnBuy, "فاتورة شراء");
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnSales
            // 
            this.btnSales.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnSales.Image = global::PRINT_INVOICE.Properties.Resources.inviceIcon;
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(14, 460);
            this.btnSales.Margin = new System.Windows.Forms.Padding(5);
            this.btnSales.Name = "btnSales";
            this.btnSales.Padding = new System.Windows.Forms.Padding(2);
            this.btnSales.Size = new System.Drawing.Size(199, 55);
            this.btnSales.TabIndex = 0;
            this.btnSales.Text = "فاتورة بيع";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnSales, "فاتورة بيع");
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnbelList
            // 
            this.btnbelList.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnbelList.Image = global::PRINT_INVOICE.Properties.Resources.invoicesListIcon;
            this.btnbelList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbelList.Location = new System.Drawing.Point(14, 525);
            this.btnbelList.Margin = new System.Windows.Forms.Padding(5);
            this.btnbelList.Name = "btnbelList";
            this.btnbelList.Padding = new System.Windows.Forms.Padding(2);
            this.btnbelList.Size = new System.Drawing.Size(199, 55);
            this.btnbelList.TabIndex = 2;
            this.btnbelList.Text = "قائمة الفواتير";
            this.btnbelList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnbelList, "قائمة الفواتير");
            this.btnbelList.UseVisualStyleBackColor = true;
            this.btnbelList.Click += new System.EventHandler(this.btnbelList_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(20, 20);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1086, 612);
            this.pnlContainer.TabIndex = 4;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 652);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.PnlMainIcon);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "main";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_FormClosed);
            this.Load += new System.EventHandler(this.main_Load);
            this.PnlMainIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnbtnVendor;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.FlowLayoutPanel PnlMainIcon;
        private System.Windows.Forms.Button btnbelList;
        public System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.PictureBox LogoPictor;
        private System.Windows.Forms.Button btnCollebs;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}