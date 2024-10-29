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
            this.btnSales = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnbtnVendor = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnbelList = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(433, 15);
            this.btnSales.Margin = new System.Windows.Forms.Padding(5);
            this.btnSales.Name = "btnSales";
            this.btnSales.Padding = new System.Windows.Forms.Padding(2);
            this.btnSales.Size = new System.Drawing.Size(203, 123);
            this.btnSales.TabIndex = 0;
            this.btnSales.Text = "فاتورة بيع";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnItem
            // 
            this.btnItem.Location = new System.Drawing.Point(220, 15);
            this.btnItem.Margin = new System.Windows.Forms.Padding(5);
            this.btnItem.Name = "btnItem";
            this.btnItem.Padding = new System.Windows.Forms.Padding(2);
            this.btnItem.Size = new System.Drawing.Size(203, 123);
            this.btnItem.TabIndex = 1;
            this.btnItem.Text = "المنتجات";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(646, 15);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Padding = new System.Windows.Forms.Padding(2);
            this.btnBuy.Size = new System.Drawing.Size(203, 123);
            this.btnBuy.TabIndex = 0;
            this.btnBuy.Text = "فاتورة شراء";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnbtnVendor
            // 
            this.btnbtnVendor.Location = new System.Drawing.Point(646, 148);
            this.btnbtnVendor.Margin = new System.Windows.Forms.Padding(5);
            this.btnbtnVendor.Name = "btnbtnVendor";
            this.btnbtnVendor.Padding = new System.Windows.Forms.Padding(2);
            this.btnbtnVendor.Size = new System.Drawing.Size(203, 123);
            this.btnbtnVendor.TabIndex = 2;
            this.btnbtnVendor.Text = "الموردون";
            this.btnbtnVendor.UseVisualStyleBackColor = true;
            this.btnbtnVendor.Click += new System.EventHandler(this.btnbtnVendor_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(7, 15);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(2);
            this.btnCustomer.Size = new System.Drawing.Size(203, 123);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "العملاء";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnBuy);
            this.flowLayoutPanel1.Controls.Add(this.btnSales);
            this.flowLayoutPanel1.Controls.Add(this.btnItem);
            this.flowLayoutPanel1.Controls.Add(this.btnCustomer);
            this.flowLayoutPanel1.Controls.Add(this.btnbtnVendor);
            this.flowLayoutPanel1.Controls.Add(this.btnbelList);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(874, 438);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnbelList
            // 
            this.btnbelList.Location = new System.Drawing.Point(433, 148);
            this.btnbelList.Margin = new System.Windows.Forms.Padding(5);
            this.btnbelList.Name = "btnbelList";
            this.btnbelList.Padding = new System.Windows.Forms.Padding(2);
            this.btnbelList.Size = new System.Drawing.Size(203, 123);
            this.btnbelList.TabIndex = 2;
            this.btnbelList.Text = "قائمة الفواتير";
            this.btnbelList.UseVisualStyleBackColor = true;
            this.btnbelList.Click += new System.EventHandler(this.btnbelList_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 458);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "main";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnbtnVendor;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnbelList;
    }
}