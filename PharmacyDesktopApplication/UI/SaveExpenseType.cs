using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyDesktopApplication.Entities;

namespace PharmacyDesktopApplication.UI
{
    public partial class SaveExpenseType : Form
    {
        private string currentUser = "0";
        public SaveExpenseType()
        {
            InitializeComponent();
            Autocomplete();
        }

        private void Autocomplete()
        {
            PharmacyDbContext db = new PharmacyDbContext();
            var source = new AutoCompleteStringCollection();
            source.AddRange(db.ExpenseType.ToList().Select(x => x.Type).ToArray());
            txtExpenseType.AutoCompleteCustomSource = source;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string expenseType = txtExpenseType.Text;
            if (expenseType == "")
            {
                MessageBox.Show("Expense can't be empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PharmacyDbContext db = new PharmacyDbContext();
            ExpenseType expenseTypes = new ExpenseType()
            {
                CreatedBy = currentUser,
                CreatedDate = DateTime.Now,
                Id = Guid.NewGuid().ToString(),
                Type = expenseType
            };
            db.ExpenseType.Add(expenseTypes);
            db.SaveChanges();
            db.Dispose();
            MessageBox.Show("Save successful!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtExpenseType.Text = "";
        }
    }
}
