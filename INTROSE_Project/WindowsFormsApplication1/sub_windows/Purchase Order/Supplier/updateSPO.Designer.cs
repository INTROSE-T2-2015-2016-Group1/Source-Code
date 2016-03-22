namespace introse_project.sub_windows.Purchase_Order.Supplier
{
    partial class updateSPO
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
            this.updateSPOBtn = new System.Windows.Forms.Button();
            this.supplierNameCBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateExpectedCBox = new System.Windows.Forms.DateTimePicker();
            this.dateIssuedCBox = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.customerPOIdCBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateSPOBtn
            // 
            this.updateSPOBtn.Location = new System.Drawing.Point(159, 347);
            this.updateSPOBtn.Name = "updateSPOBtn";
            this.updateSPOBtn.Size = new System.Drawing.Size(127, 23);
            this.updateSPOBtn.TabIndex = 23;
            this.updateSPOBtn.Text = "Update Purchase Order";
            this.updateSPOBtn.UseVisualStyleBackColor = true;
            // 
            // supplierNameCBox
            // 
            this.supplierNameCBox.FormattingEnabled = true;
            this.supplierNameCBox.Location = new System.Drawing.Point(18, 58);
            this.supplierNameCBox.Name = "supplierNameCBox";
            this.supplierNameCBox.Size = new System.Drawing.Size(262, 21);
            this.supplierNameCBox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Expected Delivery Date\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date Issued";
            // 
            // dateExpectedCBox
            // 
            this.dateExpectedCBox.Location = new System.Drawing.Point(6, 230);
            this.dateExpectedCBox.Name = "dateExpectedCBox";
            this.dateExpectedCBox.Size = new System.Drawing.Size(265, 20);
            this.dateExpectedCBox.TabIndex = 13;
            // 
            // dateIssuedCBox
            // 
            this.dateIssuedCBox.Location = new System.Drawing.Point(6, 169);
            this.dateIssuedCBox.Name = "dateIssuedCBox";
            this.dateIssuedCBox.Size = new System.Drawing.Size(265, 20);
            this.dateIssuedCBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier Name";
            // 
            // customerPOIdCBox
            // 
            this.customerPOIdCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerPOIdCBox.FormattingEnabled = true;
            this.customerPOIdCBox.Location = new System.Drawing.Point(6, 103);
            this.customerPOIdCBox.Name = "customerPOIdCBox";
            this.customerPOIdCBox.Size = new System.Drawing.Size(262, 21);
            this.customerPOIdCBox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Customer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.customerPOIdCBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateIssuedCBox);
            this.groupBox1.Controls.Add(this.dateExpectedCBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 292);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier Information";
            // 
            // updateSPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 382);
            this.Controls.Add(this.supplierNameCBox);
            this.Controls.Add(this.updateSPOBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "updateSPO";
            this.Text = "Update Supplier Purchase Order";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateSPOBtn;
        private System.Windows.Forms.ComboBox supplierNameCBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateExpectedCBox;
        private System.Windows.Forms.DateTimePicker dateIssuedCBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox customerPOIdCBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}