using System;
using System.Collections;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using PharmacyDesktopApplication.Entities;
using PharmacyDesktopApplication.Models;

namespace PharmacyDesktopApplication.UI
{
    partial class ShowExpenseDetails : Form
    {
        private readonly string _id;
        private string currentUser = "0";

        public ShowExpenseDetails(string id)
        {
            _id = id;
            InitializeComponent();
            int count = 1;

            PharmacyDbContext db = new PharmacyDbContext();
            var expense = db.ExpenseSub.Where(x => x.MainId == _id).ToList()
            .Select(s => new
            {
                Sl = count++,
                Total = s.Amount,
                ExpenseType = s.ExpenseType,
                ExpensedBy = s.CreatedBy,
                Date = s.CreatedDate
            }).ToList();

            dgvSaleDetails.DataSource = expense;
            lblDue.Text = Convert.ToString(db.ExpenseSub.Where(x=> x.MainId == _id).Sum(a => a.Amount));
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
