using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PharmacyDesktopApplication.Entities;
using PharmacyDesktopApplication.Models;

namespace PharmacyDesktopApplication.UI
{
    public partial class PurchaseMedicinesList : Form
    {
        public List<SaleDetail> sale = null;
        private int _count = 0;
        public PurchaseMedicinesList()
        {
            InitializeComponent();
        }


        private void DueList_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            List<PurchaseList> list =  new List<PurchaseList>();
            PharmacyDbContext db = new PharmacyDbContext();
            int rowNo = 1;
            var data = db.PurchaseSub
                .ToList()
                .Select(x => new 
                {
                    SL = rowNo++,
                    x.MedicinId,
                    x.Quantity,
                    x.UnitPrice,
                    x.Total,
                    Date = x.CreatedDate.ToString("d")
                }).ToList();

            foreach (var item in data)
            {
                PurchaseList l = new PurchaseList
                {
                    SL = item.SL.ToString(),
                    MedicineName = GetMedicineName(item.MedicinId),
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,
                    Total = item.Total,
                    Date = item.Date
                };
                list.Add(l);
            }

            lblDueTotal.Text = db.PurchaseSub.Sum(x => x.Total).ToString();     // db.Voucher.Where(a => a.GLCode == GLCode.AccountReceivable && a.CustomerId != null).ToList().Sum(x => x.Dr-x.Cr).ToString();
                 // db.Voucher.Where(a => a.GLCode == GLCode.SaleMedicine && a.CustomerId != null).ToList().Sum(x => x.Cr).ToString();
            db.Dispose();
            dgvExpense.Columns.Clear();
            dgvExpense.DataSource = list;
            MakeFullWidthScreen();
        }

        private string GetMedicineName(string id)
        {
            PharmacyDbContext db = new PharmacyDbContext();
            string name = db.Medicine.Where(s => s.Id == id).Select(a => a.Name).FirstOrDefault();
            db.Dispose();
            return name;
        }

        private void MakeFullWidthScreen()
        {
            dgvExpense.DataBindingComplete += (o, _) =>
            {
                var dataGridView = o as DataGridView;
                if (dataGridView != null)
                {
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

            };
            dgvExpense.Columns[0].Width = 60;
        }
       

        private void chbFixeDateDue_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFixeDatePurchase.Checked)
            {
                dtpEndDate.Visible = false;
            }
            else
            {
                dtpEndDate.Visible = true;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (chbFixeDatePurchase.Checked)
            {
                FixedDateExpense();
            }
            else
            {
                DateRangeExpense();
            }
            
        }
        private void DateRangeExpense()
        {
            DateTime sdate = Convert.ToDateTime(dtpStartDate.Text);
            DateTime edate = Convert.ToDateTime(dtpEndDate.Text);
            List<PurchaseList> list = new List<PurchaseList>();
            PharmacyDbContext db = new PharmacyDbContext();
            int rowNo = 1;
            var data = db.PurchaseSub
                .Where(a=>a.CreatedDate >= sdate && a.CreatedDate <= edate)
                .ToList()
                .Select(x => new
                {
                    SL = rowNo++,
                    x.MedicinId,
                    x.Quantity,
                    x.UnitPrice,
                    x.Total,
                    Date = x.CreatedDate.ToString("d")
                }).ToList();

            foreach (var item in data)
            {
                PurchaseList l = new PurchaseList
                {
                    SL = item.SL.ToString(),
                    MedicineName = GetMedicineName(item.MedicinId),
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,
                    Total = item.Total,
                    Date = item.Date
                };
                list.Add(l);
            }

            lblDueTotal.Text = db.PurchaseSub
                .ToList()
                .Where(a => a.CreatedDate >= sdate && a.CreatedDate <= edate)
                .Sum(x => x.Total).ToString();     // db.Voucher.Where(a => a.GLCode == GLCode.AccountReceivable && a.CustomerId != null).ToList().Sum(x => x.Dr-x.Cr).ToString();
                                                                                // db.Voucher.Where(a => a.GLCode == GLCode.SaleMedicine && a.CustomerId != null).ToList().Sum(x => x.Cr).ToString();
            db.Dispose();
            dgvExpense.Columns.Clear();
            dgvExpense.DataSource = list;
            MakeFullWidthScreen();
        }
        private void FixedDateExpense()
        {
            DateTime date = Convert.ToDateTime(dtpStartDate.Text);
            List<PurchaseList> list = new List<PurchaseList>();
            PharmacyDbContext db = new PharmacyDbContext();
            int rowNo = 1;
            var data = db.PurchaseSub
                .ToList()
                .Where(a=>a.CreatedDate.ToShortDateString() == date.ToShortDateString())
                .Select(x => new
                {
                    SL = rowNo++,
                    x.MedicinId,
                    x.Quantity,
                    x.UnitPrice,
                    x.Total,
                    Date = x.CreatedDate.ToString("d")
                }).ToList();

            foreach (var item in data)
            {
                PurchaseList l = new PurchaseList
                {
                    SL = item.SL.ToString(),
                    MedicineName = GetMedicineName(item.MedicinId),
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,
                    Total = item.Total,
                    Date = item.Date
                };
                list.Add(l);
            }

            lblDueTotal.Text = db.PurchaseSub
                .ToList()
                .Where(a => a.CreatedDate.ToShortDateString() == date.ToShortDateString())
                .Sum(x => x.Total).ToString();     // db.Voucher.Where(a => a.GLCode == GLCode.AccountReceivable && a.CustomerId != null).ToList().Sum(x => x.Dr-x.Cr).ToString();
                                                                                // db.Voucher.Where(a => a.GLCode == GLCode.SaleMedicine && a.CustomerId != null).ToList().Sum(x => x.Cr).ToString();
            db.Dispose();
            dgvExpense.Columns.Clear();
            dgvExpense.DataSource = list;
            MakeFullWidthScreen();
        }

     

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
