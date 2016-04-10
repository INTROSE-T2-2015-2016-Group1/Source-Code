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
            this.label8 = new System.Windows.Forms.Label();
            this.supplierPOIdCBox = new System.Windows.Forms.ComboBox();
            this.dateReceivedCBox = new System.Windows.Forms.DateTimePicker();
            this.addDRBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deliveryReceiptNumberTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Supplier PO Number";
            // 
            // supplierPOIdCBox
            // 
            this.supplierPOIdCBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.supplierPOIdCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierPOIdCBox.FormattingEnabled = true;
            this.supplierPOIdCBox.Location = new System.Drawing.Point(9, 113);
            this.supplierPOIdCBox.Name = "supplierPOIdCBox";
            this.supplierPOIdCBox.Size = new System.Drawing.Size(263, 21);
            this.supplierPOIdCBox.TabIndex = 20;
            // 
            // dateReceivedCBox
            // 
            this.dateReceivedCBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateReceivedCBox.Location = new System.Drawing.Point(9, 176);
            this.dateReceivedCBox.Name = "dateReceivedCBox";
            this.dateReceivedCBox.Size = new System.Drawing.Size(263, 20);
            this.dateReceivedCBox.TabIndex = 11;
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
            this.addDRBtn.Click += new System.EventHandler(this.addDRBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.deliveryReceiptNumberTxtBox);
            this.groupBox1.Controls.Add(this.addDRBtn);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.supplierPOIdCBox);
            this.groupBox1.Controls.Add(this.dateReceivedCBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 272);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delivery Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Delivery Receipt Number";
            // 
            // deliveryReceiptNumberTxtBox
            // 
            this.deliveryReceiptNumberTxtBox.Location = new System.Drawing.Point(9, 55);
            this.deliveryReceiptNumberTxtBox.Name = "deliveryReceiptNumberTxtBox";
            this.deliveryReceiptNumberTxtBox.Size = new System.Drawing.Size(263, 20);
            this.deliveryReceiptNumberTxtBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 160);
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
            this.Load += new System.EventHandler(this.addDR_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox supplierPOIdCBox;
        private System.Windows.Forms.DateTimePicker dateReceivedCBox;
        private System.Windows.Forms.Button addDRBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deliveryReceiptNumberTxtBox;
    }
}