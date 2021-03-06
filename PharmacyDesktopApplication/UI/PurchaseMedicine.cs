﻿using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;
using PharmacyDesktopApplication.Entities;
using PharmacyDesktopApplication.Models;
using PharmacyDesktopApplication.Models.InformationFactory;

namespace PharmacyDesktopApplication.UI
{
    public partial class PurchaseMedicine : Form
    {
        private string currentUser = "0";
        public PurchaseMedicine(string user)
        {
            currentUser = user;
            InitializeComponent();
            PharmacyDbContext db = new PharmacyDbContext();
            GetAutocompleteForMedicine(db);
            GetAutocompleteForSupplier(db);
            GetAutocompleteForCompany(db);
            GetAutocompleteForGroup(db);
            db.Dispose(); 
        }

        private void GetAutocompleteForMedicine(PharmacyDbContext db)
        {
            var source = new AutoCompleteStringCollection();
            source.AddRange(db.Medicine.ToList().Select(x => x.Name).ToArray());
            txtMedicine.AutoCompleteCustomSource = source;
        }
        private void GetAutocompleteForSupplier(PharmacyDbContext db)
        {
            var source = new AutoCompleteStringCollection();
            source.AddRange(db.Company.ToList().Select(x => x.Name).ToArray());
            txtSupplier.AutoCompleteCustomSource = source;
        }

        private void GetAutocompleteForCompany(PharmacyDbContext db)
        {
            var source = new AutoCompleteStringCollection();
            source.AddRange(db.Company.ToList().Select(x => x.Name).ToArray());
            txtCompany.AutoCompleteCustomSource = source;
        }

        private void GetAutocompleteForGroup(PharmacyDbContext db)
        {
            var source = new AutoCompleteStringCollection();
            source.AddRange(db.Groups.ToList().Select(x => x.Name).ToArray());
            txtGroup.AutoCompleteCustomSource = source;
        }

        public string GetMedicinePriceByName(string name)
        {
            PharmacyDbContext db = new PharmacyDbContext();
            string rate = db.Medicine.Where(x => x.Name == name).Select(p => p.GroupId).FirstOrDefault();
            return rate;
        }

        private void txtMedicine_Leave(object sender, System.EventArgs e)
        {
            PharmacyDbContext db = new PharmacyDbContext();
            string medicineName = txtMedicine.Text;
            var medicine = db.Medicine.Where(x => x.Name == medicineName).Select(o => new
            {
                o.UnitPrice,
                o.GroupId,
                o.CompanyId
            }).FirstOrDefault();
            if (medicine != null)
            {
                 txtUnitPrice.Text = medicine.UnitPrice.ToString();
                txtCompany.Text = db.Company.Find(medicine.CompanyId).Name;
                txtGroup.Text = db.Groups.Find(medicine.GroupId).Name;
            }
           
        }

        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            string q = "";
            if (txtQuantity.Text == "")
            {
               q  = "0";
            }
            else
            {
                q = txtQuantity.Text;
            }
            decimal qty = Convert.ToDecimal(q);
            decimal rate = Convert.ToDecimal(txtUnitPrice.Text);
            txtTotal.Text = (qty*rate).ToString();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal subTotal = 0;
            int count = 0;
            string medicine = txtMedicine.Text;
            string quantity = txtQuantity.Text;
            string rate = txtUnitPrice.Text;
            string total = txtTotal.Text;
            DateTime exDate = Convert.ToDateTime(dtpExpiredDate.Text);
            
            if (ValidateField(exDate, medicine, quantity, rate, total)) return;

            SaveMedicineIfNew();

            UpdateUnitPrice(medicine, rate, exDate);

            ListViewItem item = new ListViewItem();
            item.SubItems.Add((++count).ToString());
            item.SubItems.Add(medicine);
            item.SubItems.Add(quantity);
            item.SubItems.Add(rate);
            item.SubItems.Add(total);
            item.SubItems.Add(exDate.ToString());
            lvPurchaseMedicine.Items.Add(item);
            subTotal = Convert.ToDecimal(lblTotal.Text == "" ? "0" : lblTotal.Text) + 
                       Convert.ToDecimal(total == "" ? "0" : total);
            lblTotal.Text = subTotal.ToString();

            ClearField();
        }

        private void SaveMedicineIfNew()
        {
            PharmacyDbContext db = new PharmacyDbContext();
            Medicine medicine = new Medicine();

            medicine = db.Medicine.FirstOrDefault(a => a.Name == txtMedicine.Text);
            if (medicine != null)
            {
                medicine.Name = txtMedicine.Text;
                medicine.Id = UniqueNumber.GenerateUniqueNumber();
                medicine.CreatedBy = currentUser;
                medicine.CreatedDate = DateTime.Now;
                medicine.GroupId = GroupFactory.GetGroupId(txtGroup.Text, currentUser);
                medicine.CompanyId = CompanyFactory.GetCompanyId(txtCompany.Text, currentUser);
                db.Medicine.Add(medicine);
            }
        }

        private void UpdateUnitPrice(string medicineName, string rate, DateTime exDate)
        {
           PharmacyDbContext db = new PharmacyDbContext();
            decimal price = Convert.ToDecimal(rate);
            Medicine medicine = db.Medicine.FirstOrDefault(x => x.Name == medicineName);
            medicine.UnitPrice = price;
            medicine.ExpiredDate = exDate;
            db.SaveChanges();
            db.Dispose();
        }

        private void ClearField()
        {
            txtUnitPrice.Text = string.Empty;
            txtMedicine.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            dtpExpiredDate.Text = DateTime.Today.ToShortDateString();
        }

        private static bool ValidateField(DateTime exDate, string medicine, string quantity, string rate, string total)
        {
            if (medicine == "")
            {
                MessageBox.Show("Medicine can't be empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (quantity == "")
            {
                MessageBox.Show("Quantity can't be empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (rate == "")
            {
                MessageBox.Show("Unit Price can't be empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (total == "")
            {
                MessageBox.Show("Total can't be empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (exDate.ToShortDateString() == DateTime.Now.ToShortDateString())
            {
                MessageBox.Show("Expired date can't be Today!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void txtDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            MakeDue();
        }

        private void MakeDue()
        {
            decimal total = Convert.ToDecimal(lblTotal.Text == "" ? "0" : lblTotal.Text);
            decimal paid = Convert.ToDecimal(txtPaid.Text == "" ? "0" : txtPaid.Text);
            decimal discount = Convert.ToDecimal(txtDiscount.Text == "" ? "0" : txtDiscount.Text);
            txtDue.Text = (total - (paid + discount)).ToString();
        }

        private void txtPaid_KeyUp(object sender, KeyEventArgs e)
        {
            MakeDue();
        }

        private void btnSubmit_click(object sender, EventArgs e)
        {
            PharmacyDbContext db = new PharmacyDbContext();
            SaveInvoice(db);
            db.SaveChanges();
            db.Dispose();
            MessageBox.Show("Save successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            lvPurchaseMedicine.Items.Clear();
            txtDiscount.Text = "";
            txtDue.Text = "";
            txtPaid.Text = "";
            txtNote.Text = "";
        }

        private void SaveInvoice(PharmacyDbContext db)
        {
            Invoice invoice = new Invoice();
            invoice.Id = Guid.NewGuid().ToString(); ;
            invoice.CreatedDate = DateTime.Now;
            invoice.CreatedBy = currentUser;
            invoice.IsActive = true;
            db.Invoice.Add(invoice);
            SavePurchaseMain(db, invoice.Id);
        }

        private void SavePurchaseMain(PharmacyDbContext db, string invoiceId)
        {
          PurchaseMain main = new PurchaseMain();
            main.Id = Guid.NewGuid().ToString(); 
            main.InvoiceId = invoiceId;
            main.CreatedBy = currentUser;
            main.CreatedDate = DateTime.Now;
            main.CompanyId = CompanyFactory.GetCompanyId(txtSupplier.Text, currentUser);
            main.TotalAmount = Convert.ToDecimal(lblTotal.Text);
            main.Due = Convert.ToDecimal(txtDue.Text);
            main.Paid = Convert.ToDecimal(txtPaid.Text);
            main.Discount = Convert.ToDecimal(txtDiscount.Text);
            main.GrandTotal = (main.TotalAmount - main.Discount);
            main.Note = txtNote.Text;
            db.PurchaseMain.Add(main);
            SaveVoucher(main.GrandTotal, main.Paid, main.Due, main.CompanyId, invoiceId, db);
            SavePurchaseSub(db, main.Id);
        }

        private void SaveVoucher(decimal grandTotal, decimal paid, decimal due, string companyId, string invoiceId, PharmacyDbContext db)
        {
            int count = 1;
            //Debit Entry
            Voucher voucher = new Voucher
            {
                Id = Guid.NewGuid().ToString(),
                CompanyId = companyId,
                EntryNo = count++,
                GLCode = GLCode.PurchaseMedicine,
                Dr = grandTotal,
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
                CompanyId = companyId,
                InvoiceId = invoiceId,
                Cr = paid,
                GLCode = GLCode.Cash,
                Dr = 0,
                EntryNo = count++,
                CreatedDate = DateTime.Now,
                CreatedBy = currentUser
            };
            if(paid > 0)
            db.Voucher.Add(voucherCr1);

            Voucher voucherCr2 = new Voucher
            {
                Id = Guid.NewGuid().ToString(),
                CompanyId = companyId,
                InvoiceId = invoiceId,
                Cr = due,
                GLCode = GLCode.AccountPayable,
                Dr = 0,
                EntryNo = count++,
                CreatedDate = DateTime.Now,
                CreatedBy = currentUser
            };
            if (due > 0)
                db.Voucher.Add(voucherCr2);
        }

        private void SavePurchaseSub(PharmacyDbContext db, string purchaseMainId)
        {
            foreach (ListViewItem item in lvPurchaseMedicine.Items)
            {
                PurchaseSub sub = new PurchaseSub();
                sub.Id = Guid.NewGuid().ToString();
                sub.MainId = purchaseMainId;
                sub.MedicinId = MedicineFactory.GetMedicineIdByName(item.SubItems[2].Text, db);
                sub.Quantity = Convert.ToInt32(item.SubItems[3].Text);
                sub.UnitPrice = Convert.ToDecimal(item.SubItems[4].Text);
                sub.Total = Convert.ToDecimal(item.SubItems[5].Text);
                sub.CreatedBy = currentUser;
                sub.CreatedDate = DateTime.Now;
                db.PurchaseSub.Add(sub);
            }
        }
    }
}
