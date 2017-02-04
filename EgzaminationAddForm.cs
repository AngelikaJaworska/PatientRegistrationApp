using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading; //.Tasks;
using System.Windows.Forms;

namespace ProjektOI
{
    public partial class EgzaminationAddForm : Form
    {
        ClinicEntities dataBase = new ClinicEntities();
        string lastName;
        int idPatient;
        int idReceptionist;
        int idDoctor;
        
        List<DateTime> visitList;


        public EgzaminationAddForm(string lastName, int idPatient, int idReceptionist, int idDoctor)
        {
            this.lastName = lastName;
            this.idPatient = idPatient;
            this.idReceptionist = idReceptionist;
            this.idDoctor = idDoctor;
            InitializeComponent();
        }

        private void btnReturnToExaminationForm_Click(object sender, EventArgs e)
        {
            EgzaminationForm Egzaminationform = new EgzaminationForm(lastName, idPatient, idReceptionist);
            Egzaminationform.Show();
            this.Hide();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                EgzaminationForm Egzaminationform = new EgzaminationForm(lastName, idPatient, idReceptionist);
                Egzaminationform.Show();
                this.Hide();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (AddNewVisit())
            {
                PatientInfoForm info = new PatientInfoForm(lastName, idPatient, idReceptionist);
                info.Show();
                this.Hide();
            }
            else MessageBox.Show("Błąd! Spróbuj ponownie");
        }

        public bool AddNewVisit()
        {
           if (this.lbnewvisit.SelectedItems.Count == 1)
           {
              //int which = this.listBox.SelectedIndex;
              Object o = this.lbnewvisit.SelectedItem;
              string date = o.ToString();

               Visit newVisit = new Visit();
               newVisit.IDPatient = idPatient;
               newVisit.IDDoctor = idDoctor;
               newVisit.IdReceptionist = idReceptionist;
               newVisit.VisitDate = DateTime.Parse(date);

               dataBase.Visits.Add(newVisit);
               dataBase.SaveChanges();
               MessageBox.Show("Zarejestrowano na wizytę");

               return true;
            }
            else 
            {
                return false;
            }

         }

        private void AddEgzamination_Load(object sender, EventArgs e)
        {
            visitList = new List<DateTime>();

            foreach (DateTime day in EachDay(DateTime.Today, DateTime.Now.AddDays(4)))
            {
                visitList.Add(day);                   
            }
            visitList = CheckingIfPossible(visitList);
            lbnewvisit.DataSource = visitList;
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

        public List<DateTime> CheckingIfPossible(List<DateTime> date)
        {
            Doctor doctor = dataBase.Doctors.Select(s => s).Where(i => i.IDDoctor == idDoctor).Single();
            TimeSpan startTime = doctor.WorkStart;
            TimeSpan endTime = doctor.WorkEnd;
            List<Visit> thisDoctorVisit = dataBase.Visits.Select(s => s).Where(i => i.IDDoctor == idDoctor).ToList();
            List<Visit> visits = dataBase.Visits.Select(s => s).ToList();
            
            List<DateTime> possibleVisitsList = new List<DateTime>();
            
                foreach(DateTime dt in date)
                {
                    possibleVisitsList.Add(dt);
                }
           
            foreach(DateTime d in date)
            {
                if(d.TimeOfDay < startTime || d.TimeOfDay >= endTime)  //czy w godzinach pracy lekarza
                {
                    possibleVisitsList.Remove(d);
                }

                if(DateTime.Now.TimeOfDay > d.TimeOfDay && DateTime.Now.Date == d.Date) //czy dana godz juz minela
                {
                    possibleVisitsList.Remove(d);
                }
                 foreach(Visit v in thisDoctorVisit)
                {
                    if(v.VisitDate.TimeOfDay == d.TimeOfDay && v.VisitDate.Date == d.Date) //czy taka wizyta jest juz zajeta
                    {
                        possibleVisitsList.Remove(d);
                    }
                    if(v.IDPatient == idPatient && v.VisitDate.Date == d.Date) //czy pacjent juz w tym dniu jest zapisany na wizyte
                    {
                        possibleVisitsList.Remove(d);
                    }
                 }
                foreach(Visit vv in visits)
                {
                    if(vv.VisitDate.TimeOfDay == d.TimeOfDay && vv.VisitDate.Date == d.Date && vv.IDPatient == idPatient) //czy pacjent juz do innego lekarza o tej godz
                    {
                        possibleVisitsList.Remove(d);
                    }
                }
            }
            return possibleVisitsList;
            

        }
    }
}
