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

namespace PharmacyDesktopApplication
{
    public partial class Home : Form
    {
        public Home()
        {
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

        }
    }
}
