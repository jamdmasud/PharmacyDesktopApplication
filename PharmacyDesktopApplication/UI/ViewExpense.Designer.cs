namespace PharmacyDesktopApplication.UI
{
    partial class ViewExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewExpense));
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
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dgvExpense = new System.Windows.Forms.DataGridView();
            this.chbFixeDateDue = new System.Windows.Forms.CheckBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDueTotal = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(907, 24);
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
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(139, 49);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(151, 20);
            this.dtpStartDate.TabIndex = 4;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(309, 49);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(151, 20);
            this.dtpEndDate.TabIndex = 4;
            // 
            // dgvExpense
            // 
            this.dgvExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpense.Location = new System.Drawing.Point(0, 83);
            this.dgvExpense.Name = "dgvExpense";
            this.dgvExpense.Size = new System.Drawing.Size(907, 405);
            this.dgvExpense.TabIndex = 2;
            this.dgvExpense.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDue_CellClick);
            // 
            // chbFixeDateDue
            // 
            this.chbFixeDateDue.AutoSize = true;
            this.chbFixeDateDue.Location = new System.Drawing.Point(13, 49);
            this.chbFixeDateDue.Name = "chbFixeDateDue";
            this.chbFixeDateDue.Size = new System.Drawing.Size(121, 17);
            this.chbFixeDateDue.TabIndex = 5;
            this.chbFixeDateDue.Text = "Fixed Date Expense";
            this.chbFixeDateDue.UseVisualStyleBackColor = true;
            this.chbFixeDateDue.CheckedChanged += new System.EventHandler(this.chbFixeDateDue_CheckedChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(494, 49);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(117, 23);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDueTotal);
            this.panel1.Location = new System.Drawing.Point(0, 490);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 23);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Expense";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDueTotal
            // 
            this.lblDueTotal.AutoSize = true;
            this.lblDueTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDueTotal.ForeColor = System.Drawing.Color.Red;
            this.lblDueTotal.Location = new System.Drawing.Point(239, 2);
            this.lblDueTotal.Name = "lblDueTotal";
            this.lblDueTotal.Size = new System.Drawing.Size(17, 18);
            this.lblDueTotal.TabIndex = 2;
            this.lblDueTotal.Text = "0";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(631, 49);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(117, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ViewExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(907, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.chbFixeDateDue);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.dgvExpense);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ViewExpense";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.DueList_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DataGridView dgvExpense;
        private System.Windows.Forms.CheckBox chbFixeDateDue;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDueTotal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnRefresh;
    }
}

