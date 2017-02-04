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
    public partial class DeleteEgzaminationForm : Form
    {
        ClinicEntities dataBase = new ClinicEntities();
        string lastName;
        int idPatient;
        int idReceptionist;
        List<Specialisation> specialisationList;
        List<Doctor> doctorsList;
        List<int> idDoctorsList = new List<int>();

        public DeleteEgzaminationForm(string lastName, int idPatient, int idReceptionist)
        {
            this.lastName = lastName;
            this.idPatient = idPatient;
            this.idReceptionist = idReceptionist;
            InitializeComponent();
        }

        private void btnpatientQuit_Click(object sender, EventArgs e)
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

        private void DeleteEgzaminationForm_Load(object sender, EventArgs e)
        {
            ldoctor.Visible = false;
            cbdoctor_possibles.Visible = false;
            lvisitDate.Visible = false;
            cbdate_possibles.Visible = false;
            btnsaveDelete.Visible = false;
            btnpatientQuit.Visible = false;

            specialisationList = dataBase.Specialisations.Select(s => s).ToList();

            foreach (Specialisation s in specialisationList)
            {
                cbspecialisation_possibles.Items.Add(s.Name);
            }

            doctorsList = dataBase.Doctors.Select(s => s).ToList();

        }

        private void specialisation_possibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbdoctor_possibles.ResetText();
            cbdate_possibles.ResetText();
            cbdoctor_possibles.Items.Clear();
            cbdate_possibles.Items.Clear();
            if (cbspecialisation_possibles != null)
            {
                cbdoctor_possibles.Visible = true;
                ldoctor.Visible = true;
                
                int idSpecialisation = cbspecialisation_possibles.SelectedIndex;
                Specialisation selected = specialisationList.ElementAt(idSpecialisation);
                List<Doctor> doctorsList = dataBase.Doctors.Select(s => s).Where(r => r.IDSpecialisation == selected.IDSpecialisation).ToList();

                foreach (Doctor d in doctorsList)
                {
                    idDoctorsList.Add(d.IDDoctor);
                    cbdoctor_possibles.Items.Add(d.First_Name + " " + d.Last_Name);
                }
            }
        }

        private void doctor_possibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbdate_possibles.Items.Clear();
            if (cbdoctor_possibles != null)
            {
                lvisitDate.Visible = true;
                cbdate_possibles.Visible = true;
                btnsaveDelete.Visible = true;
                btnpatientQuit.Visible = true;


                string doctorNameSurname = cbdoctor_possibles.SelectedItem.ToString();
                string[] doctor = doctorNameSurname.Split(' ').ToArray();
                string name = doctor[0];
                string surname = doctor[1];
                List<Visit> visitsList = dataBase.Visits.Select(s => s).Where(r => r.Doctor.Last_Name.Equals(surname) && r.Doctor.First_Name.Equals(name)).ToList();

                foreach(Visit v in visitsList)
                {
                    if(v.IDPatient == idPatient)
                    {
                        cbdate_possibles.Items.Add(v.VisitDate);
                    }
                }

            }
               
        }

        private void btnsaveDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string[] visitDate = cbdate_possibles.SelectedItem.ToString().Split(' ');
                string date = visitDate[0];
                string time = visitDate[1];
                
                List<Visit> v = dataBase.Visits.Select(s => s).ToList();
                foreach (Visit vis in v)
                {
                    if (vis.VisitDate.Date.ToShortDateString().Equals(date) && vis.VisitDate.TimeOfDay.ToString().Equals(time))//if(vis.VisitDate.)
                    {
                        dataBase.Visits.Remove(vis);
                        dataBase.SaveChanges();
                        MessageBox.Show("Usunięto wizytę");
                        PatientInfoForm info = new PatientInfoForm(lastName, idPatient, idReceptionist);
                        info.Show();
                        this.Hide();
                    }
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Proszę wybrać datę wizyty!");
            }
        }

       

        
        }
    }

