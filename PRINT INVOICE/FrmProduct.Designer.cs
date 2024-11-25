namespace PRINT_INVOICE
{
    partial class FrmProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuy = new System.Windows.Forms.TextBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBrows = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSale = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cheIsActive = new System.Windows.Forms.CheckBox();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "كود الصنف :";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(169, 33);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(201, 42);
            this.txtCode.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "اسم الصنف :";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(169, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(201, 42);
            this.txtName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "سعر الشراء :";
            // 
            // txtBuy
            // 
            this.txtBuy.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuy.Location = new System.Drawing.Point(169, 129);
            this.txtBuy.Name = "txtBuy";
            this.txtBuy.Size = new System.Drawing.Size(201, 42);
            this.txtBuy.TabIndex = 2;
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(399, 33);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(193, 179);
            this.picImage.TabIndex = 2;
            this.picImage.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(252, 306);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 55);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(423, 306);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 55);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBrows
            // 
            this.btnBrows.Location = new System.Drawing.Point(399, 218);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(193, 40);
            this.btnBrows.TabIndex = 5;
            this.btnBrows.Text = "تصفح";
            this.btnBrows.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "صنف متوفر :";
            // 
            // txtSale
            // 
            this.txtSale.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSale.Location = new System.Drawing.Point(169, 179);
            this.txtSale.Name = "txtSale";
            this.txtSale.Size = new System.Drawing.Size(201, 42);
            this.txtSale.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 35);
            this.label5.TabIndex = 7;
            this.label5.Text = "سعر البيع :";
            // 
            // cheIsActive
            // 
            this.cheIsActive.AutoSize = true;
            this.cheIsActive.Location = new System.Drawing.Point(216, 230);
            this.cheIsActive.Name = "cheIsActive";
            this.cheIsActive.Size = new System.Drawing.Size(90, 33);
            this.cheIsActive.TabIndex = 4;
            this.cheIsActive.Text = "متوفر";
            this.cheIsActive.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(86, 306);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(118, 55);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(618, 397);
            this.Controls.Add(this.cheIsActive);
            this.Controls.Add(this.txtSale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBrows);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.txtBuy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 453);
            this.MinimumSize = new System.Drawing.Size(640, 453);
            this.Name = "FrmProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "منتج جديد";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBrows;
        public System.Windows.Forms.TextBox txtCode;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtBuy;
        public System.Windows.Forms.PictureBox picImage;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtSale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cheIsActive;
        public System.Windows.Forms.Button btnNew;
    }
}