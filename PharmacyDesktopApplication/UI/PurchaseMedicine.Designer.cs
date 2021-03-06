﻿namespace PharmacyDesktopApplication.UI
{
    partial class PurchaseMedicine
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
            this.txtMedicine = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvPurchaseMedicine = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.medicine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExpiredDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.txtDue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dtpExpiredDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMedicine
            // 
            this.txtMedicine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMedicine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMedicine.Location = new System.Drawing.Point(32, 30);
            this.txtMedicine.Name = "txtMedicine";
            this.txtMedicine.Size = new System.Drawing.Size(115, 20);
            this.txtMedicine.TabIndex = 0;
            this.txtMedicine.Leave += new System.EventHandler(this.txtMedicine_Leave);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(31, 11);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(50, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Medicine";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(258, 30);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(85, 20);
            this.txtQuantity.TabIndex = 0;
            this.txtQuantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(160, 30);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(85, 20);
            this.txtUnitPrice.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Unit Price";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(356, 30);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(127, 20);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(620, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvPurchaseMedicine
            // 
            this.lvPurchaseMedicine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.SL,
            this.medicine,
            this.quantity,
            this.unitPrice,
            this.total,
            this.ExpiredDate});
            this.lvPurchaseMedicine.Location = new System.Drawing.Point(32, 107);
            this.lvPurchaseMedicine.Name = "lvPurchaseMedicine";
            this.lvPurchaseMedicine.Size = new System.Drawing.Size(663, 169);
            this.lvPurchaseMedicine.TabIndex = 3;
            this.lvPurchaseMedicine.UseCompatibleStateImageBehavior = false;
            this.lvPurchaseMedicine.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // SL
            // 
            this.SL.Text = "SL";
            // 
            // medicine
            // 
            this.medicine.Text = "Medicine";
            this.medicine.Width = 160;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            this.quantity.Width = 100;
            // 
            // unitPrice
            // 
            this.unitPrice.Text = "Unit Price";
            this.unitPrice.Width = 100;
            // 
            // total
            // 
            this.total.Text = "Total";
            this.total.Width = 120;
            // 
            // ExpiredDate
            // 
            this.ExpiredDate.Text = "Expired Date";
            this.ExpiredDate.Width = 117;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Rockwell Extra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(539, 282);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 22);
            this.lblTotal.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell Extra Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(431, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(28, 331);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(154, 20);
            this.txtDiscount.TabIndex = 6;
            this.txtDiscount.Text = "0";
            this.txtDiscount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDiscount_KeyUp);
            // 
            // txtPaid
            // 
            this.txtPaid.Location = new System.Drawing.Point(198, 331);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(154, 20);
            this.txtPaid.TabIndex = 6;
            this.txtPaid.Text = "0";
            this.txtPaid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPaid_KeyUp);
            // 
            // txtDue
            // 
            this.txtDue.Location = new System.Drawing.Point(368, 331);
            this.txtDue.Name = "txtDue";
            this.txtDue.ReadOnly = true;
            this.txtDue.Size = new System.Drawing.Size(154, 20);
            this.txtDue.TabIndex = 6;
            this.txtDue.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Discount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Paid";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Due";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(538, 365);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(154, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(538, 400);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(154, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print Voucher";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // dtpExpiredDate
            // 
            this.dtpExpiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiredDate.Location = new System.Drawing.Point(489, 29);
            this.dtpExpiredDate.Name = "dtpExpiredDate";
            this.dtpExpiredDate.Size = new System.Drawing.Size(116, 20);
            this.dtpExpiredDate.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(486, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Expired Date";
            // 
            // txtSupplier
            // 
            this.txtSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSupplier.Location = new System.Drawing.Point(538, 331);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(154, 20);
            this.txtSupplier.TabIndex = 6;
            this.txtSupplier.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPaid_KeyUp);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(28, 366);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(494, 57);
            this.txtNote.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(535, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Supplier";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(255, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Company";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(31, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Group";
            // 
            // txtCompany
            // 
            this.txtCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCompany.Location = new System.Drawing.Point(258, 77);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(347, 20);
            this.txtCompany.TabIndex = 14;
            // 
            // txtGroup
            // 
            this.txtGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGroup.Location = new System.Drawing.Point(32, 77);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(213, 20);
            this.txtGroup.TabIndex = 11;
            // 
            // PurchaseMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 439);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.dtpExpiredDate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDue);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lvPurchaseMedicine);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtMedicine);
            this.Name = "PurchaseMedicine";
            this.Text = "PurchaseMedicine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMedicine;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvPurchaseMedicine;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader SL;
        private System.Windows.Forms.ColumnHeader medicine;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader unitPrice;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.TextBox txtDue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DateTimePicker dtpExpiredDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader ExpiredDate;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtGroup;
    }
}