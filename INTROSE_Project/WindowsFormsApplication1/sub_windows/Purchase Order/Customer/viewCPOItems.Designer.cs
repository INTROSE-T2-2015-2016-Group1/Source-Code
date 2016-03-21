namespace introse_project.sub_windows.Purchase_Order.Customer
{
    partial class viewCPOItems
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
            this.cpoItemsGridView = new System.Windows.Forms.DataGridView();
            this.addCPOItemsBtn = new System.Windows.Forms.Button();
            this.cPOItemsUpdateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cpoItemsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cpoItemsGridView
            // 
            this.cpoItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cpoItemsGridView.Location = new System.Drawing.Point(12, 12);
            this.cpoItemsGridView.Name = "cpoItemsGridView";
            this.cpoItemsGridView.ReadOnly = true;
            this.cpoItemsGridView.Size = new System.Drawing.Size(718, 301);
            this.cpoItemsGridView.TabIndex = 0;
            // 
            // addCPOItemsBtn
            // 
            this.addCPOItemsBtn.Location = new System.Drawing.Point(93, 319);
            this.addCPOItemsBtn.Name = "addCPOItemsBtn";
            this.addCPOItemsBtn.Size = new System.Drawing.Size(75, 23);
            this.addCPOItemsBtn.TabIndex = 1;
            this.addCPOItemsBtn.Text = "Add Item";
            this.addCPOItemsBtn.UseVisualStyleBackColor = true;
            this.addCPOItemsBtn.Click += new System.EventHandler(this.addCPOItemsBtn_Click);
            // 
            // cPOItemsUpdateBtn
            // 
            this.cPOItemsUpdateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cPOItemsUpdateBtn.Location = new System.Drawing.Point(12, 319);
            this.cPOItemsUpdateBtn.Name = "cPOItemsUpdateBtn";
            this.cPOItemsUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.cPOItemsUpdateBtn.TabIndex = 19;
            this.cPOItemsUpdateBtn.Text = "Update";
            this.cPOItemsUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // viewCPOItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 352);
            this.Controls.Add(this.cPOItemsUpdateBtn);
            this.Controls.Add(this.addCPOItemsBtn);
            this.Controls.Add(this.cpoItemsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "viewCPOItems";
            this.Text = "View Items";
            this.Load += new System.EventHandler(this.viewCPOItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cpoItemsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cpoItemsGridView;
        private System.Windows.Forms.Button addCPOItemsBtn;
        private System.Windows.Forms.Button cPOItemsUpdateBtn;
    }
}