using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyDesktopApplication.Entities;

namespace PharmacyDesktopApplication.UI
{
    public partial class MedicineEditForm : Form
    {
        public MedicineEditForm()
        {
            InitializeComponent();
        }
        public MedicineEditForm(string purchaseId)
        {
            InitializeComponent();
            ShowMedicineDetails(purchaseId);
        }

        private void ShowMedicineDetails(string id)
        {
            PharmacyDbContext db = new PharmacyDbContext();
            var purchase =
                db.PurchaseSub.Where(a => a.Id == id).OrderByDescending(a => a.CreatedDate).Select(s => new
                {
                  s.Id,
                  s.MedicinId,
                  s.Quantity,
                  s.UnitPrice,
                }).FirstOrDefault();
            if (purchase != null)
            {
                Medicine medicine = db.Medicine.Find(purchase.MedicinId);
                txtMedicineName.Text = medicine.Name;
                dtpExpiredDate.Value = medicine.ExpiredDate;
                txtQuantity.Text = purchase.Quantity.ToString();
                txtUnitPrice.Text = purchase.UnitPrice.ToString(CultureInfo.CurrentCulture);
                medicineId.Text = purchase.MedicinId;
                purchasedId.Text = purchase.Id;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PharmacyDbContext db = new PharmacyDbContext();
            PurchaseSub sub = db.PurchaseSub.FirstOrDefault(a => a.Id == purchasedId.Text);
            if (sub != null)
            {
                sub.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                sub.Quantity = int.Parse(txtQuantity.Text);
                sub.Total = (sub.Quantity*sub.UnitPrice);
                db.PurchaseSub.AddOrUpdate(sub);
            }
            Medicine medicine = db.Medicine.FirstOrDefault(a => a.Id == medicineId.Text);
            if (medicine != null)
            {
                medicine.ExpiredDate = dtpExpiredDate.Value;
                db.Medicine.AddOrUpdate(medicine);
            }
            db.SaveChanges();
            MessageBox.Show(@"Update successful!", "Success", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
