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
    public partial class PatientEditForm : Form
    {
        ClinicEntities dataBase = new ClinicEntities();
        string lastname;
        string Id;
        int idReceptionist;
        
        public PatientEditForm(string lastname, int id,  int idReceptionist)
        {
            InitializeComponent();
            Id = id.ToString();
            this.lastname = lastname;
            this.idReceptionist = idReceptionist;
           
         }

        private void PatientEditForm_Load(object sender, EventArgs e) 
        {
            Patient patient = dataBase.Patients.Select(s => s).Where(r => r.Last_Name.Equals(lastname) && r.IDPatient.ToString().Equals(Id)).Single();
            tbname_possibles.Text = patient.First_Name;
            tblastname_possibles.Text = patient.Last_Name;
            tbphoneNumber_possibles.Text = patient.Phone.Trim();
            tbstreet_possibles.Text = patient.Street;
            tbhomeNumber_possibles.Text = patient.Home_nr;
            tbcity_possibles.Text = patient.City;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Checking(lastname, Id))
            {
                EditPatient(lastname, Id);
                MessageBox.Show("Edytowano pacjenta");
                PatientInfoForm info = new PatientInfoForm(lastname, int.Parse(Id), idReceptionist);
                info.Show();
                this.Hide();
            }
            else MessageBox.Show("Błąd");
        }

        public bool Checking(string lastName, string idPatient)
        {
            bool b = false;

            List<string> lastNameList = dataBase.Patients.Select(r => r.Last_Name).ToList();
            string[] lastNameTab = new string[lastNameList.Count()];
            int i = 0;
            foreach (string s in lastNameList)
            {
                lastNameTab[i++] += s.ToUpper();
            }

            List<string> idPatientList = dataBase.Patients.Select(r => r.IDPatient.ToString()).ToList();
            string[] idPatientTab = new string[idPatientList.Count()];
            int j = 0;
            foreach (string s in idPatientList)
            {
                idPatientTab[j++] += s;
            }

            for (int k = 0; k < lastNameTab.Length; k++)
            {
                if (lastNameTab[k].Equals(lastName.ToUpper()) && idPatientTab[k].Equals(idPatient))
                {
                    b = true;
                    
                }
            }
            return b;
        }

        public void EditPatient(string last_name, string id)
        {
            Patient patient = dataBase.Patients.Select(s => s).Where(r => r.IDPatient.ToString().Equals(id)).FirstOrDefault();
            
            
                if (tbname_possibles.Text != null && tbname_possibles.Text != "")
                {
                    patient.First_Name = tbname_possibles.Text;
                }

                if (tblastname_possibles.Text != null && tblastname_possibles.Text != "")
                {
                    patient.Last_Name = tblastname_possibles.Text;
                    lastname = patient.Last_Name;
                }

                if (tbphoneNumber_possibles.Text != null && tbphoneNumber_possibles.Text != "")
                {
                    patient.Phone = tbphoneNumber_possibles.Text;
                }

                if (tbstreet_possibles.Text != null && tbstreet_possibles.Text != "")
                {
                    patient.Street = tbstreet_possibles.Text;
                }

                if (tbhomeNumber_possibles.Text != null && tbhomeNumber_possibles.Text != "")
                {
                    patient.Home_nr = tbhomeNumber_possibles.Text;
                }

                if (tbcity_possibles.Text != null && tbcity_possibles.Text != "")
                {
                    patient.City = tbcity_possibles.Text;
                }
                
                dataBase.SaveChanges();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PatientInfoForm info = new PatientInfoForm(lastname, int.Parse(Id), idReceptionist);
            info.Show();
            this.Hide();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                PatientInfoForm info = new PatientInfoForm(lastname, int.Parse(Id), idReceptionist);
                info.Show();
                this.Hide();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

       
    }
}
