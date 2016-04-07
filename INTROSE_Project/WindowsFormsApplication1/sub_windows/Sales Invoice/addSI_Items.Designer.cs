namespace introse_project.sub_windows.Sales_Invoice
{
    partial class addSI_Items
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
            this.addSI_ItemsBtn = new System.Windows.Forms.Button();
            this.deliveredQtyTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deliveryItemCBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.addSI_ItemsBtn);
            this.groupBox1.Controls.Add(this.deliveredQtyTxtBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.deliveryItemCBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Information";
            // 
            // addSI_ItemsBtn
            // 
            this.addSI_ItemsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addSI_ItemsBtn.Location = new System.Drawing.Point(145, 218);
            this.addSI_ItemsBtn.Name = "addSI_ItemsBtn";
            this.addSI_ItemsBtn.Size = new System.Drawing.Size(127, 20);
            this.addSI_ItemsBtn.TabIndex = 30;
            this.addSI_ItemsBtn.Text = "Add Item";
            this.addSI_ItemsBtn.UseVisualStyleBackColor = true;
            this.addSI_ItemsBtn.Click += new System.EventHandler(this.addSI_ItemsBtn_Click);
            // 
            // deliveredQtyTxtBox
            // 
            this.deliveredQtyTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deliveredQtyTxtBox.Location = new System.Drawing.Point(9, 101);
            this.deliveredQtyTxtBox.Name = "deliveredQtyTxtBox";
            this.deliveredQtyTxtBox.Size = new System.Drawing.Size(263, 20);
            this.deliveredQtyTxtBox.TabIndex = 29;
            this.deliveredQtyTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deliveredQtyTxtBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Delivered Quantity";
            // 
            // deliveryItemCBox
            // 
            this.deliveryItemCBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deliveryItemCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deliveryItemCBox.FormattingEnabled = true;
            this.deliveryItemCBox.Location = new System.Drawing.Point(9, 44);
            this.deliveryItemCBox.Name = "deliveryItemCBox";
            this.deliveryItemCBox.Size = new System.Drawing.Size(263, 21);
            this.deliveryItemCBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Delivered";
            // 
            // addSI_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 296);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "addSI_Items";
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.addSI_Items_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox deliveryItemCBox;
        private System.Windows.Forms.TextBox deliveredQtyTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addSI_ItemsBtn;
    }
}