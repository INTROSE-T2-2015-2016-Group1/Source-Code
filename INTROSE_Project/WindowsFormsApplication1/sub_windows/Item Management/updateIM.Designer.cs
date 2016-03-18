namespace introse_project.sub_windows.Item_Management
{
    partial class updateIM
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
            this.itemUpdateBtn = new System.Windows.Forms.Button();
            this.descTxtBox = new System.Windows.Forms.TextBox();
            this.supplierTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemUpdateBtn
            // 
            this.itemUpdateBtn.Location = new System.Drawing.Point(318, 72);
            this.itemUpdateBtn.Name = "itemUpdateBtn";
            this.itemUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.itemUpdateBtn.TabIndex = 9;
            this.itemUpdateBtn.Text = "Update Item";
            this.itemUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // descTxtBox
            // 
            this.descTxtBox.Location = new System.Drawing.Point(94, 74);
            this.descTxtBox.Name = "descTxtBox";
            this.descTxtBox.Size = new System.Drawing.Size(151, 20);
            this.descTxtBox.TabIndex = 8;
            // 
            // supplierTxtBox
            // 
            this.supplierTxtBox.Location = new System.Drawing.Point(94, 31);
            this.supplierTxtBox.Name = "supplierTxtBox";
            this.supplierTxtBox.Size = new System.Drawing.Size(151, 20);
            this.supplierTxtBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Supplier Name";
            // 
            // updateIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 138);
            this.Controls.Add(this.itemUpdateBtn);
            this.Controls.Add(this.descTxtBox);
            this.Controls.Add(this.supplierTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "updateIM";
            this.Text = "Update Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button itemUpdateBtn;
        private System.Windows.Forms.TextBox descTxtBox;
        private System.Windows.Forms.TextBox supplierTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;


    }
}