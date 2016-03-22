namespace introse_project.sub_windows.Purchase_Order
{
    partial class addCPO
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateIssuedCBox = new System.Windows.Forms.DateTimePicker();
            this.customerNameCBox = new System.Windows.Forms.ComboBox();
            this.dateExpectedCBox = new System.Windows.Forms.DateTimePicker();
            this.addCPOBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cPONumberTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Expected Delivery Date\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date Issued";
            // 
            // dateIssuedCBox
            // 
            this.dateIssuedCBox.Location = new System.Drawing.Point(6, 163);
            this.dateIssuedCBox.Name = "dateIssuedCBox";
            this.dateIssuedCBox.Size = new System.Drawing.Size(186, 20);
            this.dateIssuedCBox.TabIndex = 11;
            // 
            // customerNameCBox
            // 
            this.customerNameCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerNameCBox.FormattingEnabled = true;
            this.customerNameCBox.Location = new System.Drawing.Point(6, 105);
            this.customerNameCBox.Name = "customerNameCBox";
            this.customerNameCBox.Size = new System.Drawing.Size(183, 21);
            this.customerNameCBox.TabIndex = 12;
            // 
            // dateExpectedCBox
            // 
            this.dateExpectedCBox.Location = new System.Drawing.Point(8, 229);
            this.dateExpectedCBox.Name = "dateExpectedCBox";
            this.dateExpectedCBox.Size = new System.Drawing.Size(186, 20);
            this.dateExpectedCBox.TabIndex = 13;
            // 
            // addCPOBtn
            // 
            this.addCPOBtn.Location = new System.Drawing.Point(88, 347);
            this.addCPOBtn.Name = "addCPOBtn";
            this.addCPOBtn.Size = new System.Drawing.Size(127, 23);
            this.addCPOBtn.TabIndex = 15;
            this.addCPOBtn.Text = "Add Purchase Order";
            this.addCPOBtn.UseVisualStyleBackColor = true;
            this.addCPOBtn.Click += new System.EventHandler(this.addCPOBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cPONumberTxtBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.customerNameCBox);
            this.groupBox1.Controls.Add(this.dateIssuedCBox);
            this.groupBox1.Controls.Add(this.dateExpectedCBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 329);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Purchase Order Number";
            // 
            // cPONumberTxtBox
            // 
            this.cPONumberTxtBox.Location = new System.Drawing.Point(8, 47);
            this.cPONumberTxtBox.MaxLength = 40;
            this.cPONumberTxtBox.Name = "cPONumberTxtBox";
            this.cPONumberTxtBox.Size = new System.Drawing.Size(181, 20);
            this.cPONumberTxtBox.TabIndex = 14;
            // 
            // addCPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 382);
            this.Controls.Add(this.addCPOBtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "addCPO";
            this.Text = "Add Customer Purchase Order";
            this.Load += new System.EventHandler(this.addCPO_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateIssuedCBox;
        private System.Windows.Forms.ComboBox customerNameCBox;
        private System.Windows.Forms.DateTimePicker dateExpectedCBox;
        private System.Windows.Forms.Button addCPOBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cPONumberTxtBox;

    }
}