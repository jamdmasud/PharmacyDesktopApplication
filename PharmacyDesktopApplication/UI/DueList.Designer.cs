namespace PharmacyDesktopApplication.UI
{
    partial class DueList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DueList));
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
            this.btnDues = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.pharmacyDataSet = new PharmacyDesktopApplication.PharmacyDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new PharmacyDesktopApplication.PharmacyDataSetTableAdapters.CustomerTableAdapter();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnTodayDue = new System.Windows.Forms.Button();
            this.dgvDue = new System.Windows.Forms.DataGridView();
            this.chbFixeDateDue = new System.Windows.Forms.CheckBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDueTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPaidTotal = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvTodayDue = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDue)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayDue)).BeginInit();
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
            // btnDues
            // 
            this.btnDues.Location = new System.Drawing.Point(459, 49);
            this.btnDues.Name = "btnDues";
            this.btnDues.Size = new System.Drawing.Size(75, 23);
            this.btnDues.TabIndex = 3;
            this.btnDues.Text = "Dues";
            this.btnDues.UseVisualStyleBackColor = true;
            this.btnDues.Click += new System.EventHandler(this.btnDues_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(119, 49);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(151, 20);
            this.dtpStartDate.TabIndex = 4;
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(289, 49);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(151, 20);
            this.dtpEndDate.TabIndex = 4;
            // 
            // btnTodayDue
            // 
            this.btnTodayDue.Location = new System.Drawing.Point(553, 49);
            this.btnTodayDue.Name = "btnTodayDue";
            this.btnTodayDue.Size = new System.Drawing.Size(75, 23);
            this.btnTodayDue.TabIndex = 3;
            this.btnTodayDue.Text = "Today Due";
            this.btnTodayDue.UseVisualStyleBackColor = true;
            this.btnTodayDue.Click += new System.EventHandler(this.btnTodayDue_Click);
            // 
            // dgvDue
            // 
            this.dgvDue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDue.Location = new System.Drawing.Point(0, 83);
            this.dgvDue.Name = "dgvDue";
            this.dgvDue.Size = new System.Drawing.Size(907, 405);
            this.dgvDue.TabIndex = 2;
            this.dgvDue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDue_CellClick);
            // 
            // chbFixeDateDue
            // 
            this.chbFixeDateDue.AutoSize = true;
            this.chbFixeDateDue.Location = new System.Drawing.Point(13, 49);
            this.chbFixeDateDue.Name = "chbFixeDateDue";
            this.chbFixeDateDue.Size = new System.Drawing.Size(100, 17);
            this.chbFixeDateDue.TabIndex = 5;
            this.chbFixeDateDue.Text = "Fixed Date Due";
            this.chbFixeDateDue.UseVisualStyleBackColor = true;
            this.chbFixeDateDue.CheckedChanged += new System.EventHandler(this.chbFixeDateDue_CheckedChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(634, 49);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(117, 23);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDueTotal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblPaidTotal);
            this.panel1.Location = new System.Drawing.Point(0, 490);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 23);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(563, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Castellar", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Lime;
            this.lblTotal.Location = new System.Drawing.Point(623, 2);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(20, 18);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Due";
            // 
            // lblDueTotal
            // 
            this.lblDueTotal.AutoSize = true;
            this.lblDueTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDueTotal.ForeColor = System.Drawing.Color.Red;
            this.lblDueTotal.Location = new System.Drawing.Point(284, 2);
            this.lblDueTotal.Name = "lblDueTotal";
            this.lblDueTotal.Size = new System.Drawing.Size(17, 18);
            this.lblDueTotal.TabIndex = 2;
            this.lblDueTotal.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Paid";
            // 
            // lblPaidTotal
            // 
            this.lblPaidTotal.AutoSize = true;
            this.lblPaidTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblPaidTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPaidTotal.Location = new System.Drawing.Point(454, 2);
            this.lblPaidTotal.Name = "lblPaidTotal";
            this.lblPaidTotal.Size = new System.Drawing.Size(17, 18);
            this.lblPaidTotal.TabIndex = 0;
            this.lblPaidTotal.Text = "0";
            // 
            // dgvTodayDue
            // 
            this.dgvTodayDue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodayDue.Location = new System.Drawing.Point(0, 84);
            this.dgvTodayDue.Name = "dgvTodayDue";
            this.dgvTodayDue.Size = new System.Drawing.Size(907, 405);
            this.dgvTodayDue.TabIndex = 8;
            this.dgvTodayDue.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(757, 50);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(117, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // DueList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(907, 513);
            this.Controls.Add(this.dgvTodayDue);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.chbFixeDateDue);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.btnTodayDue);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnDues);
            this.Controls.Add(this.dgvDue);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "DueList";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.DueList_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayDue)).EndInit();
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
        private System.Windows.Forms.Button btnDues;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private PharmacyDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnTodayDue;
        private System.Windows.Forms.DataGridView dgvDue;
        private System.Windows.Forms.CheckBox chbFixeDateDue;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPaidTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDueTotal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgvTodayDue;
        private System.Windows.Forms.Button btnRefresh;
    }
}

