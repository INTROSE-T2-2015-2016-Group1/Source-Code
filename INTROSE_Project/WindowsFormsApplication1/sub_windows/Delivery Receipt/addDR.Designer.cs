namespace introse_project.sub_windows.Delivery_Receipt
{
    partial class addDR
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
            this.itemNumCBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.supplierPOIdCBox = new System.Windows.Forms.ComboBox();
            this.dateIssuedCBox = new System.Windows.Forms.DateTimePicker();
            this.addDRBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deliveredQtyTxtBox = new System.Windows.Forms.TextBox();
            this.approvedQtyTxtBox = new System.Windows.Forms.TextBox();
            this.rejectedQtyTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Item Number";
            // 
            // itemNumCBox
            // 
            this.itemNumCBox.FormattingEnabled = true;
            this.itemNumCBox.Location = new System.Drawing.Point(9, 103);
            this.itemNumCBox.Name = "itemNumCBox";
            this.itemNumCBox.Size = new System.Drawing.Size(183, 21);
            this.itemNumCBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Supplier Purchase Order ID\r\n";
            // 
            // supplierPOIdCBox
            // 
            this.supplierPOIdCBox.FormattingEnabled = true;
            this.supplierPOIdCBox.Location = new System.Drawing.Point(9, 44);
            this.supplierPOIdCBox.Name = "supplierPOIdCBox";
            this.supplierPOIdCBox.Size = new System.Drawing.Size(183, 21);
            this.supplierPOIdCBox.TabIndex = 20;
            // 
            // dateIssuedCBox
            // 
            this.dateIssuedCBox.Location = new System.Drawing.Point(9, 161);
            this.dateIssuedCBox.Name = "dateIssuedCBox";
            this.dateIssuedCBox.Size = new System.Drawing.Size(186, 20);
            this.dateIssuedCBox.TabIndex = 11;
            // 
            // addDRBtn
            // 
            this.addDRBtn.Location = new System.Drawing.Point(237, 221);
            this.addDRBtn.Name = "addDRBtn";
            this.addDRBtn.Size = new System.Drawing.Size(127, 20);
            this.addDRBtn.TabIndex = 23;
            this.addDRBtn.Text = "Add Delivery Receipt";
            this.addDRBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rejectedQtyTxtBox);
            this.groupBox1.Controls.Add(this.approvedQtyTxtBox);
            this.groupBox1.Controls.Add(this.deliveredQtyTxtBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.addDRBtn);
            this.groupBox1.Controls.Add(this.itemNumCBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.supplierPOIdCBox);
            this.groupBox1.Controls.Add(this.dateIssuedCBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 272);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delivery Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date Received";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Delivered Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Approved Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Rejected Quantity";
            // 
            // deliveredQtyTxtBox
            // 
            this.deliveredQtyTxtBox.Location = new System.Drawing.Point(224, 44);
            this.deliveredQtyTxtBox.Name = "deliveredQtyTxtBox";
            this.deliveredQtyTxtBox.Size = new System.Drawing.Size(100, 20);
            this.deliveredQtyTxtBox.TabIndex = 27;
            // 
            // approvedQtyTxtBox
            // 
            this.approvedQtyTxtBox.Location = new System.Drawing.Point(224, 104);
            this.approvedQtyTxtBox.Name = "approvedQtyTxtBox";
            this.approvedQtyTxtBox.Size = new System.Drawing.Size(100, 20);
            this.approvedQtyTxtBox.TabIndex = 28;
            // 
            // rejectedQtyTxtBox
            // 
            this.rejectedQtyTxtBox.Location = new System.Drawing.Point(224, 164);
            this.rejectedQtyTxtBox.Name = "rejectedQtyTxtBox";
            this.rejectedQtyTxtBox.Size = new System.Drawing.Size(100, 20);
            this.rejectedQtyTxtBox.TabIndex = 29;
            // 
            // addDR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 296);
            this.Controls.Add(this.groupBox1);
            this.Name = "addDR";
            this.Text = "Add Delivery Receipt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox itemNumCBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox supplierPOIdCBox;
        private System.Windows.Forms.DateTimePicker dateIssuedCBox;
        private System.Windows.Forms.Button addDRBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rejectedQtyTxtBox;
        private System.Windows.Forms.TextBox approvedQtyTxtBox;
        private System.Windows.Forms.TextBox deliveredQtyTxtBox;
    }
}