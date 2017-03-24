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
using PharmacyDesktopApplication.Models;
using PharmacyDesktopApplication.Models.InformationFactory;
using Company = PharmacyDesktopApplication.Models.InformationFactory.Company;

namespace PharmacyDesktopApplication.UI
{
    public partial class SaveMedicine : Form
    {
        private string currentUser = "0";
        public SaveMedicine(string currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
            PharmacyDbContext db = new PharmacyDbContext();
            GetAutocompleteForCompany(db);
            GetAutocompleteForGroup(db);
            db.Dispose();
        }

        private void GetAutocompleteForCompany(PharmacyDbContext db)
        {
            var source = new AutoCompleteStringCollection();
            source.AddRange(db.Company.ToList().Select(x => x.Name).ToArray());
            txtCompany.AutoCompleteCustomSource = source;
        }

        private void GetAutocompleteForGroup(PharmacyDbContext db)
        {
            var source = new AutoCompleteStringCollection();
            source.AddRange(db.Groups.ToList().Select(x => x.Name).ToArray());
            txtGroup.AutoCompleteCustomSource = source;
        }

        private int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string medicine = txtMedicine.Text;
            string group = txtGroup.Text;
            string company = txtCompany.Text;
            if (ValidateField(medicine, group, company)) return;
            ListViewItem item = new ListViewItem();
            try
            {
                item.SubItems.Add((++count).ToString());
                if (!IsMedicineExest(medicine))
                    item.SubItems.Add(medicine);
                else
                {
                    MessageBox.Show(medicine + " is already exists!");
                    return;
                }
                item.SubItems.Add(group);
                item.SubItems.Add(company);
                lvMedicine.Items.Add(item);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Addition Error:" + exception.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            ClearField();
        }

        private static bool ValidateField(string medicine, string group, string company)
        {
            if (medicine == "")
            {
                MessageBox.Show("Medicine can't be empty!", "Message!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (group == "")
            {
                MessageBox.Show("Medicine group can't be empty!", "Message!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (company == "")
            {
                MessageBox.Show("Company name can't be empty!", "Message!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private bool IsMedicineExest(string medicine)
        {
            bool isExit = false;
            PharmacyDbContext db = new PharmacyDbContext();
            Medicine med = db.Medicine.ToList().FirstOrDefault(x => x.Name == medicine);
            if (med != null) isExit = true;
            db.Dispose();
            return isExit;
        }

        private void ClearField()
        {
            txtMedicine.Text = String.Empty;
            txtGroup.Text = String.Empty;
            txtCompany.Text = String.Empty;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            //try
            //{
                PharmacyDbContext db = new PharmacyDbContext();
                foreach (ListViewItem item in lvMedicine.Items)
                {
                    Medicine medicine = new Medicine();

                    medicine.Name = item.SubItems[2].Text;
                    medicine.Id = UniqueNumber.GenerateUniqueNumber();
                    medicine.CreatedBy = currentUser;
                    medicine.CreatedDate = DateTime.Now;
                    medicine.GroupId = Group.GetGroupId(item.SubItems[3].Text, currentUser); 
                    medicine.CompanyId = Company.GetCompanyId(item.SubItems[4].Text, currentUser);

                db.Medicine.Add(medicine);
                }
                db.SaveChanges();
                db.Dispose();
                MessageBox.Show("Save successful!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lvMedicine.Items.Clear();
            //}
            //catch (Exception exception)
            //{
            //    MessageBox.Show("Saving Error:" + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearField();
            lvMedicine.Items.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
