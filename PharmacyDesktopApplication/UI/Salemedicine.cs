using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;
using PharmacyDesktopApplication.Entities;
using PharmacyDesktopApplication.Models;
using PharmacyDesktopApplication.Models.InformationFactory;
using Company = PharmacyDesktopApplication.Models.InformationFactory.Company;

namespace PharmacyDesktopApplication.UI
{
    public partial class Salemedicine : Form
    {
        private string currentUser = "0";

        public Salemedicine(string user)
        {
            currentUser = user;
            InitializeComponent();
            PharmacyDbContext db = new PharmacyDbContext();
            GetAutocompleteForMedicine(db);
            GetAutocompleteForCustomer(db);
            db.Dispose(); 
        }

        private void GetAutocompleteForMedicine(PharmacyDbContext db)
        {
            var source = new AutoCompleteStringCollection();
            source.AddRange(db.Medicine.ToList().Select(x => x.Name).ToArray());
            txtMedicine.AutoCompleteCustomSource = source;
        }

        private void GetAutocompleteForCustomer(PharmacyDbContext db)
        {
            var source = new AutoCompleteStringCollection();
            source.AddRange(db.Customer.ToList().Select(x =>  x.Name+". Mobile: "+ x.Mobile).ToArray());
            txtCustomerName.AutoCompleteCustomSource = source;
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
            string medicine = txtMedicine.Text;
            decimal rate = db.Medicine.Where(x => x.Name == medicine).Select(o => o.UnitPrice).FirstOrDefault();
            txtUnitPrice.Text = rate.ToString();
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

        private bool hasMadicineInStore(string medicine, string qty)
        {
            PharmacyDbContext db = new PharmacyDbContext();
            string medicineId = MedicineFactory.GetMedicineIdByName(medicine, db);
            int totalPurchased = db.PurchaseSub.Where(i => i.MedicinId == medicineId).ToList().Sum(o => o.Quantity);
            int totalSale = db.SaleSub.Where(i => i.MedicinId == medicineId).ToList().Sum(o => o.Quantity);
            bool result = totalPurchased > (totalSale + Convert.ToInt32(qty));
            return result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal subTotal = 0;
            int count = 0;
            string medicine = txtMedicine.Text;
            string quantity = txtQuantity.Text;
            string rate = txtUnitPrice.Text;
            string total = txtTotal.Text;
            if (!hasMadicineInStore(medicine, quantity))
            {
                MessageBox.Show("The medicine are you trying to sell is not in your store!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ValidateField(medicine, quantity, rate, total)) return;

            
            ListViewItem item = new ListViewItem();
            item.SubItems.Add((++count).ToString());
            item.SubItems.Add(medicine);
            item.SubItems.Add(quantity);
            item.SubItems.Add(rate);
            item.SubItems.Add(total);
            lvPurchaseMedicine.Items.Add(item);
            subTotal = Convert.ToDecimal(lblTotal.Text == "" ? "0" : lblTotal.Text) + 
                       Convert.ToDecimal(total == "" ? "0" : total);
            lblTotal.Text = subTotal.ToString();

            ClearField();
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
        }

        private static bool ValidateField(string medicine, string quantity, string rate, string total)
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
            
            return false;
        }

        private void txtDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            MakeDue();
            SetGrandTotal();
        }

        private void SetGrandTotal()
        {
            decimal total = Convert.ToDecimal(lblTotal.Text == "" ? "0" : lblTotal.Text);
            decimal discount = Convert.ToDecimal(txtDiscount.Text == "" ? "0" : txtDiscount.Text);
            txtGrandTotal.Text = (total - discount).ToString();
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

            ClearFields();
        }

        private void ClearFields()
        {
            txtDiscount.Text = "0";
            txtPaid.Text = "0";
            txtGrandTotal.Text = "0";
            lvPurchaseMedicine.Items.Clear();
            txtNote.Text = String.Empty;
            txtCustomerName.Text = String.Empty;
            txtPhone.Text = String.Empty;
        }

        private void SaveInvoice(PharmacyDbContext db)
        {
            Invoice invoice = new Invoice();
            invoice.Id = Guid.NewGuid().ToString();
            invoice.CreatedDate = DateTime.Now;
            invoice.CreatedBy = currentUser;
            invoice.IsActive = true;
            db.Invoice.Add(invoice);
            SaveSaleMain(db, invoice.Id);
        }

        private void SaveSaleMain(PharmacyDbContext db, string invoiceId)
        {
            string customerName = txtCustomerName.Text;
            string[] name = customerName.Split('.');
            customerName = name[0].Trim();
            SaleMain main = new SaleMain();
            main.Id = Guid.NewGuid().ToString(); 
            main.InvoiceId = invoiceId;
            main.CreatedBy = currentUser;
            main.CreatedDate = DateTime.Now;
            main.CustomerId = GetCustomerIdByName(customerName, db);//.GetCompanyId(txtGrandTotal.Text, db, currentUser);
            main.TotalAmount = Convert.ToDecimal(lblTotal.Text);
            main.Due = Convert.ToDecimal(txtDue.Text);
            main.Paid = Convert.ToDecimal(txtPaid.Text);
            main.Discount = Convert.ToDecimal(txtDiscount.Text);
            main.GrandTotal = (main.TotalAmount - main.Discount);
            main.Note = txtNote.Text;
            db.SaleMain.Add(main);
            SaveVoucher(main.GrandTotal, main.Paid, main.Due, main.CustomerId, invoiceId, db);
            
            SaveSaleSub(db, main.Id);
        }

        private void SaveVoucher(decimal grandTotal, decimal paid, decimal due, string customerId, string invoiceId, PharmacyDbContext db)
        {
            int count = 1;
            //Debit Entry
            if (paid > 0)
            {
                Voucher voucher = new Voucher
                {
                    Id = Guid.NewGuid().ToString(),
                    CustomerId = customerId,
                    EntryNo = count++,
                    GLCode = GLCode.Cash,
                    Dr = paid,
                    Cr = 0,
                    InvoiceId = invoiceId,
                    CreatedDate = DateTime.Now,
                    CreatedBy = currentUser
                };
                db.Voucher.Add(voucher);
            }
            if (due > 0)
            {
                Voucher voucherCr2 = new Voucher
                {
                    Id = Guid.NewGuid().ToString(),
                    CustomerId = customerId,
                    Cr = 0,
                    GLCode = GLCode.AccountReceivable,
                    Dr = due,
                    InvoiceId = invoiceId,
                    EntryNo = count++,
                    CreatedDate = DateTime.Now,
                    CreatedBy = currentUser
                };
                db.Voucher.Add(voucherCr2);
            }

            //Credit Entry
            Voucher voucherCr1 = new Voucher
            {
                Id = Guid.NewGuid().ToString(),
                CustomerId = customerId,
                Cr = grandTotal,
                GLCode = GLCode.SaleMedicine,
                Dr = 0,
                EntryNo = count++,
                InvoiceId = invoiceId,
                CreatedDate = DateTime.Now,
                CreatedBy = currentUser
            };
            db.Voucher.Add(voucherCr1);
        }

        private void SaveSaleSub(PharmacyDbContext db, string purchaseMainId)
        {
            foreach (ListViewItem item in lvPurchaseMedicine.Items)
            {
                SaleSub sub = new SaleSub();
                sub.Id = Guid.NewGuid().ToString();
                sub.MainId = purchaseMainId;
                sub.MedicinId = MedicineFactory.GetMedicineIdByName(item.SubItems[2].Text, db);
                sub.Quantity = Convert.ToInt32(item.SubItems[3].Text);
                sub.UnitPrice = Convert.ToDecimal(item.SubItems[4].Text);
                sub.Total = Convert.ToDecimal(item.SubItems[5].Text);
                sub.CreatedBy = currentUser;
                sub.CreatedDate = DateTime.Now;
                db.SaleSub.Add(sub);
            }
        }

        public  string GetCustomerIdByName(string name, PharmacyDbContext db)
        {
            if (name == "") name = "Unknown";
            Customer customer = db.Customer.FirstOrDefault(i => i.Name == name);
            if (customer != null) return customer.Id;
            else
            {
                customer = new Customer
                {
                    Id = UniqueNumber.GenerateUniqueNumber(),
                    Name = name,
                    Mobile = txtPhone.Text,
                    CreatedBy = currentUser,
                    CreatedDate = DateTime.Now
                };
                db.Customer.Add(customer);
                db.SaveChanges();
                return customer.Id;
            }
        }
    }
}
