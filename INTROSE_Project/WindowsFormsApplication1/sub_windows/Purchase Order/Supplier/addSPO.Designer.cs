namespace introse_project.sub_windows.Purchase_Order.Supplier
{
    partial class addSPO
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
            this.addSPOBtn = new System.Windows.Forms.Button();
            this.dateExpectedCBox = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.supplierNameCBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sPONumberTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.customerPONumberCBox = new System.Windows.Forms.ComboBox();
            this.dateIssuedCBox = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addSPOBtn
            // 
            this.addSPOBtn.Location = new System.Drawing.Point(159, 347);
            this.addSPOBtn.Name = "addSPOBtn";
            this.addSPOBtn.Size = new System.Drawing.Size(127, 23);
            this.addSPOBtn.TabIndex = 19;
            this.addSPOBtn.Text = "Add Purchase Order";
            this.addSPOBtn.UseVisualStyleBackColor = true;
            this.addSPOBtn.Click += new System.EventHandler(this.addSPOBtn_Click);
            // 
            // dateExpectedCBox
            // 
            this.dateExpectedCBox.Location = new System.Drawing.Point(6, 274);
            this.dateExpectedCBox.Name = "dateExpectedCBox";
            this.dateExpectedCBox.Size = new System.Drawing.Size(262, 20);
            this.dateExpectedCBox.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.supplierNameCBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.sPONumberTxtBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.customerPONumberCBox);
            this.groupBox1.Controls.Add(this.dateIssuedCBox);
            this.groupBox1.Controls.Add(this.dateExpectedCBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 329);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier Information";
            // 
            // supplierNameCBox
            // 
            this.supplierNameCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierNameCBox.FormattingEnabled = true;
            this.supplierNameCBox.Location = new System.Drawing.Point(6, 155);
            this.supplierNameCBox.Name = "supplierNameCBox";
            this.supplierNameCBox.Size = new System.Drawing.Size(260, 21);
            this.supplierNameCBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Supplier Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Purchase Order Number";
            // 
            // sPONumberTxtBox
            // 
            this.sPONumberTxtBox.Location = new System.Drawing.Point(6, 39);
            this.sPONumberTxtBox.MaxLength = 40;
            this.sPONumberTxtBox.Name = "sPONumberTxtBox";
            this.sPONumberTxtBox.Size = new System.Drawing.Size(260, 20);
            this.sPONumberTxtBox.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Customer PO Number";
            // 
            // customerPONumberCBox
            // 
            this.customerPONumberCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerPONumberCBox.FormattingEnabled = true;
            this.customerPONumberCBox.Location = new System.Drawing.Point(6, 92);
            this.customerPONumberCBox.Name = "customerPONumberCBox";
            this.customerPONumberCBox.Size = new System.Drawing.Size(262, 21);
            this.customerPONumberCBox.TabIndex = 20;
            this.customerPONumberCBox.SelectedIndexChanged += new System.EventHandler(this.customerPOIdCBox_SelectedIndexChanged);
            // 
            // dateIssuedCBox
            // 
            this.dateIssuedCBox.Location = new System.Drawing.Point(6, 213);
            this.dateIssuedCBox.Name = "dateIssuedCBox";
            this.dateIssuedCBox.Size = new System.Drawing.Size(262, 20);
            this.dateIssuedCBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date Issued";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Expected Delivery Date\r\n";
            // 
            // addSPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 382);
            this.Controls.Add(this.addSPOBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "addSPO";
            this.Text = "Add Supplier Purchase Order";
            this.Load += new System.EventHandler(this.addSPO_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addSPOBtn;
        private System.Windows.Forms.DateTimePicker dateExpectedCBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateIssuedCBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox customerPONumberCBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sPONumberTxtBox;
        private System.Windows.Forms.ComboBox supplierNameCBox;
        private System.Windows.Forms.Label label1;
    }
}