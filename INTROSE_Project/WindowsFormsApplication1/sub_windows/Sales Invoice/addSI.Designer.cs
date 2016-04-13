namespace introse_project.sub_windows.Sales_Invoice
{
    partial class addSI
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
            this.dateIssuedCBox = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deliveryReceiptIDCBox = new System.Windows.Forms.ComboBox();
            this.addSIBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customerPONumberTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.invoiceNumberTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateIssuedCBox
            // 
            this.dateIssuedCBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateIssuedCBox.Location = new System.Drawing.Point(6, 202);
            this.dateIssuedCBox.Name = "dateIssuedCBox";
            this.dateIssuedCBox.Size = new System.Drawing.Size(266, 20);
            this.dateIssuedCBox.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Customer Purchase Order Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delivery Receipt Number";
            // 
            // deliveryReceiptIDCBox
            // 
            this.deliveryReceiptIDCBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deliveryReceiptIDCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deliveryReceiptIDCBox.FormattingEnabled = true;
            this.deliveryReceiptIDCBox.Location = new System.Drawing.Point(6, 96);
            this.deliveryReceiptIDCBox.Name = "deliveryReceiptIDCBox";
            this.deliveryReceiptIDCBox.Size = new System.Drawing.Size(266, 21);
            this.deliveryReceiptIDCBox.TabIndex = 22;
            this.deliveryReceiptIDCBox.SelectedIndexChanged += new System.EventHandler(this.deliveryReceiptIDCBox_SelectedIndexChanged);
            // 
            // addSIBtn
            // 
            this.addSIBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addSIBtn.Location = new System.Drawing.Point(145, 246);
            this.addSIBtn.Name = "addSIBtn";
            this.addSIBtn.Size = new System.Drawing.Size(127, 20);
            this.addSIBtn.TabIndex = 23;
            this.addSIBtn.Text = "Add Sales Invoice";
            this.addSIBtn.UseVisualStyleBackColor = true;
            this.addSIBtn.Click += new System.EventHandler(this.addSIBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.invoiceNumberTxtBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.deliveryReceiptIDCBox);
            this.groupBox1.Controls.Add(this.customerPONumberTxtBox);
            this.groupBox1.Controls.Add(this.addSIBtn);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateIssuedCBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 272);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delivery Information";
            // 
            // customerPONumberTxtBox
            // 
            this.customerPONumberTxtBox.Location = new System.Drawing.Point(7, 153);
            this.customerPONumberTxtBox.Name = "customerPONumberTxtBox";
            this.customerPONumberTxtBox.ReadOnly = true;
            this.customerPONumberTxtBox.Size = new System.Drawing.Size(265, 20);
            this.customerPONumberTxtBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date Received";
            // 
            // invoiceNumberTxtBox
            // 
            this.invoiceNumberTxtBox.Location = new System.Drawing.Point(7, 47);
            this.invoiceNumberTxtBox.Name = "invoiceNumberTxtBox";
            this.invoiceNumberTxtBox.Size = new System.Drawing.Size(265, 20);
            this.invoiceNumberTxtBox.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Invoice Number";
            // 
            // addSI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 296);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "addSI";
            this.Text = "Add Sales Invoice";
            this.Load += new System.EventHandler(this.addSI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateIssuedCBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox deliveryReceiptIDCBox;
        private System.Windows.Forms.Button addSIBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerPONumberTxtBox;
        private System.Windows.Forms.TextBox invoiceNumberTxtBox;
        private System.Windows.Forms.Label label3;
    }
}