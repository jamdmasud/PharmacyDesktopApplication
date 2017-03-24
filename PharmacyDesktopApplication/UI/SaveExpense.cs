using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PharmacyDesktopApplication.Entities;
using PharmacyDesktopApplication.Models;
using PharmacyDesktopApplication.Models.InformationFactory;

namespace PharmacyDesktopApplication.UI
{
    public partial class saveExpense : Form
    {
        private string currentUser = "0";

        public saveExpense(string user)
        {
            currentUser = user;
            InitializeComponent();
            PharmacyDbContext db = new PharmacyDbContext();
            List<ExpenseType> types = db.ExpenseType.ToList();
            ExpenseType first = new ExpenseType
            {
                Id = "0",
                Type = "-- select one --"
            };
            types.Insert(0, first);
            cbExpenseType.DataSource = types;
            cbExpenseType.DisplayMember = "Type";// types.Select(o => o.Type).ToString();
            cbExpenseType.ValueMember = "Id";// types.Select(o => o.Id).ToString();
            db.Dispose(); 
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int count = 1;
            decimal subTotal = 0;
            string expenseType = cbExpenseType.SelectedValue.ToString();
            string expense = cbExpenseType.Text;
            decimal amount = Convert.ToDecimal(txtAmount.Text == "" ? "0" : txtAmount.Text);
            DateTime date = dtpDate.Value;
            if (expenseType == "0")
            {
                MessageBox.Show("Please select expense Type!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (amount == 0)
            {
                MessageBox.Show("Amount can't be zero or empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ListViewItem item = new ListViewItem();
            item.SubItems.Add((++count).ToString());
            item.SubItems.Add(expense);
            item.SubItems.Add(amount.ToString());
            item.SubItems.Add(date.ToShortDateString());
            lvExpense.Items.Add(item);

            subTotal = Convert.ToDecimal(lblTotal.Text == "" ? "0" : lblTotal.Text) + amount;
            lblTotal.Text = subTotal.ToString();
            ClearField();
        }

        private void ClearField()
        {
            txtAmount.Text = "0";
            cbExpenseType.SelectedIndex = 0;
            dtpDate.Value = DateTime.Now;
        }
        
        private void btnSubmit_click(object sender, EventArgs e)
        {
            PharmacyDbContext db = new PharmacyDbContext();
            SaveInvoice(db);
            db.SaveChanges();
            db.Dispose();
            MessageBox.Show("Save successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnPrint.Enabled = true;
            txtNote.Text = "";
            lvExpense.Items.Clear();
        }

        private void SaveInvoice(PharmacyDbContext db)
        {
            Invoice invoice = new Invoice
            {
                Id = Guid.NewGuid().ToString(),
                CreatedDate = DateTime.Now,
                CreatedBy = currentUser,
                IsActive = true
            };
            db.Invoice.Add(invoice);
            SaveExpenseMain(db, invoice.Id);
        }

        private void SaveExpenseMain(PharmacyDbContext db, string invoiceId)
        {
            decimal total = Convert.ToDecimal(lblTotal.Text == "" ? "0" : lblTotal.Text);
            ExpenseMain main = new ExpenseMain
            {
                Id = Guid.NewGuid().ToString(),
                TotalAmount = total,
                InvoiceId = invoiceId,
                Note = txtNote.Text,
                CreatedBy = currentUser,
                CreatedDate =  DateTime.Now
            };
            db.ExpenseMain.Add(main);
            SaveVoucher(total, invoiceId, db);
            SaveExpenseSub(db, main.Id);
        }

        private void SaveExpenseSub(PharmacyDbContext db, string mainId)
        {
            foreach (ListViewItem item in lvExpense.Items)
            {
                ExpenseSub sub = new ExpenseSub
                {
                    Id = Guid.NewGuid().ToString(),
                    ExpenseType = item.SubItems[2].Text,
                    Amount = Convert.ToDecimal(item.SubItems[3].Text),
                    MainId = mainId,
                    CreatedBy = currentUser,
                    CreatedDate = Convert.ToDateTime(item.SubItems[4].Text)
                };
                db.ExpenseSub.Add(sub);
            }
        }
        
        private void SaveVoucher(decimal total, string invoiceId, PharmacyDbContext db)
        {
            int count = 1;
            //Debit Entry
        
                Voucher voucher = new Voucher
                {
                    Id = Guid.NewGuid().ToString(),
                    EntryNo = count++,
                    GLCode = GLCode.Expense,
                    Dr = total,
                    Cr = 0,
                    InvoiceId = invoiceId,
                    CreatedDate = DateTime.Now,
                    CreatedBy = currentUser
                };
                db.Voucher.Add(voucher);
            

            //Credit Entry
            Voucher voucherCr1 = new Voucher
            {
                Id = Guid.NewGuid().ToString(),
                Cr = total,
                GLCode = GLCode.Cash,
                Dr = 0,
                EntryNo = count++,
                InvoiceId = invoiceId,
                CreatedDate = DateTime.Now,
                CreatedBy = currentUser
            };
            db.Voucher.Add(voucherCr1);
        }

        private void cbExpenseType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
