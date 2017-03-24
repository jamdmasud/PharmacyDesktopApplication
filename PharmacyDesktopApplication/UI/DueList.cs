using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using PharmacyDesktopApplication.Entities;
using PharmacyDesktopApplication.Models;
using PharmacyDesktopApplication.UI;

namespace PharmacyDesktopApplication.UI
{
    public partial class DueList : Form
    {
        private readonly string _user;
        public List<SaleDetail> sale = null;
        private int _count = 0;
        public DueList(string _user)
        {
            this._user = _user;
            InitializeComponent();
        }


        private void DueList_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            PharmacyDbContext db = new PharmacyDbContext();
            int rowNo = 1;
            var data = db.Voucher
                .Where(a => a.CustomerId != null)
                .ToList().GroupBy(o => o.CustomerId)
                .Select(x => new
                {
                    SL = rowNo++,
                    CustomerId = x.Key,
                    CustomerName = x.Select(a => a.Customer.Name).FirstOrDefault(),
                    Mobile = x.Select(a => a.Customer.Mobile).FirstOrDefault(),
                    Due = x.Where(c => c.GLCode == GLCode.AccountReceivable).Sum(a => a.Dr - a.Cr) < 0 ? 0 : x.Where(c => c.GLCode == GLCode.AccountReceivable).Sum(a => a.Dr - a.Cr),
                    Paid = x.Where(c => c.GLCode == GLCode.Cash).Sum(a => a.Dr),
                    TotalSale = x.Where(c => c.GLCode == GLCode.SaleMedicine).Sum(a => a.Cr),
                    Date = x.Select(a => a.CreatedDate).FirstOrDefault().ToString("d")
                }).ToList();
            lblDueTotal.Text = data.Sum(x => x.Due).ToString();     // db.Voucher.Where(a => a.GLCode == GLCode.AccountReceivable && a.CustomerId != null).ToList().Sum(x => x.Dr-x.Cr).ToString();
            lblPaidTotal.Text = data.Sum(x => x.Paid).ToString();   //db.Voucher.Where(a=>a.GLCode == GLCode.Cash && a.CustomerId != null).ToList().Sum(x => x.Dr).ToString();
            lblTotal.Text = data.Sum(x => x.TotalSale).ToString();      // db.Voucher.Where(a => a.GLCode == GLCode.SaleMedicine && a.CustomerId != null).ToList().Sum(x => x.Cr).ToString();
            db.Dispose();
            dgvDue.Columns.Clear();
            dgvDue.DataSource = data;

            AddButton();
            MakeFullWidthScreen();
        }
       
        private void AddButton()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "View Details";
            btn.Text = "View";
            btn.UseColumnTextForButtonValue = true;
            btn.Name = "btn";
            dgvDue.Columns.Add(btn);
        }

        private void MakeFullWidthScreen()
        {
            dgvDue.DataBindingComplete += (o, _) =>
            {
                var dataGridView = o as DataGridView;
                if (dataGridView != null)
                {
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

            };
            dgvDue.Columns[0].Width = 60;
        }
        private void btnTodayDue_Click(object sender, EventArgs e)
        {
            
            DateTime today = DateTime.Today;
            PharmacyDbContext db = new PharmacyDbContext();
            int rowNo = 1;
            var data = db.Voucher
                .ToList()
                .Where(d => d.CreatedDate.Date == today.Date && d.CustomerId != null)
                .GroupBy(o => o.CustomerId)
                .Select(x => new
                {
                    SL = rowNo++,
                    CustomerId = x.Key,
                    CustomerName = x.Select(a => a.Customer.Name).FirstOrDefault(),
                    Mobile = x.Select(a => a.Customer.Mobile).FirstOrDefault(),
                    Due = x.Where(c => c.GLCode == GLCode.AccountReceivable).Sum(a => a.Dr - a.Cr) < 0 ? 0 : x.Where(c => c.GLCode == GLCode.AccountReceivable).Sum(a => a.Dr - a.Cr),
                    Paid = x.Where(c => c.GLCode == GLCode.Cash).Sum(a => a.Dr),
                    TotalSale = x.Where(c => c.GLCode == GLCode.SaleMedicine).Sum(a => a.Cr),
                    Date = x.Select(a => a.CreatedDate).FirstOrDefault().ToString("d")
                }).ToList();
            db.Dispose();
            dgvDue.Columns.Clear();
            dgvDue.DataSource = data;

            lblDueTotal.Text = data.Sum(x => x.Due).ToString();     // db.Voucher.Where(a => a.GLCode == GLCode.AccountReceivable && a.CustomerId != null).ToList().Sum(x => x.Dr-x.Cr).ToString();
            lblPaidTotal.Text = data.Sum(x => x.Paid).ToString();   //db.Voucher.Where(a=>a.GLCode == GLCode.Cash && a.CustomerId != null).ToList().Sum(x => x.Dr).ToString();
            lblTotal.Text = data.Sum(x => x.TotalSale).ToString();

            AddButton();

            MakeFullWidthScreen();
        }

        private void btnDues_Click(object sender, EventArgs e)
        {
            DateTime startDate = Convert.ToDateTime(dtpStartDate.Text);
            DateTime endDate = Convert.ToDateTime(dtpEndDate.Text);
            PharmacyDbContext db = new PharmacyDbContext();
            int rowNo = 1;
            var data = db.Voucher
                .ToList()
                .Where(d => d.CreatedDate.Date >= startDate.Date && d.CreatedDate <= endDate.Date.AddDays(1) && d.CustomerId != null)
                .GroupBy(o => o.CustomerId)
                .Select(x => new
                {
                    SL = rowNo++,
                    CustomerId = x.Key,
                    CustomerName = x.Select(a => a.Customer.Name).FirstOrDefault(),
                    Mobile = x.Select(a => a.Customer.Mobile).FirstOrDefault(),
                    Due = x.Where(c => c.GLCode == GLCode.AccountReceivable).Sum(a => a.Dr - a.Cr) < 0 ? 0 : x.Where(c => c.GLCode == GLCode.AccountReceivable).Sum(a => a.Dr - a.Cr),
                    Paid = x.Where(c => c.GLCode == GLCode.Cash).Sum(a => a.Dr),
                    TotalSale = x.Where(c => c.GLCode == GLCode.SaleMedicine).Sum(a => a.Cr),
                    Date = x.Select(a => a.CreatedDate).FirstOrDefault().ToString("d")
                }).ToList();
            lblDueTotal.Text = data.Sum(x => x.Due).ToString();     // db.Voucher.Where(a => a.GLCode == GLCode.AccountReceivable && a.CustomerId != null).ToList().Sum(x => x.Dr-x.Cr).ToString();
            lblPaidTotal.Text = data.Sum(x => x.Paid).ToString();   //db.Voucher.Where(a=>a.GLCode == GLCode.Cash && a.CustomerId != null).ToList().Sum(x => x.Dr).ToString();
            lblTotal.Text = data.Sum(x => x.TotalSale).ToString();
            db.Dispose();
            dgvDue.Columns.Clear();
            dgvDue.DataSource = data;
            AddButton();
            MakeFullWidthScreen();
        }

        private void chbFixeDateDue_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFixeDateDue.Checked)
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
            DateTime date = Convert.ToDateTime(dtpStartDate.Text);
            PharmacyDbContext db = new PharmacyDbContext();
            int rowNo = 1;
            var data = db.Voucher
                .ToList()
                .Where(d => d.CreatedDate.Date == date.Date && d.CustomerId != null)
                .GroupBy(o => o.Customer.Name)
                .Select(x => new
                {
                    SL = rowNo++,
                    CustomerId = x.Key,
                    CustomerName = x.Select(a => a.Customer.Name).FirstOrDefault(),
                    Mobile = x.Select(a => a.Customer.Mobile).FirstOrDefault(),
                    Due = x.Where(c => c.GLCode == GLCode.AccountReceivable).Sum(a => a.Dr - a.Cr) < 0 ? 0 : x.Where(c => c.GLCode == GLCode.AccountReceivable).Sum(a => a.Dr - a.Cr),
                    Paid = x.Where(c => c.GLCode == GLCode.Cash).Sum(a => a.Dr),
                    TotalSale = x.Where(c => c.GLCode == GLCode.SaleMedicine).Sum(a => a.Cr),
                    Date = x.Select(a => a.CreatedDate).FirstOrDefault().ToString("d")
                }).ToList();
            db.Dispose();
            dgvDue.Columns.Clear();
            dgvDue.DataSource = data;
            AddButton();
            MakeFullWidthScreen();
        }

        private void dgvDue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                DataGridView va = sender as DataGridView;
                string customerId = va.Rows[e.RowIndex].Cells[e.ColumnIndex - 7].Value.ToString();
                GetDueDetails(customerId);
            }
        }

        private void GetDueDetails(string customerId)
        {
            PharmacyDbContext db = new PharmacyDbContext();
            int count = 1;
            sale = db.SaleMain.Where(x => x.CustomerId == customerId).ToList().Select(s => new SaleDetail
            {
                Sl = count++,
                Total = s.TotalAmount,
                Paid = s.Paid,
                Due = s.Due,
                PaidDue = s.DuePaid,
                Date = s.CreatedDate
            }).ToList();
            ShowDueDetails dueDetails = new ShowDueDetails(sale, customerId, _user);
            dueDetails.ShowDialog();

            dueDetails.FormClosed += DueDetails_FormClosed;
        }

        private void DueDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
