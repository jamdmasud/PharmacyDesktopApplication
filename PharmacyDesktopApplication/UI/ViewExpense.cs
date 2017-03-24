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
    public partial class ViewExpense : Form
    {
        public List<SaleDetail> sale = null;
        private int _count = 0;
        public ViewExpense()
        {
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
            var data = db.ExpenseMain
                .ToList()
                .Select(x => new 
                {
                    SL = rowNo++,
                    Id = x.Id,
                    Amount = x.TotalAmount,
                    Date = x.CreatedDate
                }).ToList();
            lblDueTotal.Text = data.Sum(x => x.Amount).ToString();     // db.Voucher.Where(a => a.GLCode == GLCode.AccountReceivable && a.CustomerId != null).ToList().Sum(x => x.Dr-x.Cr).ToString();
                 // db.Voucher.Where(a => a.GLCode == GLCode.SaleMedicine && a.CustomerId != null).ToList().Sum(x => x.Cr).ToString();
            db.Dispose();
            dgvExpense.Columns.Clear();
            dgvExpense.DataSource = data;
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
            dgvExpense.Columns.Add(btn);
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
            dgvExpense.Columns.Clear();
            dgvExpense.DataSource = data;

            lblDueTotal.Text = data.Sum(x => x.Due).ToString();     // db.Voucher.Where(a => a.GLCode == GLCode.AccountReceivable && a.CustomerId != null).ToList().Sum(x => x.Dr-x.Cr).ToString();
            

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
            if (chbFixeDateDue.Checked)
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
            PharmacyDbContext db = new PharmacyDbContext();
            int rowNo = 1;
            var data = db.ExpenseMain
                .ToList()
                .Where(d => d.CreatedDate >= sdate && d.CreatedDate <= edate)
                .Select(x => new
                {
                    SL = rowNo++,
                    Id = x.Id,
                    Amount = x.TotalAmount,
                    Date = x.CreatedDate
                }).ToList();
            db.Dispose();
            dgvExpense.Columns.Clear();
            dgvExpense.DataSource = data;
            AddButton();
            MakeFullWidthScreen();
        }
        private void FixedDateExpense()
        {
            DateTime date = Convert.ToDateTime(dtpStartDate.Text);
            PharmacyDbContext db = new PharmacyDbContext();
            int rowNo = 1;
            var data = db.ExpenseMain
                .ToList()
                .Where(d => d.CreatedDate.Date == date.Date)
                .Select(x => new
                {
                    SL = rowNo++,
                    Id = x.Id,
                    Amount = x.TotalAmount,
                    Date = x.CreatedDate
                }).ToList();
            db.Dispose();
            dgvExpense.Columns.Clear();
            dgvExpense.DataSource = data;
            AddButton();
            MakeFullWidthScreen();
        }

        private void dgvDue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                DataGridView va = sender as DataGridView;
                string mainId = va.Rows[e.RowIndex].Cells[e.ColumnIndex - 3].Value.ToString();
                GetDueDetails(mainId);
            }
        }

        private void GetDueDetails(string mainId)
        {
            PharmacyDbContext db = new PharmacyDbContext();
            int count = 1;
            
            ShowExpenseDetails expenseDetails = new ShowExpenseDetails(mainId);
            expenseDetails.ShowDialog();
            expenseDetails.FormClosed += DueDetails_FormClosed;
        }

        private void DueDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowData();
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
