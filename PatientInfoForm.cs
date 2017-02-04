using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;


namespace ProjektOI
{
    public partial class PatientInfoForm : Form
    {
        ClinicEntities dataBase = new ClinicEntities();
        string lastName;
        int idPatient;
        int idReceptionist;

        public PatientInfoForm(string lastName,int id, int idReceptionist)
        {
            InitializeComponent();
            this.idReceptionist = idReceptionist;
            idPatient = id;
            this.lastName = lastName;
            lLastname.Text = lastName.ToUpper();
            ShowInfo(lastName, id);
        }
        
        public void ShowInfo(string lastName, int id)
        {
            lastName.ToUpper();
            string idPatient = id.ToString();
            List<string> lastNameList = dataBase.Patients.Select(r => r.Last_Name).ToList();
            string[] lastNameTab = new string[lastNameList.Count()];
            int i = 0;
            foreach (string s in lastNameList)
            {
                lastNameTab[i++] += s.ToUpper();
            }

             List<string> firstNameList = dataBase.Patients.Select(r => r.First_Name).ToList();
             string[] firstNameTab = new string[firstNameList.Count()];
            int f = 0;
            foreach (string s in firstNameList)
            {
                firstNameTab[f++] += s.ToUpper();
            }

            List<string> streetsList = dataBase.Patients.Select(r => r.Street).ToList();
            string[] streetsTab = new string[streetsList.Count()];
            int t= 0;
            foreach (string s in streetsList)
            {
                streetsTab[t++] += s.ToUpper();
            }

            List<string> homeNrList = dataBase.Patients.Select(r => r.Home_nr).ToList();
            string[] homeNrTab = new string[homeNrList.Count()];
            int h = 0;
            foreach (string s in homeNrList)
            {
                homeNrTab[h++] += s.ToUpper();
            }

            List<string> citiesList = dataBase.Patients.Select(r => r.City).ToList();
            string[] citiesTab = new string[citiesList.Count()];
            int c = 0;
            foreach (string s in citiesList)
            {
                citiesTab[c++] += s.ToUpper();
            }
             
             List<string> idPatientList = dataBase.Patients.Select(r => r.IDPatient.ToString()).ToList();
            string[] idPatientTab = new string[idPatientList.Count()];
            int l = 0;
            foreach (string s in idPatientList)
            {
                idPatientTab[l++] += s;
            }

            for (int j = 0; j < lastNameTab.Length; j++)
            {
                if (lastNameTab[j].Equals(lastName.ToUpper()) && idPatientTab[j].Equals(idPatient))
                {
                    name.Text = firstNameList[j].ToUpper();
                    addres.Text = citiesTab[j].ToUpper() + " ul. " + streetsTab[j].ToUpper() + " " + homeNrTab[j];
                }
            }
           
        }


        private void btnpatientAddEgzamination_Click(object sender, EventArgs e)
        {
            EgzaminationForm egzamination = new EgzaminationForm(lastName,idPatient, idReceptionist);
            egzamination.Show();
            this.Hide();
        }

        private void btnpatientDelete_Click(object sender, EventArgs e)
        {
            Patient deletePatient = dataBase.Patients.Select(s => s).Where(r => r.Last_Name.ToUpper().Equals(lastName.ToUpper())).Where(s => s.IDPatient == idPatient).FirstOrDefault();
            List<Visit> deleteVisits = dataBase.Visits.Select(s => s).Where(r => r.IDPatient == idPatient).ToList();
            foreach(Visit v in deleteVisits)
            {
                dataBase.Visits.Remove(v);
            }

            dataBase.Patients.Remove(deletePatient);
            dataBase.SaveChanges();
            MessageBox.Show("Usunieto pacjenta");
            btnpatientQuit_Click(sender, e);
        }

        private void btnpatientQuit_Click(object sender, EventArgs e)
        {
            DailyForm m = new DailyForm(idReceptionist);
            m.Show();
            this.Hide();
        }

        private void btnpatientEdit_Click(object sender, EventArgs e)
        {
            PatientEditForm edit = new PatientEditForm(lastName, idPatient,idReceptionist);
            edit.Show();
            this.Hide();
        }

        private void btnDelateEgamination_Click(object sender, EventArgs e)
        {
            DeleteEgzaminationForm deleteEgzamination = new DeleteEgzaminationForm(lastName, idPatient, idReceptionist);
            deleteEgzamination.Show();
            this.Hide();
        }

        private void btnEditEgzamination_Click(object sender, EventArgs e)
        {
            EgzaminationEditForm editEgzamination = new EgzaminationEditForm(lastName, idPatient, idReceptionist);
            editEgzamination.Show();
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
