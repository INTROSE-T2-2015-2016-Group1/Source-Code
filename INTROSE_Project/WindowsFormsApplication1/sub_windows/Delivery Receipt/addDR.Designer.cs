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
            this.itemNumCBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemNumCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemNumCBox.FormattingEnabled = true;
            this.itemNumCBox.Location = new System.Drawing.Point(9, 103);
            this.itemNumCBox.Name = "itemNumCBox";
            this.itemNumCBox.Size = new System.Drawing.Size(263, 21);
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
            this.supplierPOIdCBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.supplierPOIdCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierPOIdCBox.FormattingEnabled = true;
            this.supplierPOIdCBox.Location = new System.Drawing.Point(9, 44);
            this.supplierPOIdCBox.Name = "supplierPOIdCBox";
            this.supplierPOIdCBox.Size = new System.Drawing.Size(263, 21);
            this.supplierPOIdCBox.TabIndex = 20;
            // 
            // dateIssuedCBox
            // 
            this.dateIssuedCBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateIssuedCBox.Location = new System.Drawing.Point(9, 161);
            this.dateIssuedCBox.Name = "dateIssuedCBox";
            this.dateIssuedCBox.Size = new System.Drawing.Size(263, 20);
            this.dateIssuedCBox.TabIndex = 11;
            // 
            // addDRBtn
            // 
            this.addDRBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addDRBtn.Location = new System.Drawing.Point(145, 221);
            this.addDRBtn.Name = "addDRBtn";
            this.addDRBtn.Size = new System.Drawing.Size(127, 20);
            this.addDRBtn.TabIndex = 23;
            this.addDRBtn.Text = "Add Delivery Receipt";
            this.addDRBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.addDRBtn);
            this.groupBox1.Controls.Add(this.itemNumCBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.supplierPOIdCBox);
            this.groupBox1.Controls.Add(this.dateIssuedCBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 272);
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
            // addDR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 296);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}