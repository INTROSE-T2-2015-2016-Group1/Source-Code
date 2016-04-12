namespace introse_project.sub_windows.Purchase_Order.Supplier
{
    partial class viewSPOItems
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
            this.spoItemsGridView = new System.Windows.Forms.DataGridView();
            this.sPOItemsUpdateBtn = new System.Windows.Forms.Button();
            this.addSPOItemsBtn = new System.Windows.Forms.Button();
            this.cPOItemsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.spoItemsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPOItemsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // spoItemsGridView
            // 
            this.spoItemsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spoItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spoItemsGridView.Location = new System.Drawing.Point(12, 11);
            this.spoItemsGridView.Name = "spoItemsGridView";
            this.spoItemsGridView.ReadOnly = true;
            this.spoItemsGridView.Size = new System.Drawing.Size(718, 301);
            this.spoItemsGridView.TabIndex = 20;
            // 
            // sPOItemsUpdateBtn
            // 
            this.sPOItemsUpdateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sPOItemsUpdateBtn.Location = new System.Drawing.Point(12, 318);
            this.sPOItemsUpdateBtn.Name = "sPOItemsUpdateBtn";
            this.sPOItemsUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.sPOItemsUpdateBtn.TabIndex = 23;
            this.sPOItemsUpdateBtn.Text = "Update";
            this.sPOItemsUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // addSPOItemsBtn
            // 
            this.addSPOItemsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addSPOItemsBtn.Location = new System.Drawing.Point(93, 318);
            this.addSPOItemsBtn.Name = "addSPOItemsBtn";
            this.addSPOItemsBtn.Size = new System.Drawing.Size(75, 23);
            this.addSPOItemsBtn.TabIndex = 22;
            this.addSPOItemsBtn.Text = "Add Item";
            this.addSPOItemsBtn.UseVisualStyleBackColor = true;
            this.addSPOItemsBtn.Click += new System.EventHandler(this.addSPOItemsBtn_Click);
            // 
            // cPOItemsGridView
            // 
            this.cPOItemsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cPOItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cPOItemsGridView.Location = new System.Drawing.Point(12, 11);
            this.cPOItemsGridView.Name = "cPOItemsGridView";
            this.cPOItemsGridView.ReadOnly = true;
            this.cPOItemsGridView.Size = new System.Drawing.Size(718, 301);
            this.cPOItemsGridView.TabIndex = 21;
            // 
            // viewSPOItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 352);
            this.Controls.Add(this.sPOItemsUpdateBtn);
            this.Controls.Add(this.addSPOItemsBtn);
            this.Controls.Add(this.cPOItemsGridView);
            this.Controls.Add(this.spoItemsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "viewSPOItems";
            this.Text = "View Items";
            this.Load += new System.EventHandler(this.viewSPOItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spoItemsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPOItemsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView spoItemsGridView;
        private System.Windows.Forms.Button sPOItemsUpdateBtn;
        private System.Windows.Forms.Button addSPOItemsBtn;
        private System.Windows.Forms.DataGridView cPOItemsGridView;
    }
}