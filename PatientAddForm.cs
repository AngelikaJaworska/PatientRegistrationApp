using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektOI
{
    public partial class PatientAddForm : Form
    {
        ClinicEntities dataBase = new ClinicEntities();
        int idReceptionist;

        public PatientAddForm(int idReceptionist)
        {
            this.idReceptionist = idReceptionist;
            InitializeComponent();
        }

        private void name_possibles_TextChanged(object sender, EventArgs e)
        {
            if (!tbname_possibles.Text.All(chr => char.IsLetter(chr)))
            {
                MessageBox.Show("Możliwość wpisania tylko znaków alfabetycznych");

            }
        }

        private void lastname_possibles_TextChanged(object sender, EventArgs e)
        {
            if (!tblastname_possibles.Text.All(chr => char.IsLetter(chr)))
            {
                MessageBox.Show("Możliwość wpisania tylko znaków alfabetycznych");

            }
        }

        private void phoneNumber_possibles_TextChanged(object sender, EventArgs e)
        {
            if (!tbphoneNumber_possibles.Text.All(chr => char.IsNumber(chr)))
            {
                MessageBox.Show("Możliwość wpisania tylko liczb");

            }
        }

        private void city_possibles_TextChanged(object sender, EventArgs e)
        {
            if (!tbcity_possibles.Text.All(chr => char.IsLetter(chr)))
            {
                MessageBox.Show("Możliwość wpisania tylko znaków alfabetycznych");

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewPatient();
            RegisterForm r = new RegisterForm(idReceptionist);
            r.Show();
            this.Hide();
        }
        public void AddNewPatient()
        {
            Patient newPatient = new Patient();

            newPatient.First_Name = tbname_possibles.Text;
            newPatient.Last_Name = tblastname_possibles.Text;
            newPatient.Phone = tbphoneNumber_possibles.Text;
            newPatient.Street = tbstreet_possibles.Text;
            newPatient.Home_nr = tbhomeNr_possibles.Text;
            newPatient.City = tbcity_possibles.Text;

            dataBase.Patients.Add(newPatient);
            dataBase.SaveChanges();
            MessageBox.Show("Dodano pacjenta");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DailyForm daily = new DailyForm(idReceptionist);
            daily.Show();
            this.Hide();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                DailyForm daily = new DailyForm(idReceptionist);
                daily.Show();
                this.Hide();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
