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
    public partial class RegisterForm : Form
    {
        ClinicEntities dataBase = new ClinicEntities();
        int idReceptionist;

        public RegisterForm(int idReceptionist)
        {
            this.idReceptionist = idReceptionist;
            InitializeComponent();
        }
       
       
         private void Id_possibles_TextChanged(object sender, EventArgs e)
        {
            if (!tbId_possibles.Text.All(chr => char.IsNumber(chr)))
            {
                MessageBox.Show("Możliwość wpisania tylko liczb");

            }
        }

        private void LastName_possibles_TextChanged(object sender, EventArgs e)
        {
            if (!tblastName_possibles.Text.All(chr => char.IsLetter(chr)))
            {
                MessageBox.Show("Możliwość wpisania tylko znaków alfabetycznych");

            }
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


        private void btnaddNewPatient_Click(object sender, EventArgs e)
        {
            PatientAddForm add = new PatientAddForm(idReceptionist);
            add.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DailyForm daily = new DailyForm(idReceptionist);
            daily.Show();
            this.Hide();
        }

        private void btnaddNewDoctor_Click(object sender, EventArgs e)
        {
            DoctorAddForm add = new DoctorAddForm(idReceptionist);
            add.Show();
            this.Hide();
        }

        private void btneditDoctor_Click(object sender, EventArgs e)
        {
            DoctorEditForm edit = new DoctorEditForm(idReceptionist);
            edit.Show();
            this.Hide();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string lastName = tblastName_possibles.Text;
                int idPatient = int.Parse(tbId_possibles.Text);
                string id = idPatient.ToString();


                if (Checking(lastName, id) == true)
                {
                    PatientInfoForm m = new PatientInfoForm(lastName, int.Parse(id), idReceptionist);
                    m.Show();
                    this.Hide();
                }
                else MessageBox.Show("Błąd! Spróbuj ponownie");
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd! Spróbuj ponownie");
            }
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
