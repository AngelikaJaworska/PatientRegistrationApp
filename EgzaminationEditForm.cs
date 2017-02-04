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
    public partial class EgzaminationEditForm : Form
    {
        ClinicEntities dataBase = new ClinicEntities();
        string lastName;
        int idPatient;
        int idReceptionist;
        List<Specialisation> specialisationList;
        int idDoctor;
        List<DateTime> visitList;
        
        public EgzaminationEditForm( string lastName, int idPatient,int idReceptionist)
        {
            this.idReceptionist = idReceptionist;
            this.idPatient = idPatient;
            this.lastName = lastName;
            InitializeComponent();
        }

        private void EgzaminationEditForm_Load(object sender, EventArgs e)
        {
            MakeInvisible();
            specialisationList = dataBase.Specialisations.Select(s => s).ToList();

            foreach (Specialisation s in specialisationList)
            {
                cbspecialisation_possibles.Items.Add(s.Name);
            }

            visitList = new List<DateTime>();

            foreach (DateTime day in EachDay(DateTime.Today, DateTime.Now.AddDays(4)))
            {
                visitList.Add(day);
            }

        }


        public IEnumerable<DateTime> EachDay(DateTime start, DateTime end)
        {
            for (var day = start.Date; day.Date <= end.Date; day = day.AddMinutes(30))
            {
                if (day.DayOfWeek != DayOfWeek.Saturday && day.DayOfWeek != DayOfWeek.Sunday && day.DayOfYear != 24.12 && day.DayOfYear != 25.12 && day.DayOfYear != 26.12)
                {
                    yield return day;
                }
            }
        }

        private void specialisation_possibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbdoctor_possibles.Items.Clear();
            cbdoctor_possibles.Text = "";
            cbdate_possibles.Items.Clear();
            cbdate_possibles.Text = "";
            if (cbspecialisation_possibles != null)
            {
                cbdoctor_possibles.Visible = true;
                ldoctor.Visible = true;

                int which = cbspecialisation_possibles.SelectedIndex;
                Specialisation selected = specialisationList.ElementAt(which);
                int idSpecialisation = selected.IDSpecialisation;
                List<Doctor> doctorsList = dataBase.Doctors.Select(s => s).Where(r => r.IDSpecialisation == idSpecialisation).ToList();
                 
                foreach (Doctor d in doctorsList)
                {
                    cbdoctor_possibles.Items.Add(d.First_Name + " " + d.Last_Name);
                }
            }
        }

        private void doctor_possibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbdate_possibles.Items.Clear();
            cbdate_possibles.Text = "";
            if (cbdoctor_possibles != null)
            {
                lvisit.Visible = true;
                cbdate_possibles.Visible = true;
                btnsearch.Visible = true;
                string doctorName = cbdoctor_possibles.SelectedItem.ToString();

                List<string> check = new List<string>();
                List<Doctor> d = dataBase.Doctors.Select(s => s).ToList();

                foreach (Doctor doc in d)
                {
                    check.Add(doc.First_Name + " " + doc.Last_Name);
                    if (check.Contains(doctorName))
                    {
                        idDoctor = doc.IDDoctor;
                        break;
                    }
                }

                List<Visit> visitList = dataBase.Visits.Select(s => s).Where(r => r.IDPatient == idPatient && r.IDDoctor == idDoctor).ToList();
                foreach (Visit v in visitList)
                {
                    if (v.VisitDate.TimeOfDay <= DateTime.Now.TimeOfDay && DateTime.Now.Date == v.VisitDate.Date)
                    {
                        cbdate_possibles.Items.Remove(v.VisitDate);
                    }
                    else cbdate_possibles.Items.Add(v.VisitDate);

                     
                }
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                MakeVisible();
                visitList = CheckingIfPossible(visitList);
                lbnewvisit.DataSource = visitList;

            }
            catch (Exception )
            {
                MessageBox.Show("Nieprawidłowe dane!");
            }
           
        }

        public List<DateTime> CheckingIfPossible(List<DateTime> date)
        {
            Doctor doctor = dataBase.Doctors.Select(s => s).Where(i => i.IDDoctor == idDoctor).Single();
            TimeSpan startTime = doctor.WorkStart;
            TimeSpan endTime = doctor.WorkEnd;
            List<Visit> thisDoctorVisit = dataBase.Visits.Select(s => s).Where(i => i.IDDoctor == idDoctor).ToList();
            List<Visit> visits = dataBase.Visits.Select(s => s).ToList();

            List<DateTime> possibleVisitsList = new List<DateTime>();

            foreach (DateTime dt in date)
            {
                possibleVisitsList.Add(dt);
            }

            foreach (DateTime d in date)
            {
                if (d.TimeOfDay < startTime || d.TimeOfDay >= endTime)  //czy w godzinach pracy lekarza
                {
                    possibleVisitsList.Remove(d);
                }

                if (DateTime.Now.TimeOfDay > d.TimeOfDay && DateTime.Now.Date == d.Date) //czy dana godz juz minela
                {
                    possibleVisitsList.Remove(d);
                }
                foreach (Visit v in thisDoctorVisit)
                {
                    if (v.VisitDate.TimeOfDay == d.TimeOfDay && v.VisitDate.Date == d.Date) //czy taka wizyta jest juz zajeta
                    {
                        possibleVisitsList.Remove(d);
                    }

                }
                foreach (Visit vv in visits)
                {
                    if (vv.VisitDate.TimeOfDay == d.TimeOfDay && vv.VisitDate.Date == d.Date && vv.IDPatient == idPatient) //czy pacjent juz do innego lekarza o tej godz
                    {
                        possibleVisitsList.Remove(d);
                    }
                }
            }
            return possibleVisitsList;


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
      
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                EditVisit();
                MessageBox.Show("Edytowano wizytę");
                PatientInfoForm info = new PatientInfoForm(lastName, idPatient, idReceptionist);
                info.Show();
                this.Hide();

            }
            catch (Exception)
            {
                MessageBox.Show("Nieprawidłowe dane!");
            }
        }

        public void EditVisit()
        {
            DateTime visitDate = DateTime.Parse(cbdate_possibles.SelectedItem.ToString());
            Visit visit = dataBase.Visits.Select(s => s).Where(r => r.IDPatient == idPatient && r.IDDoctor == idDoctor && r.VisitDate == visitDate).FirstOrDefault();

            if (lbnewvisit != null)
            {
                visit.VisitDate = DateTime.Parse(lbnewvisit.Text.ToString());
            }

            visit.IdReceptionist = idReceptionist;
            dataBase.SaveChanges();

        }
          
        public void MakeInvisible()
        {
            btnsearch.Visible = false;
            ldoctor.Visible = false;
            lvisit.Visible = false;
            cbdoctor_possibles.Visible = false;
            cbdate_possibles.Visible = false;
            ledit.Visible = false;
            lnewvisit.Visible = false;
            lbnewvisit.Visible = false;
            btnsave.Visible = false;
        }
        public void MakeVisible()
        {
            cbspecialisation_possibles.Enabled = false;
            cbdoctor_possibles.Enabled = false;
            cbdate_possibles.Enabled = false;
            btnsearch.Enabled = false;
            ledit.Visible = true;
            lnewvisit.Visible = true;
            lbnewvisit.Visible = true;
            btnsave.Visible = true;
        }
    }
}
