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
using PharmacyDesktopApplication.UI;

namespace PharmacyDesktopApplication
{
    public partial class Home : Form
    {
        private readonly string _user;

        public Home(string user)
        {
            _user = user;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JetEntityFrameworkProvider.JetConnection.ShowSqlStatements = true;
            PharmacyDbContext db = new PharmacyDbContext();
            int count = db.AppUser.Count();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new ViewExpense().ShowDialog();
        }

        private void btnSaveMedicine_Click(object sender, EventArgs e)
        {
            new SaveMedicine(_user).ShowDialog();
        }

        private void btnPurchaseMedicine_Click(object sender, EventArgs e)
        {
            new PurchaseMedicine(_user).ShowDialog();
        }

        private void btnSaleMedicine_Click(object sender, EventArgs e)
        {
            new Salemedicine(_user).ShowDialog();
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            new MedicineStorage().ShowDialog();
        }

        private void btnDue_Click(object sender, EventArgs e)
        {
            new DueList(_user).ShowDialog();
        }

        private void btnSaveExpense_Click(object sender, EventArgs e)
        {
            new saveExpense(_user).ShowDialog();
        }

        private void btnPuchasedMedicine_Click(object sender, EventArgs e)
        {
            new PurchaseMedicinesList().ShowDialog();
        }

        private void btnSoldMedicine_Click(object sender, EventArgs e)
        {
            new DueList(_user).ShowDialog();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            login login = new login();
            login.Close();
        }
    }
}
