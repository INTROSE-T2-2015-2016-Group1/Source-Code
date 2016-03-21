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
            this.label2 = new System.Windows.Forms.Label();
            this.itemSupplierCBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.itemDescCBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pricePerUnitTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.currencyTxtBox = new System.Windows.Forms.TextBox();
            this.itemQtyTxtBox = new System.Windows.Forms.TextBox();
            this.addCPOItemsBtn = new System.Windows.Forms.Button();
            this.totalPriceTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalPriceTxtBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.itemSupplierCBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.itemDescCBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.pricePerUnitTxtBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.currencyTxtBox);
            this.groupBox2.Controls.Add(this.itemQtyTxtBox);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // itemSupplierCBox
            // 
            this.itemSupplierCBox.FormattingEnabled = true;
            resources.ApplyResources(this.itemSupplierCBox, "itemSupplierCBox");
            this.itemSupplierCBox.Name = "itemSupplierCBox";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // itemDescCBox
            // 
            this.itemDescCBox.FormattingEnabled = true;
            resources.ApplyResources(this.itemDescCBox, "itemDescCBox");
            this.itemDescCBox.Name = "itemDescCBox";
            this.itemDescCBox.SelectedIndexChanged += new System.EventHandler(this.itemDescCBox_SelectedIndexChanged);
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
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // currencyTxtBox
            // 
            resources.ApplyResources(this.currencyTxtBox, "currencyTxtBox");
            this.currencyTxtBox.Name = "currencyTxtBox";
            // 
            // itemQtyTxtBox
            // 
            resources.ApplyResources(this.itemQtyTxtBox, "itemQtyTxtBox");
            this.itemQtyTxtBox.Name = "itemQtyTxtBox";
            // 
            // addCPOItemsBtn
            // 
            resources.ApplyResources(this.addCPOItemsBtn, "addCPOItemsBtn");
            this.addCPOItemsBtn.Name = "addCPOItemsBtn";
            this.addCPOItemsBtn.UseVisualStyleBackColor = true;
            this.addCPOItemsBtn.Click += new System.EventHandler(this.addCPOItemsBtn_Click);
            // 
            // totalPriceTxtBox
            // 
            resources.ApplyResources(this.totalPriceTxtBox, "totalPriceTxtBox");
            this.totalPriceTxtBox.Name = "totalPriceTxtBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // addCPOItem
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addCPOItemsBtn);
            this.Controls.Add(this.groupBox2);
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
        private System.Windows.Forms.TextBox currencyTxtBox;
        private System.Windows.Forms.TextBox itemQtyTxtBox;
        private System.Windows.Forms.Button addCPOItemsBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox itemSupplierCBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox itemDescCBox;
        private System.Windows.Forms.TextBox totalPriceTxtBox;
        private System.Windows.Forms.Label label1;
    }
}