namespace PharmacyDesktopApplication.UI
{
    partial class MedicineStorage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineStorage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soldMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasedMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dueCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveExpenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvStorage = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblcompany = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMedicine = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soldMedicineToolStripMenuItem,
            this.purchasedMedicineToolStripMenuItem,
            this.dailyTransactionToolStripMenuItem,
            this.dueCollectionToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // soldMedicineToolStripMenuItem
            // 
            this.soldMedicineToolStripMenuItem.Name = "soldMedicineToolStripMenuItem";
            this.soldMedicineToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.soldMedicineToolStripMenuItem.Text = "Sold Medicine";
            // 
            // purchasedMedicineToolStripMenuItem
            // 
            this.purchasedMedicineToolStripMenuItem.Name = "purchasedMedicineToolStripMenuItem";
            this.purchasedMedicineToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.purchasedMedicineToolStripMenuItem.Text = "Purchased Medicine";
            // 
            // dailyTransactionToolStripMenuItem
            // 
            this.dailyTransactionToolStripMenuItem.Name = "dailyTransactionToolStripMenuItem";
            this.dailyTransactionToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.dailyTransactionToolStripMenuItem.Text = "Daily Transaction";
            // 
            // dueCollectionToolStripMenuItem
            // 
            this.dueCollectionToolStripMenuItem.Name = "dueCollectionToolStripMenuItem";
            this.dueCollectionToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.dueCollectionToolStripMenuItem.Text = "Due Collection";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveMedicineToolStripMenuItem,
            this.saveExpenseToolStripMenuItem,
            this.saveGroupToolStripMenuItem,
            this.companyToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveMedicineToolStripMenuItem
            // 
            this.saveMedicineToolStripMenuItem.Name = "saveMedicineToolStripMenuItem";
            this.saveMedicineToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.saveMedicineToolStripMenuItem.Text = "Medicine";
            // 
            // saveExpenseToolStripMenuItem
            // 
            this.saveExpenseToolStripMenuItem.Name = "saveExpenseToolStripMenuItem";
            this.saveExpenseToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.saveExpenseToolStripMenuItem.Text = "Expense";
            // 
            // saveGroupToolStripMenuItem
            // 
            this.saveGroupToolStripMenuItem.Name = "saveGroupToolStripMenuItem";
            this.saveGroupToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.saveGroupToolStripMenuItem.Text = "Group";
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.companyToolStripMenuItem.Text = "Company";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // dgvStorage
            // 
            this.dgvStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorage.Location = new System.Drawing.Point(0, 83);
            this.dgvStorage.Name = "dgvStorage";
            this.dgvStorage.Size = new System.Drawing.Size(824, 405);
            this.dgvStorage.TabIndex = 2;
            this.dgvStorage.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStorage_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblcompany);
            this.panel1.Controls.Add(this.lblGroup);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblMedicine);
            this.panel1.Location = new System.Drawing.Point(0, 490);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 23);
            this.panel1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(529, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Companies";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Groups";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblcompany
            // 
            this.lblcompany.AutoSize = true;
            this.lblcompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblcompany.ForeColor = System.Drawing.Color.Red;
            this.lblcompany.Location = new System.Drawing.Point(635, 2);
            this.lblcompany.Name = "lblcompany";
            this.lblcompany.Size = new System.Drawing.Size(17, 18);
            this.lblcompany.TabIndex = 2;
            this.lblcompany.Text = "0";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblGroup.ForeColor = System.Drawing.Color.Red;
            this.lblGroup.Location = new System.Drawing.Point(369, 2);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(17, 18);
            this.lblGroup.TabIndex = 2;
            this.lblGroup.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total medicine";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMedicine
            // 
            this.lblMedicine.AutoSize = true;
            this.lblMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblMedicine.ForeColor = System.Drawing.Color.Red;
            this.lblMedicine.Location = new System.Drawing.Point(159, 2);
            this.lblMedicine.Name = "lblMedicine";
            this.lblMedicine.Size = new System.Drawing.Size(17, 18);
            this.lblMedicine.TabIndex = 2;
            this.lblMedicine.Text = "0";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(131, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(535, 20);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(35, 45);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(55, 17);
            this.Search.TabIndex = 9;
            this.Search.Text = "Searche";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(590, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // MedicineStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(824, 513);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvStorage);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MedicineStorage";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.DueList_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soldMedicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchasedMedicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dueCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMedicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveExpenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvStorage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMedicine;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblcompany;
        private System.Windows.Forms.Label lblGroup;
    }
}

