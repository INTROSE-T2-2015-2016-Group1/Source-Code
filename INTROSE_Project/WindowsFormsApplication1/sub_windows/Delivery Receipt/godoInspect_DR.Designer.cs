namespace introse_project.sub_windows.Delivery_Receipt
{
    partial class godoInspect_DR
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
            this.rejectedQtyTxtBox_U = new System.Windows.Forms.TextBox();
            this.approvedQtyTxtBox_U = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.updateDR_GIRBtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rejectedQtyTxtBox_U
            // 
            this.rejectedQtyTxtBox_U.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rejectedQtyTxtBox_U.Location = new System.Drawing.Point(127, 74);
            this.rejectedQtyTxtBox_U.Name = "rejectedQtyTxtBox_U";
            this.rejectedQtyTxtBox_U.Size = new System.Drawing.Size(122, 20);
            this.rejectedQtyTxtBox_U.TabIndex = 18;
            this.rejectedQtyTxtBox_U.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rejectedQtyTxtBox_U_KeyPress);
            // 
            // approvedQtyTxtBox_U
            // 
            this.approvedQtyTxtBox_U.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.approvedQtyTxtBox_U.Location = new System.Drawing.Point(127, 48);
            this.approvedQtyTxtBox_U.Name = "approvedQtyTxtBox_U";
            this.approvedQtyTxtBox_U.Size = new System.Drawing.Size(122, 20);
            this.approvedQtyTxtBox_U.TabIndex = 17;
            this.approvedQtyTxtBox_U.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.approvedQtyTxtBox_U_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "No. Of Items Approved";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rejectedQtyTxtBox_U);
            this.groupBox2.Controls.Add(this.approvedQtyTxtBox_U);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.updateDR_GIRBtn);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 133);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Item Inspection";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "No. Of Items Rejected\r\n";
            // 
            // updateDR_GIRBtn
            // 
            this.updateDR_GIRBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateDR_GIRBtn.Location = new System.Drawing.Point(9, 104);
            this.updateDR_GIRBtn.Name = "updateDR_GIRBtn";
            this.updateDR_GIRBtn.Size = new System.Drawing.Size(240, 23);
            this.updateDR_GIRBtn.TabIndex = 11;
            this.updateDR_GIRBtn.Text = "Update Results";
            this.updateDR_GIRBtn.UseVisualStyleBackColor = true;
            this.updateDR_GIRBtn.Click += new System.EventHandler(this.updateDR_GIRBtn_Click);
            // 
            // godoInspect_DR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 160);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "godoInspect_DR";
            this.Text = "Inspection Results";
            this.Load += new System.EventHandler(this.godoInspect_DR_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox rejectedQtyTxtBox_U;
        private System.Windows.Forms.TextBox approvedQtyTxtBox_U;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button updateDR_GIRBtn;

    }
}