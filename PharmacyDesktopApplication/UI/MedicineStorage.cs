using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PharmacyDesktopApplication.Entities;
using PharmacyDesktopApplication.Models;

namespace PharmacyDesktopApplication.UI
{
    public partial class MedicineStorage : Form
    {
        private IEnumerable<Store> medicineStore = null;   
        public MedicineStorage()
        {
            InitializeComponent();
        }

        private void DueList_Load(object sender, EventArgs e)
        {
            SetLabelValue();
            medicineStore = MedicineStore();
            dgvStorage.DataSource = medicineStore;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SetLabelValue()
        {
            PharmacyDbContext db = new PharmacyDbContext();
            lblMedicine.Text = db.Medicine.Count().ToString();
            lblGroup.Text = db.Groups.Count().ToString();
            lblcompany.Text = db.Company.Count().ToString();
            db.Dispose();
        }
        private IEnumerable<Store> MedicineStore()
        {
            PharmacyDbContext db = new PharmacyDbContext();
            var data = db.Medicine
                .OrderByDescending(o => o.ExpiredDate)
                .Include(s => s.Groups)
                .Include(i => i.Company)
                .ToList()
                .GroupBy(g => g.Id)
                .Select(s => new
                {
                    Id = s.Key,
                    MedicineName = s.Select(a => a.Name).FirstOrDefault(),
                    Type = s.Select(a => a.MedicineType).FirstOrDefault(),
                    ExpiredDate = s.Select(a => a.ExpiredDate).FirstOrDefault(),
                    Group = s.Select(a=>a.GroupId).FirstOrDefault(),
                    Company = s.Select(a => a.Company.Name).FirstOrDefault(),
                    Purchased = s.Sum(a => a.PurchaseSub.Sum(x => x.Quantity)),
                    Sale = s.Sum(a => a.SaleSub.Sum(x => x.Quantity)),
                    Balance = s.Sum(a => a.PurchaseSub.Sum(x => x.Quantity)) - s.Sum(a => a.SaleSub.Sum(x => x.Quantity))
                })
                .ToList();
            List<Store> storages = new List<Store>();
            foreach (var item in data)
            {
                Store store = new Store();
                store.Id = item.Id;
                store.Name = item.MedicineName;
                store.Company = item.Company;
                store.ExpiredDate = item.ExpiredDate;
                store.GroupName = GetGroup(item.Group);
                store.Purchased = GetPurchaseMedicine(item.Id);
                store.Sold = GetSaleMedicine(item.Id);
                store.Balance = store.Purchased - store.Sold;
                storages.Add(store);
            }
            db.Dispose();
            return storages;
        }
        private string GetGroup(string id)
        {
            PharmacyDbContext db = new PharmacyDbContext();
           string name = db.Groups.Where(g => g.Id == id).Select(s => s.Name).FirstOrDefault();
            db.Dispose();
            return name;
        }
        private decimal GetPurchaseMedicine(string medicineId)              
        {
            PharmacyDbContext db = new PharmacyDbContext();
            var count = db.PurchaseSub.Where(m => m.MedicinId == medicineId)
                .ToList()
                .Sum(x => x.Quantity);
            
            db.Dispose();
            return count;
        }
        private decimal GetSaleMedicine(string medicineId)
        {
            PharmacyDbContext db = new PharmacyDbContext();
            var count = db.SaleSub.Where(m => m.MedicinId == medicineId)
                .ToList()
                .Sum(x => x.Quantity);
            db.Dispose();
            return count;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            dgvStorage.Columns.Clear();
            dgvStorage.DataSource = medicineStore.Where(s => s.Name.ToLower().Contains(keyword.ToLower())).ToList(); ;
        }

        private void dgvStorage_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvStorage.Columns[e.ColumnIndex].Name.Equals("Balance"))
            {
                int val;
                if (int.TryParse(e.Value.ToString(), out val) && (val < 5))
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.SelectionBackColor = Color.DarkRed;
                }
            }
            if (dgvStorage.Columns[e.ColumnIndex].Name.Equals("ExpiredDate"))
            {
                if (Convert.ToDateTime(e.Value.ToString()).AddMonths(-2) < DateTime.Today)
                {
                    e.CellStyle.BackColor = Color.Gold;
                    e.CellStyle.SelectionBackColor = Color.DarkOrange;
                }
            }
        }
    }
}
