namespace introse_project.sub_windows.Sales_Invoice
{
    partial class updateSI
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
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.customerPOIdCBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateIssuedCBox = new System.Windows.Forms.DateTimePicker();
            this.deliveryReceiptIDCBox = new System.Windows.Forms.ComboBox();
            this.updateSIBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currencyCBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.invoiceTotalPriceTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sales Invoice Total Price\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Customer Purchase Order ID\r\n";
            // 
            // customerPOIdCBox
            // 
            this.customerPOIdCBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerPOIdCBox.FormattingEnabled = true;
            this.customerPOIdCBox.Location = new System.Drawing.Point(6, 103);
            this.customerPOIdCBox.Name = "customerPOIdCBox";
            this.customerPOIdCBox.Size = new System.Drawing.Size(224, 21);
            this.customerPOIdCBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delivery Receipt ID\r\n";
            // 
            // dateIssuedCBox
            // 
            this.dateIssuedCBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateIssuedCBox.Location = new System.Drawing.Point(6, 163);
            this.dateIssuedCBox.Name = "dateIssuedCBox";
            this.dateIssuedCBox.Size = new System.Drawing.Size(224, 20);
            this.dateIssuedCBox.TabIndex = 11;
            // 
            // deliveryReceiptIDCBox
            // 
            this.deliveryReceiptIDCBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deliveryReceiptIDCBox.FormattingEnabled = true;
            this.deliveryReceiptIDCBox.Location = new System.Drawing.Point(18, 58);
            this.deliveryReceiptIDCBox.Name = "deliveryReceiptIDCBox";
            this.deliveryReceiptIDCBox.Size = new System.Drawing.Size(224, 21);
            this.deliveryReceiptIDCBox.TabIndex = 25;
            // 
            // updateSIBtn
            // 
            this.updateSIBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateSIBtn.Location = new System.Drawing.Point(128, 344);
            this.updateSIBtn.Name = "updateSIBtn";
            this.updateSIBtn.Size = new System.Drawing.Size(127, 20);
            this.updateSIBtn.TabIndex = 23;
            this.updateSIBtn.Text = "Update Sales Invoice";
            this.updateSIBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.currencyCBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.invoiceTotalPriceTxtBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.updateSIBtn);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.customerPOIdCBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateIssuedCBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 387);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delivery Information";
            // 
            // currencyCBox
            // 
            this.currencyCBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currencyCBox.FormattingEnabled = true;
            this.currencyCBox.Location = new System.Drawing.Point(6, 293);
            this.currencyCBox.Name = "currencyCBox";
            this.currencyCBox.Size = new System.Drawing.Size(224, 21);
            this.currencyCBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Currency";
            // 
            // invoiceTotalPriceTxtBox
            // 
            this.invoiceTotalPriceTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invoiceTotalPriceTxtBox.Location = new System.Drawing.Point(7, 232);
            this.invoiceTotalPriceTxtBox.Name = "invoiceTotalPriceTxtBox";
            this.invoiceTotalPriceTxtBox.Size = new System.Drawing.Size(223, 20);
            this.invoiceTotalPriceTxtBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date Received";
            // 
            // updateSI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 411);
            this.Controls.Add(this.deliveryReceiptIDCBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "updateSI";
            this.Text = "Update Sales Invoice";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox customerPOIdCBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateIssuedCBox;
        private System.Windows.Forms.ComboBox deliveryReceiptIDCBox;
        private System.Windows.Forms.Button updateSIBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox currencyCBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox invoiceTotalPriceTxtBox;
        private System.Windows.Forms.Label label2;

    }
}