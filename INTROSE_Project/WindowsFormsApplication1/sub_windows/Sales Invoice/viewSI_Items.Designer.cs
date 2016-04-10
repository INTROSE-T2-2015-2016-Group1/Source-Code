namespace introse_project.sub_windows.Sales_Invoice
{
    partial class viewSI_Items
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
            this.updateSI_ItemsBtn = new System.Windows.Forms.Button();
            this.SI_ItemsGridView = new System.Windows.Forms.DataGridView();
            this.addSI_ItemsBtn = new System.Windows.Forms.Button();
            this.customerInspectionResultsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SI_ItemsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // updateSI_ItemsBtn
            // 
            this.updateSI_ItemsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateSI_ItemsBtn.Location = new System.Drawing.Point(12, 319);
            this.updateSI_ItemsBtn.Name = "updateSI_ItemsBtn";
            this.updateSI_ItemsBtn.Size = new System.Drawing.Size(89, 23);
            this.updateSI_ItemsBtn.TabIndex = 22;
            this.updateSI_ItemsBtn.Text = "Update Item";
            this.updateSI_ItemsBtn.UseVisualStyleBackColor = true;
            // 
            // SI_ItemsGridView
            // 
            this.SI_ItemsGridView.AllowUserToAddRows = false;
            this.SI_ItemsGridView.AllowUserToDeleteRows = false;
            this.SI_ItemsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SI_ItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SI_ItemsGridView.Location = new System.Drawing.Point(12, 12);
            this.SI_ItemsGridView.Name = "SI_ItemsGridView";
            this.SI_ItemsGridView.ReadOnly = true;
            this.SI_ItemsGridView.Size = new System.Drawing.Size(718, 301);
            this.SI_ItemsGridView.TabIndex = 20;
            // 
            // addSI_ItemsBtn
            // 
            this.addSI_ItemsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addSI_ItemsBtn.Location = new System.Drawing.Point(107, 319);
            this.addSI_ItemsBtn.Name = "addSI_ItemsBtn";
            this.addSI_ItemsBtn.Size = new System.Drawing.Size(75, 23);
            this.addSI_ItemsBtn.TabIndex = 23;
            this.addSI_ItemsBtn.Text = "Add Item";
            this.addSI_ItemsBtn.UseVisualStyleBackColor = true;
            this.addSI_ItemsBtn.Click += new System.EventHandler(this.addSI_ItemsBtn_Click_1);
            // 
            // customerInspectionResultsBtn
            // 
            this.customerInspectionResultsBtn.Location = new System.Drawing.Point(188, 319);
            this.customerInspectionResultsBtn.Name = "customerInspectionResultsBtn";
            this.customerInspectionResultsBtn.Size = new System.Drawing.Size(163, 23);
            this.customerInspectionResultsBtn.TabIndex = 24;
            this.customerInspectionResultsBtn.Text = "Customer Inspection Results";
            this.customerInspectionResultsBtn.UseVisualStyleBackColor = true;
            this.customerInspectionResultsBtn.Click += new System.EventHandler(this.customerInspectionResultsBtn_Click);
            // 
            // viewSI_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 352);
            this.Controls.Add(this.customerInspectionResultsBtn);
            this.Controls.Add(this.addSI_ItemsBtn);
            this.Controls.Add(this.updateSI_ItemsBtn);
            this.Controls.Add(this.SI_ItemsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "viewSI_Items";
            this.Text = "View Items";
            this.Load += new System.EventHandler(this.viewSI_Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SI_ItemsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateSI_ItemsBtn;
        private System.Windows.Forms.DataGridView SI_ItemsGridView;
        private System.Windows.Forms.Button addSI_ItemsBtn;
        private System.Windows.Forms.Button customerInspectionResultsBtn;
    }
}