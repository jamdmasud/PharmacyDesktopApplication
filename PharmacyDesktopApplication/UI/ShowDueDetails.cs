using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyDesktopApplication.Entities;
using PharmacyDesktopApplication.Models;

namespace PharmacyDesktopApplication.UI
{
    partial class ShowDueDetails : Form
    {
        private readonly string _customerId;
        private string currentUser = "0";

        public ShowDueDetails(List<SaleDetail> saleDetail, string customerId, string user)
        {
            currentUser = user;
            _customerId = customerId;
            InitializeComponent();
            dgvSaleDetails.DataSource = saleDetail;
            PharmacyDbContext db = new PharmacyDbContext();
            lblDue.Text = Convert.ToString(db.Voucher
                .Where(x=>x.GLCode == GLCode.AccountReceivable && x.CustomerId == _customerId)
                .Sum(a => a.Dr - a.Cr));
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            PharmacyDbContext db = new PharmacyDbContext();
            SaveInvoice(db);
            db.SaveChanges();
            db.Dispose();
            MessageBox.Show("Save successful", "Paid!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void SaveInvoice(PharmacyDbContext db)
        {
            Invoice invoice = new Invoice
            {
                Id = Guid.NewGuid().ToString(),
                IsActive = true,
                CreatedBy = currentUser,
                CreatedDate = DateTime.Now
            };
            db.Invoice.Add(invoice);
            SaveDuePayment(db, invoice.Id);
            UpdateCustomerMain(db);
        }

        private void UpdateCustomerMain(PharmacyDbContext db)
        {
            SaleMain main =
                db.SaleMain.Where(a => a.CustomerId == _customerId).OrderByDescending(x => x.Id).FirstOrDefault();
            
            main.DuePaid += Convert.ToDecimal(txtDuePay.Text);
            db.Entry(main).State = EntityState.Modified;
        }

        private void SaveDuePayment(PharmacyDbContext db, string invoiceId)
        {
            decimal amount = Convert.ToDecimal(txtDuePay.Text);
            DuePayment due = new DuePayment
            {
                Amount = amount,
                CreatedDate = DateTime.Now,
                CreatedBy = currentUser,
                CustomerId = _customerId,
                Id = Guid.NewGuid().ToString(),
                InvoiceId = invoiceId
            };
            db.DuePayment.Add(due);
            SaveVoucher(db, invoiceId, amount);
        }

        private void SaveVoucher(PharmacyDbContext db, string invoiceId, decimal amount)
        {
            int count = 1;
            //Debit entry
                Voucher voucher = new Voucher
                {
                    Id = Guid.NewGuid().ToString(),
                    CustomerId = _customerId,
                    EntryNo = count++,
                    GLCode = GLCode.Cash,
                    Dr = amount,
                    Cr = 0,
                    InvoiceId = invoiceId,
                    CreatedDate = DateTime.Now,
                    CreatedBy = currentUser
                };
                db.Voucher.Add(voucher);
           //credit entry
                Voucher voucherCr2 = new Voucher
                {
                    Id = Guid.NewGuid().ToString(),
                    CustomerId = _customerId,
                    Cr = amount,
                    GLCode = GLCode.AccountReceivable,
                    Dr = 0,
                    InvoiceId = invoiceId,
                    EntryNo = count,
                    CreatedDate = DateTime.Now,
                    CreatedBy = currentUser
                };
                db.Voucher.Add(voucherCr2);
            }
    }
}
