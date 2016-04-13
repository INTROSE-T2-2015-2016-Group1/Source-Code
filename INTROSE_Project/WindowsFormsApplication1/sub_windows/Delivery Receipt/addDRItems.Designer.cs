namespace introse_project.sub_windows.Delivery_Receipt
{
    partial class addDRItems
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quantityReceivedTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.supplierOrderedItemCBox = new System.Windows.Forms.ComboBox();
            this.addDRBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.quantityReceivedTxtBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.supplierOrderedItemCBox);
            this.groupBox1.Controls.Add(this.addDRBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 272);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Delivered Quantity";
            // 
            // quantityReceivedTxtBox
            // 
            this.quantityReceivedTxtBox.Location = new System.Drawing.Point(9, 103);
            this.quantityReceivedTxtBox.Name = "quantityReceivedTxtBox";
            this.quantityReceivedTxtBox.Size = new System.Drawing.Size(263, 20);
            this.quantityReceivedTxtBox.TabIndex = 30;
            this.quantityReceivedTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityReceivedTxtBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Item Delivered";
            // 
            // supplierOrderedItemCBox
            // 
            this.supplierOrderedItemCBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.supplierOrderedItemCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierOrderedItemCBox.FormattingEnabled = true;
            this.supplierOrderedItemCBox.Location = new System.Drawing.Point(9, 46);
            this.supplierOrderedItemCBox.Name = "supplierOrderedItemCBox";
            this.supplierOrderedItemCBox.Size = new System.Drawing.Size(263, 21);
            this.supplierOrderedItemCBox.TabIndex = 28;
            // 
            // addDRBtn
            // 
            this.addDRBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addDRBtn.Location = new System.Drawing.Point(145, 218);
            this.addDRBtn.Name = "addDRBtn";
            this.addDRBtn.Size = new System.Drawing.Size(127, 20);
            this.addDRBtn.TabIndex = 23;
            this.addDRBtn.Text = "Add Item";
            this.addDRBtn.UseVisualStyleBackColor = true;
            this.addDRBtn.Click += new System.EventHandler(this.addDRBtn_Click);
            // 
            // addDRItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 296);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "addDRItems";
            this.Text = "Add Items";
            this.Load += new System.EventHandler(this.addDRItems_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addDRBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox supplierOrderedItemCBox;
        private System.Windows.Forms.TextBox quantityReceivedTxtBox;
        private System.Windows.Forms.Label label1;

    }
}