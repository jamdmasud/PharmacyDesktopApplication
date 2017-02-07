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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            try
            {
                PharmacyDbContext db = new PharmacyDbContext();
                AppUser user = db.AppUser.ToList()
                    .First(x => x.Email == username && x.Password == password);
                if (user != null)
                {
                    this.Hide();
                    new Home().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login failed");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}
