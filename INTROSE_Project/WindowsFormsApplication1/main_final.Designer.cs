namespace introse_project
{
    partial class main
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
            this.mainTab = new System.Windows.Forms.TabControl();
            this.clTab = new System.Windows.Forms.TabPage();
            this.clAddBtn = new System.Windows.Forms.Button();
            this.clGridView = new System.Windows.Forms.DataGridView();
            this.clViewBtn = new System.Windows.Forms.Button();
            this.sPOTab = new System.Windows.Forms.TabPage();
            this.sPOViewBtn = new System.Windows.Forms.Button();
            this.sPOUpdateBtn = new System.Windows.Forms.Button();
            this.sPOAddBtn = new System.Windows.Forms.Button();
            this.siTab = new System.Windows.Forms.TabPage();
            this.drTab = new System.Windows.Forms.TabPage();
            this.tabPage22 = new System.Windows.Forms.TabPage();
            this.sPOGridView = new System.Windows.Forms.DataGridView();
            this.siViewBtn = new System.Windows.Forms.Button();
            this.siUpdateBtn = new System.Windows.Forms.Button();
            this.siAddBtn = new System.Windows.Forms.Button();
            this.siGridView = new System.Windows.Forms.DataGridView();
            this.drGridView = new System.Windows.Forms.DataGridView();
            this.drViewBtn = new System.Windows.Forms.Button();
            this.drUpdate = new System.Windows.Forms.Button();
            this.drAddBtn = new System.Windows.Forms.Button();
            this.imViewBtn = new System.Windows.Forms.Button();
            this.imGridView = new System.Windows.Forms.DataGridView();
            this.imUpdateBtn = new System.Windows.Forms.Button();
            this.imAddBtn = new System.Windows.Forms.Button();
            this.imTab = new System.Windows.Forms.TabPage();
            this.slViewBtn = new System.Windows.Forms.Button();
            this.slGridView = new System.Windows.Forms.DataGridView();
            this.slAddBtn = new System.Windows.Forms.Button();
            this.slTab = new System.Windows.Forms.TabPage();
            this.cPOGridView = new System.Windows.Forms.DataGridView();
            this.cPOAddBtn = new System.Windows.Forms.Button();
            this.cPOUpdateBtn = new System.Windows.Forms.Button();
            this.cPOViewBtn = new System.Windows.Forms.Button();
            this.cPOTab = new System.Windows.Forms.TabPage();
            this.searchTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.formTypeCBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.keywordTypeCBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.keywordTxtBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.searchFormGridView = new System.Windows.Forms.DataGridView();
            this.tabControl7 = new System.Windows.Forms.TabControl();
            this.mainTab.SuspendLayout();
            this.clTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clGridView)).BeginInit();
            this.sPOTab.SuspendLayout();
            this.siTab.SuspendLayout();
            this.drTab.SuspendLayout();
            this.tabPage22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPOGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imGridView)).BeginInit();
            this.imTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slGridView)).BeginInit();
            this.slTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPOGridView)).BeginInit();
            this.cPOTab.SuspendLayout();
            this.searchTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchFormGridView)).BeginInit();
            this.tabControl7.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.imTab);
            this.mainTab.Controls.Add(this.clTab);
            this.mainTab.Controls.Add(this.slTab);
            this.mainTab.Controls.Add(this.cPOTab);
            this.mainTab.Controls.Add(this.sPOTab);
            this.mainTab.Controls.Add(this.siTab);
            this.mainTab.Controls.Add(this.drTab);
            this.mainTab.Controls.Add(this.tabPage22);
            this.mainTab.Location = new System.Drawing.Point(12, 37);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(889, 442);
            this.mainTab.TabIndex = 0;
            this.mainTab.SelectedIndexChanged += new System.EventHandler(this.mainTab_SelectedIndexChanged);
            // 
            // clTab
            // 
            this.clTab.Controls.Add(this.clAddBtn);
            this.clTab.Controls.Add(this.clGridView);
            this.clTab.Controls.Add(this.clViewBtn);
            this.clTab.Location = new System.Drawing.Point(4, 22);
            this.clTab.Name = "clTab";
            this.clTab.Padding = new System.Windows.Forms.Padding(3);
            this.clTab.Size = new System.Drawing.Size(881, 416);
            this.clTab.TabIndex = 11;
            this.clTab.Text = "Company List";
            this.clTab.UseVisualStyleBackColor = true;
            // 
            // clAddBtn
            // 
            this.clAddBtn.Location = new System.Drawing.Point(87, 378);
            this.clAddBtn.Name = "clAddBtn";
            this.clAddBtn.Size = new System.Drawing.Size(75, 23);
            this.clAddBtn.TabIndex = 22;
            this.clAddBtn.Text = "Add";
            this.clAddBtn.UseVisualStyleBackColor = true;
            this.clAddBtn.Click += new System.EventHandler(this.clAddBtn_Click);
            // 
            // clGridView
            // 
            this.clGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clGridView.Location = new System.Drawing.Point(6, 6);
            this.clGridView.Name = "clGridView";
            this.clGridView.Size = new System.Drawing.Size(869, 366);
            this.clGridView.TabIndex = 19;
            // 
            // clViewBtn
            // 
            this.clViewBtn.Location = new System.Drawing.Point(6, 378);
            this.clViewBtn.Name = "clViewBtn";
            this.clViewBtn.Size = new System.Drawing.Size(75, 23);
            this.clViewBtn.TabIndex = 18;
            this.clViewBtn.Text = "View";
            this.clViewBtn.UseVisualStyleBackColor = true;
            this.clViewBtn.Click += new System.EventHandler(this.clViewBtn_Click);
            // 
            // sPOTab
            // 
            this.sPOTab.Controls.Add(this.sPOGridView);
            this.sPOTab.Controls.Add(this.sPOViewBtn);
            this.sPOTab.Controls.Add(this.sPOUpdateBtn);
            this.sPOTab.Controls.Add(this.sPOAddBtn);
            this.sPOTab.Location = new System.Drawing.Point(4, 22);
            this.sPOTab.Name = "sPOTab";
            this.sPOTab.Size = new System.Drawing.Size(881, 416);
            this.sPOTab.TabIndex = 0;
            this.sPOTab.Text = "Supplier Purchase Order";
            this.sPOTab.UseVisualStyleBackColor = true;
            // 
            // sPOViewBtn
            // 
            this.sPOViewBtn.Location = new System.Drawing.Point(6, 378);
            this.sPOViewBtn.Name = "sPOViewBtn";
            this.sPOViewBtn.Size = new System.Drawing.Size(75, 23);
            this.sPOViewBtn.TabIndex = 16;
            this.sPOViewBtn.Text = "View";
            this.sPOViewBtn.UseVisualStyleBackColor = true;
            this.sPOViewBtn.Click += new System.EventHandler(this.sPOViewBtn_Click);
            // 
            // sPOUpdateBtn
            // 
            this.sPOUpdateBtn.Location = new System.Drawing.Point(87, 378);
            this.sPOUpdateBtn.Name = "sPOUpdateBtn";
            this.sPOUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.sPOUpdateBtn.TabIndex = 15;
            this.sPOUpdateBtn.Text = "Update";
            this.sPOUpdateBtn.UseVisualStyleBackColor = true;
            this.sPOUpdateBtn.Click += new System.EventHandler(this.sPOUpdateBtn_Click);
            // 
            // sPOAddBtn
            // 
            this.sPOAddBtn.Location = new System.Drawing.Point(168, 378);
            this.sPOAddBtn.Name = "sPOAddBtn";
            this.sPOAddBtn.Size = new System.Drawing.Size(75, 23);
            this.sPOAddBtn.TabIndex = 14;
            this.sPOAddBtn.Text = "Add";
            this.sPOAddBtn.UseVisualStyleBackColor = true;
            this.sPOAddBtn.Click += new System.EventHandler(this.sPOAddBtn_Click);
            // 
            // siTab
            // 
            this.siTab.Controls.Add(this.siGridView);
            this.siTab.Controls.Add(this.siViewBtn);
            this.siTab.Controls.Add(this.siUpdateBtn);
            this.siTab.Controls.Add(this.siAddBtn);
            this.siTab.Location = new System.Drawing.Point(4, 22);
            this.siTab.Name = "siTab";
            this.siTab.Padding = new System.Windows.Forms.Padding(3);
            this.siTab.Size = new System.Drawing.Size(881, 416);
            this.siTab.TabIndex = 7;
            this.siTab.Text = "Sales Invoice";
            this.siTab.UseVisualStyleBackColor = true;
            // 
            // drTab
            // 
            this.drTab.Controls.Add(this.drGridView);
            this.drTab.Controls.Add(this.drViewBtn);
            this.drTab.Controls.Add(this.drUpdate);
            this.drTab.Controls.Add(this.drAddBtn);
            this.drTab.Location = new System.Drawing.Point(4, 22);
            this.drTab.Name = "drTab";
            this.drTab.Padding = new System.Windows.Forms.Padding(3);
            this.drTab.Size = new System.Drawing.Size(881, 416);
            this.drTab.TabIndex = 8;
            this.drTab.Text = "Delivery Receipt";
            this.drTab.UseVisualStyleBackColor = true;
            // 
            // tabPage22
            // 
            this.tabPage22.Controls.Add(this.tabControl7);
            this.tabPage22.Location = new System.Drawing.Point(4, 22);
            this.tabPage22.Name = "tabPage22";
            this.tabPage22.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage22.Size = new System.Drawing.Size(881, 416);
            this.tabPage22.TabIndex = 9;
            this.tabPage22.Text = "Search";
            this.tabPage22.UseVisualStyleBackColor = true;
            // 
            // sPOGridView
            // 
            this.sPOGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sPOGridView.Location = new System.Drawing.Point(6, 6);
            this.sPOGridView.Name = "sPOGridView";
            this.sPOGridView.Size = new System.Drawing.Size(869, 366);
            this.sPOGridView.TabIndex = 17;
            // 
            // siViewBtn
            // 
            this.siViewBtn.Location = new System.Drawing.Point(6, 378);
            this.siViewBtn.Name = "siViewBtn";
            this.siViewBtn.Size = new System.Drawing.Size(75, 23);
            this.siViewBtn.TabIndex = 19;
            this.siViewBtn.Text = "View";
            this.siViewBtn.UseVisualStyleBackColor = true;
            this.siViewBtn.Click += new System.EventHandler(this.siViewBtn_Click);
            // 
            // siUpdateBtn
            // 
            this.siUpdateBtn.Location = new System.Drawing.Point(87, 378);
            this.siUpdateBtn.Name = "siUpdateBtn";
            this.siUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.siUpdateBtn.TabIndex = 18;
            this.siUpdateBtn.Text = "Update";
            this.siUpdateBtn.UseVisualStyleBackColor = true;
            this.siUpdateBtn.Click += new System.EventHandler(this.siUpdateBtn_Click);
            // 
            // siAddBtn
            // 
            this.siAddBtn.Location = new System.Drawing.Point(168, 378);
            this.siAddBtn.Name = "siAddBtn";
            this.siAddBtn.Size = new System.Drawing.Size(75, 23);
            this.siAddBtn.TabIndex = 17;
            this.siAddBtn.Text = "Add";
            this.siAddBtn.UseVisualStyleBackColor = true;
            this.siAddBtn.Click += new System.EventHandler(this.siAddBtn_Click);
            // 
            // siGridView
            // 
            this.siGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.siGridView.Location = new System.Drawing.Point(6, 6);
            this.siGridView.Name = "siGridView";
            this.siGridView.Size = new System.Drawing.Size(869, 366);
            this.siGridView.TabIndex = 20;
            // 
            // drGridView
            // 
            this.drGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drGridView.Location = new System.Drawing.Point(6, 6);
            this.drGridView.Name = "drGridView";
            this.drGridView.Size = new System.Drawing.Size(869, 366);
            this.drGridView.TabIndex = 24;
            // 
            // drViewBtn
            // 
            this.drViewBtn.Location = new System.Drawing.Point(6, 378);
            this.drViewBtn.Name = "drViewBtn";
            this.drViewBtn.Size = new System.Drawing.Size(75, 23);
            this.drViewBtn.TabIndex = 23;
            this.drViewBtn.Text = "View";
            this.drViewBtn.UseVisualStyleBackColor = true;
            // 
            // drUpdate
            // 
            this.drUpdate.Location = new System.Drawing.Point(87, 378);
            this.drUpdate.Name = "drUpdate";
            this.drUpdate.Size = new System.Drawing.Size(75, 23);
            this.drUpdate.TabIndex = 22;
            this.drUpdate.Text = "Update";
            this.drUpdate.UseVisualStyleBackColor = true;
            // 
            // drAddBtn
            // 
            this.drAddBtn.Location = new System.Drawing.Point(168, 378);
            this.drAddBtn.Name = "drAddBtn";
            this.drAddBtn.Size = new System.Drawing.Size(75, 23);
            this.drAddBtn.TabIndex = 21;
            this.drAddBtn.Text = "Add";
            this.drAddBtn.UseVisualStyleBackColor = true;
            // 
            // imViewBtn
            // 
            this.imViewBtn.Location = new System.Drawing.Point(6, 378);
            this.imViewBtn.Name = "imViewBtn";
            this.imViewBtn.Size = new System.Drawing.Size(75, 23);
            this.imViewBtn.TabIndex = 14;
            this.imViewBtn.Text = "View";
            this.imViewBtn.UseVisualStyleBackColor = true;
            this.imViewBtn.Click += new System.EventHandler(this.imViewBtn_Click);
            // 
            // imGridView
            // 
            this.imGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.imGridView.Location = new System.Drawing.Point(6, 6);
            this.imGridView.Name = "imGridView";
            this.imGridView.Size = new System.Drawing.Size(869, 366);
            this.imGridView.TabIndex = 15;
            // 
            // imUpdateBtn
            // 
            this.imUpdateBtn.Location = new System.Drawing.Point(87, 378);
            this.imUpdateBtn.Name = "imUpdateBtn";
            this.imUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.imUpdateBtn.TabIndex = 16;
            this.imUpdateBtn.Text = "Update";
            this.imUpdateBtn.UseVisualStyleBackColor = true;
            this.imUpdateBtn.Click += new System.EventHandler(this.imUpdateBtn_Click);
            // 
            // imAddBtn
            // 
            this.imAddBtn.Location = new System.Drawing.Point(168, 378);
            this.imAddBtn.Name = "imAddBtn";
            this.imAddBtn.Size = new System.Drawing.Size(75, 23);
            this.imAddBtn.TabIndex = 17;
            this.imAddBtn.Text = "Add";
            this.imAddBtn.UseVisualStyleBackColor = true;
            this.imAddBtn.Click += new System.EventHandler(this.imAddBtn_Click);
            // 
            // imTab
            // 
            this.imTab.Controls.Add(this.imAddBtn);
            this.imTab.Controls.Add(this.imUpdateBtn);
            this.imTab.Controls.Add(this.imGridView);
            this.imTab.Controls.Add(this.imViewBtn);
            this.imTab.Location = new System.Drawing.Point(4, 22);
            this.imTab.Name = "imTab";
            this.imTab.Padding = new System.Windows.Forms.Padding(3);
            this.imTab.Size = new System.Drawing.Size(881, 416);
            this.imTab.TabIndex = 10;
            this.imTab.Text = "Item Management";
            this.imTab.UseVisualStyleBackColor = true;
            // 
            // slViewBtn
            // 
            this.slViewBtn.Location = new System.Drawing.Point(6, 378);
            this.slViewBtn.Name = "slViewBtn";
            this.slViewBtn.Size = new System.Drawing.Size(75, 23);
            this.slViewBtn.TabIndex = 23;
            this.slViewBtn.Text = "View";
            this.slViewBtn.UseVisualStyleBackColor = true;
            this.slViewBtn.Click += new System.EventHandler(this.slViewBtn_Click);
            // 
            // slGridView
            // 
            this.slGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.slGridView.Location = new System.Drawing.Point(6, 6);
            this.slGridView.Name = "slGridView";
            this.slGridView.Size = new System.Drawing.Size(869, 366);
            this.slGridView.TabIndex = 24;
            // 
            // slAddBtn
            // 
            this.slAddBtn.Location = new System.Drawing.Point(87, 378);
            this.slAddBtn.Name = "slAddBtn";
            this.slAddBtn.Size = new System.Drawing.Size(75, 23);
            this.slAddBtn.TabIndex = 26;
            this.slAddBtn.Text = "Add";
            this.slAddBtn.UseVisualStyleBackColor = true;
            this.slAddBtn.Click += new System.EventHandler(this.slAddBtn_Click);
            // 
            // slTab
            // 
            this.slTab.Controls.Add(this.slAddBtn);
            this.slTab.Controls.Add(this.slGridView);
            this.slTab.Controls.Add(this.slViewBtn);
            this.slTab.Location = new System.Drawing.Point(4, 22);
            this.slTab.Name = "slTab";
            this.slTab.Padding = new System.Windows.Forms.Padding(3);
            this.slTab.Size = new System.Drawing.Size(881, 416);
            this.slTab.TabIndex = 12;
            this.slTab.Text = "Supplier List";
            this.slTab.UseVisualStyleBackColor = true;
            // 
            // cPOGridView
            // 
            this.cPOGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cPOGridView.Location = new System.Drawing.Point(6, 6);
            this.cPOGridView.Name = "cPOGridView";
            this.cPOGridView.Size = new System.Drawing.Size(869, 366);
            this.cPOGridView.TabIndex = 10;
            // 
            // cPOAddBtn
            // 
            this.cPOAddBtn.Location = new System.Drawing.Point(168, 378);
            this.cPOAddBtn.Name = "cPOAddBtn";
            this.cPOAddBtn.Size = new System.Drawing.Size(75, 23);
            this.cPOAddBtn.TabIndex = 17;
            this.cPOAddBtn.Text = "Add";
            this.cPOAddBtn.UseVisualStyleBackColor = true;
            this.cPOAddBtn.Click += new System.EventHandler(this.cPOAddBtn_Click);
            // 
            // cPOUpdateBtn
            // 
            this.cPOUpdateBtn.Location = new System.Drawing.Point(87, 378);
            this.cPOUpdateBtn.Name = "cPOUpdateBtn";
            this.cPOUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.cPOUpdateBtn.TabIndex = 18;
            this.cPOUpdateBtn.Text = "Update";
            this.cPOUpdateBtn.UseVisualStyleBackColor = true;
            this.cPOUpdateBtn.Click += new System.EventHandler(this.cPOUpdateBtn_Click);
            // 
            // cPOViewBtn
            // 
            this.cPOViewBtn.Location = new System.Drawing.Point(6, 378);
            this.cPOViewBtn.Name = "cPOViewBtn";
            this.cPOViewBtn.Size = new System.Drawing.Size(75, 23);
            this.cPOViewBtn.TabIndex = 19;
            this.cPOViewBtn.Text = "View";
            this.cPOViewBtn.UseVisualStyleBackColor = true;
            this.cPOViewBtn.Click += new System.EventHandler(this.cPOViewBtn_Click);
            // 
            // cPOTab
            // 
            this.cPOTab.Controls.Add(this.cPOViewBtn);
            this.cPOTab.Controls.Add(this.cPOUpdateBtn);
            this.cPOTab.Controls.Add(this.cPOAddBtn);
            this.cPOTab.Controls.Add(this.cPOGridView);
            this.cPOTab.Location = new System.Drawing.Point(4, 22);
            this.cPOTab.Name = "cPOTab";
            this.cPOTab.Padding = new System.Windows.Forms.Padding(3);
            this.cPOTab.Size = new System.Drawing.Size(881, 416);
            this.cPOTab.TabIndex = 5;
            this.cPOTab.Text = "Customer Purchase Order";
            this.cPOTab.UseVisualStyleBackColor = true;
            // 
            // searchTab
            // 
            this.searchTab.Controls.Add(this.searchFormGridView);
            this.searchTab.Controls.Add(this.panel1);
            this.searchTab.Location = new System.Drawing.Point(4, 22);
            this.searchTab.Name = "searchTab";
            this.searchTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchTab.Size = new System.Drawing.Size(861, 356);
            this.searchTab.TabIndex = 0;
            this.searchTab.Text = "Search Form";
            this.searchTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.keywordTxtBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.keywordTypeCBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.formTypeCBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 141);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Form Type";
            // 
            // formTypeCBox
            // 
            this.formTypeCBox.FormattingEnabled = true;
            this.formTypeCBox.Location = new System.Drawing.Point(78, 7);
            this.formTypeCBox.Name = "formTypeCBox";
            this.formTypeCBox.Size = new System.Drawing.Size(177, 21);
            this.formTypeCBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Keyword Type";
            // 
            // keywordTypeCBox
            // 
            this.keywordTypeCBox.FormattingEnabled = true;
            this.keywordTypeCBox.Location = new System.Drawing.Point(78, 34);
            this.keywordTypeCBox.Name = "keywordTypeCBox";
            this.keywordTypeCBox.Size = new System.Drawing.Size(177, 21);
            this.keywordTypeCBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Keyword\r\n";
            // 
            // keywordTxtBox
            // 
            this.keywordTxtBox.Location = new System.Drawing.Point(78, 61);
            this.keywordTxtBox.Name = "keywordTxtBox";
            this.keywordTxtBox.Size = new System.Drawing.Size(177, 20);
            this.keywordTxtBox.TabIndex = 6;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(180, 87);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 20);
            this.searchBtn.TabIndex = 7;
            this.searchBtn.Text = "Seach";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(180, 113);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 20);
            this.editBtn.TabIndex = 13;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            // 
            // searchFormGridView
            // 
            this.searchFormGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchFormGridView.Location = new System.Drawing.Point(270, 6);
            this.searchFormGridView.Name = "searchFormGridView";
            this.searchFormGridView.Size = new System.Drawing.Size(585, 344);
            this.searchFormGridView.TabIndex = 17;
            // 
            // tabControl7
            // 
            this.tabControl7.Controls.Add(this.searchTab);
            this.tabControl7.Location = new System.Drawing.Point(6, 6);
            this.tabControl7.Name = "tabControl7";
            this.tabControl7.SelectedIndex = 0;
            this.tabControl7.Size = new System.Drawing.Size(869, 382);
            this.tabControl7.TabIndex = 0;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 516);
            this.Controls.Add(this.mainTab);
            this.Name = "main";
            this.Text = "Monitoring System";
            this.Load += new System.EventHandler(this.main_Load);
            this.mainTab.ResumeLayout(false);
            this.clTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clGridView)).EndInit();
            this.sPOTab.ResumeLayout(false);
            this.siTab.ResumeLayout(false);
            this.drTab.ResumeLayout(false);
            this.tabPage22.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sPOGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imGridView)).EndInit();
            this.imTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slGridView)).EndInit();
            this.slTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cPOGridView)).EndInit();
            this.cPOTab.ResumeLayout(false);
            this.searchTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchFormGridView)).EndInit();
            this.tabControl7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage siTab;
        private System.Windows.Forms.TabPage drTab;
        private System.Windows.Forms.TabPage tabPage22;
        private System.Windows.Forms.TabPage sPOTab;
        private System.Windows.Forms.TabPage clTab;
        private System.Windows.Forms.Button sPOAddBtn;
        private System.Windows.Forms.Button sPOUpdateBtn;
        private System.Windows.Forms.Button sPOViewBtn;
        private System.Windows.Forms.DataGridView clGridView;
        private System.Windows.Forms.Button clViewBtn;
        private System.Windows.Forms.Button clAddBtn;
        private System.Windows.Forms.DataGridView sPOGridView;
        private System.Windows.Forms.Button siViewBtn;
        private System.Windows.Forms.Button siUpdateBtn;
        private System.Windows.Forms.Button siAddBtn;
        private System.Windows.Forms.DataGridView siGridView;
        private System.Windows.Forms.DataGridView drGridView;
        private System.Windows.Forms.Button drViewBtn;
        private System.Windows.Forms.Button drUpdate;
        private System.Windows.Forms.Button drAddBtn;
        private System.Windows.Forms.TabPage imTab;
        private System.Windows.Forms.Button imAddBtn;
        private System.Windows.Forms.Button imUpdateBtn;
        private System.Windows.Forms.DataGridView imGridView;
        private System.Windows.Forms.Button imViewBtn;
        private System.Windows.Forms.TabPage slTab;
        private System.Windows.Forms.Button slAddBtn;
        private System.Windows.Forms.DataGridView slGridView;
        private System.Windows.Forms.Button slViewBtn;
        private System.Windows.Forms.TabPage cPOTab;
        private System.Windows.Forms.Button cPOViewBtn;
        private System.Windows.Forms.Button cPOUpdateBtn;
        private System.Windows.Forms.Button cPOAddBtn;
        private System.Windows.Forms.DataGridView cPOGridView;
        private System.Windows.Forms.TabControl tabControl7;
        private System.Windows.Forms.TabPage searchTab;
        private System.Windows.Forms.DataGridView searchFormGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox keywordTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox keywordTypeCBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox formTypeCBox;
        private System.Windows.Forms.Label label1;

    }
}

