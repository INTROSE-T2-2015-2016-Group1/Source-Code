namespace introse_project.sub_windows.Purchase_Order.Customer
{
    partial class addCPOItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addCPOItem));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.currencyCBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemDescCBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pricePerUnitTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.itemQtyTxtBox = new System.Windows.Forms.TextBox();
            this.addCPOItemsBtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalPriceLabel);
            this.groupBox2.Controls.Add(this.currencyCBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.itemDescCBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.pricePerUnitTxtBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.itemQtyTxtBox);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // totalPriceLabel
            // 
            resources.ApplyResources(this.totalPriceLabel, "totalPriceLabel");
            this.totalPriceLabel.Name = "totalPriceLabel";
            // 
            // currencyCBox
            // 
            this.currencyCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyCBox.FormattingEnabled = true;
            this.currencyCBox.Items.AddRange(new object[] {
            resources.GetString("currencyCBox.Items"),
            resources.GetString("currencyCBox.Items1"),
            resources.GetString("currencyCBox.Items2")});
            resources.ApplyResources(this.currencyCBox, "currencyCBox");
            this.currencyCBox.Name = "currencyCBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // itemDescCBox
            // 
            resources.ApplyResources(this.itemDescCBox, "itemDescCBox");
            this.itemDescCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemDescCBox.FormattingEnabled = true;
            this.itemDescCBox.Name = "itemDescCBox";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // pricePerUnitTxtBox
            // 
            resources.ApplyResources(this.pricePerUnitTxtBox, "pricePerUnitTxtBox");
            this.pricePerUnitTxtBox.Name = "pricePerUnitTxtBox";
            this.pricePerUnitTxtBox.TextChanged += new System.EventHandler(this.pricePerUnitTxtBox_TextChanged);
            this.pricePerUnitTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pricePerUnitTxtBox_KeyPress);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // itemQtyTxtBox
            // 
            resources.ApplyResources(this.itemQtyTxtBox, "itemQtyTxtBox");
            this.itemQtyTxtBox.Name = "itemQtyTxtBox";
            this.itemQtyTxtBox.TextChanged += new System.EventHandler(this.itemQtyTxtBox_TextChanged);
            this.itemQtyTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemQtyTxtBox_KeyPress);
            // 
            // addCPOItemsBtn
            // 
            resources.ApplyResources(this.addCPOItemsBtn, "addCPOItemsBtn");
            this.addCPOItemsBtn.Name = "addCPOItemsBtn";
            this.addCPOItemsBtn.UseVisualStyleBackColor = true;
            this.addCPOItemsBtn.Click += new System.EventHandler(this.addCPOItemsBtn_Click);
            // 
            // addCPOItem
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addCPOItemsBtn);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "addCPOItem";
            this.Load += new System.EventHandler(this.addCPOItem_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pricePerUnitTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox itemQtyTxtBox;
        private System.Windows.Forms.Button addCPOItemsBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox itemDescCBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox currencyCBox;
        private System.Windows.Forms.Label totalPriceLabel;
    }
}