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
    public partial class EgzaminationForm : Form
    {
        ClinicEntities dataBase = new ClinicEntities();
        string lastName;
        int idPatient;
        int idReceptionist;
        int idDoctor;
        List<Specialisation> specialisationList;
        //List<int> id = new List<int>();
       

        public EgzaminationForm(string lastName, int idPatient, int idReceptionist)
        {
            this.lastName = lastName;
            this.idPatient = idPatient;
            this.idReceptionist = idReceptionist;
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try 
            {
                string doctorName = cbdoctors_possibles.SelectedItem.ToString();
            
                List<string> check = new List<string>();
                List<Doctor> d = dataBase.Doctors.Select(s => s).ToList();
                foreach (Doctor doc in d)
                {
                    check.Add(doc.First_Name + " " + doc.Last_Name);
                    if (check.Contains(doctorName))
                    {
                        idDoctor = doc.IDDoctor;
                        EgzaminationAddForm addEgzamination = new EgzaminationAddForm(lastName, idPatient, idReceptionist, idDoctor);
                        addEgzamination.Show();
                        this.Hide();
                        break;
                    }
                }

               
            }
           catch(Exception) 
           {
               MessageBox.Show("Proszę wybrać imię lekarza!");
           }
            

            
        }

        private void EgzaminationForm_Load(object sender, EventArgs e)
        {
            cbdoctors_possibles.Visible = false;
            lchooseDoctor.Visible = false;
            btnsearch.Visible = false;
            specialisationList = dataBase.Specialisations.Select(s => s).ToList();

            foreach (Specialisation s in specialisationList)
            {
                cbspecialisation_possibles.Items.Add(s.Name);
            }  
        }

        private void specialisation_possibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbdoctors_possibles.Items.Clear();
            
            if (cbspecialisation_possibles != null )
            {
                cbdoctors_possibles.Visible = true;
                lchooseDoctor.Visible = true;
                btnsearch.Visible = true;

                int idSpecialisation = cbspecialisation_possibles.SelectedIndex;
                Specialisation selected = specialisationList.ElementAt(idSpecialisation);
                List<Doctor> doctorsList = dataBase.Doctors.Select(s => s).Where(r => r.IDSpecialisation == selected.IDSpecialisation).ToList();

                foreach (Doctor d in doctorsList)
                {
                    //id.Add(d.IDDoctor);
                    cbdoctors_possibles.Items.Add(d.First_Name + " " + d.Last_Name);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PatientInfoForm info = new PatientInfoForm(lastName, idPatient, idReceptionist);
            info.Show();
            this.Hide();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                PatientInfoForm info = new PatientInfoForm(lastName, idPatient, idReceptionist);
                info.Show();
                this.Hide();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
       

      
    }
}
