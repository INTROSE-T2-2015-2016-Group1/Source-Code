namespace introse_project.sub_windows.Delivery_Receipt
{
    partial class viewDRItems
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
            this.addDRItemsBtn = new System.Windows.Forms.Button();
            this.updateDRItemsBtn = new System.Windows.Forms.Button();
            this.DR_ItemsGridView = new System.Windows.Forms.DataGridView();
            this.godoInspectionResultsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DR_ItemsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addDRItemsBtn
            // 
            this.addDRItemsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addDRItemsBtn.Location = new System.Drawing.Point(107, 318);
            this.addDRItemsBtn.Name = "addDRItemsBtn";
            this.addDRItemsBtn.Size = new System.Drawing.Size(75, 23);
            this.addDRItemsBtn.TabIndex = 26;
            this.addDRItemsBtn.Text = "Add Item";
            this.addDRItemsBtn.UseVisualStyleBackColor = true;
            // 
            // updateDRItemsBtn
            // 
            this.updateDRItemsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateDRItemsBtn.Location = new System.Drawing.Point(12, 318);
            this.updateDRItemsBtn.Name = "updateDRItemsBtn";
            this.updateDRItemsBtn.Size = new System.Drawing.Size(89, 23);
            this.updateDRItemsBtn.TabIndex = 25;
            this.updateDRItemsBtn.Text = "Update Item";
            this.updateDRItemsBtn.UseVisualStyleBackColor = true;
            // 
            // DR_ItemsGridView
            // 
            this.DR_ItemsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DR_ItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DR_ItemsGridView.Location = new System.Drawing.Point(12, 11);
            this.DR_ItemsGridView.Name = "DR_ItemsGridView";
            this.DR_ItemsGridView.ReadOnly = true;
            this.DR_ItemsGridView.Size = new System.Drawing.Size(718, 301);
            this.DR_ItemsGridView.TabIndex = 24;
            // 
            // godoInspectionResultsBtn
            // 
            this.godoInspectionResultsBtn.Location = new System.Drawing.Point(188, 317);
            this.godoInspectionResultsBtn.Name = "godoInspectionResultsBtn";
            this.godoInspectionResultsBtn.Size = new System.Drawing.Size(163, 23);
            this.godoInspectionResultsBtn.TabIndex = 27;
            this.godoInspectionResultsBtn.Text = "GODO Inspection Results";
            this.godoInspectionResultsBtn.UseVisualStyleBackColor = true;
            // 
            // viewDRItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 352);
            this.Controls.Add(this.godoInspectionResultsBtn);
            this.Controls.Add(this.addDRItemsBtn);
            this.Controls.Add(this.updateDRItemsBtn);
            this.Controls.Add(this.DR_ItemsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "viewDRItems";
            this.Text = "View Items";
            this.Load += new System.EventHandler(this.viewDRItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DR_ItemsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addDRItemsBtn;
        private System.Windows.Forms.Button updateDRItemsBtn;
        private System.Windows.Forms.DataGridView DR_ItemsGridView;
        private System.Windows.Forms.Button godoInspectionResultsBtn;
    }
}