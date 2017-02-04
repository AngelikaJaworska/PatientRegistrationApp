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
    public partial class DoctorEditForm : Form
    {
        ClinicEntities dataBase = new ClinicEntities();
        int idReceptionist;
        List<Specialisation> specialisationList;
        int idDoctor;
        int idSpecialisation;

        public DoctorEditForm(int idReceptionist)
        {
            this.idReceptionist = idReceptionist;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DailyForm daily = new DailyForm(idReceptionist);
            daily.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditDoctor(idDoctor);
            MessageBox.Show("Edytowano lekarza");
            DailyForm daily = new DailyForm(idReceptionist);
            daily.Show();
            this.Hide();
        }

        private void DoctorEditForm_Load(object sender, EventArgs e)
        {
            MakeIvisible();
            specialisationList = dataBase.Specialisations.Select(s => s).ToList();

            foreach (Specialisation s in specialisationList)
            {
                cbspecialisation_possibles.Items.Add(s.Name);
            }
            foreach (Specialisation s in specialisationList)
            {
                cbspecialisation2_possibles.Items.Add(s.Name);
            }

            var startHours = Enumerable.Range(09, 09).Select(i => (DateTime.MinValue.AddHours(i)).ToString("HH:mm tt"));
            foreach (string s in startHours)
            {
                cbworkStart_possibles.Items.Add(s);

            }
           
        }
        public void MakeIvisible()
        {
            cbdoctor_possibles.Visible = false;
            ldoctor.Visible = false;
            ledit.Visible = false;
            lname.Visible = false;
            llastname.Visible = false;
            lspecialisation2.Visible = false;
            lworkstart.Visible = false;
            lworkend.Visible = false;
            tbname_possibles.Visible = false;
            tblastname_possibles.Visible = false;
            cbspecialisation2_possibles.Visible = false;
            cbworkStart_possibles.Visible = false;
            cbworkEnd_possibles.Visible = false;
            btnEdit.Visible = false;
            btnsearch.Visible = false;
            btnDelete.Visible = false;
        }
        public void MakeVisible()
        {
            lsearch.Visible = false;
            lspecialisation.Visible = false;
            cbspecialisation_possibles.Visible = false;
            ldoctor.Visible = false;
            cbdoctor_possibles.Visible = false;
            btnsearch.Visible = false;
            btnDelete.Visible = false;
            ledit.Visible = true;
            lname.Visible = true;
            llastname.Visible = true;
            lspecialisation2.Visible = true;
            lworkstart.Visible = true;
            lworkend.Visible = true;
            tbname_possibles.Visible = true;
            tblastname_possibles.Visible = true;
            cbspecialisation2_possibles.Visible = true;
            cbworkStart_possibles.Visible = true;
            cbworkEnd_possibles.Visible = true;
            btnEdit.Visible = true;
            
        }

        private void specialisation_possibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbdoctor_possibles.Items.Clear();
            cbdoctor_possibles.Text = "";
            if (cbspecialisation_possibles != null)
            {
                cbdoctor_possibles.Visible = true;
                btnDelete.Visible = true;
                ldoctor.Visible = true;
                btnsearch.Visible = true;

                int idSpecialisation = cbspecialisation_possibles.SelectedIndex;
                Specialisation selected = specialisationList.ElementAt(idSpecialisation);
                List<Doctor> doctorsList = dataBase.Doctors.Select(s => s).Where(r => r.IDSpecialisation == selected.IDSpecialisation).ToList();

                foreach (Doctor d in doctorsList)
                {
                    cbdoctor_possibles.Items.Add(d.First_Name + " " + d.Last_Name);
                }
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string doctorName = cbdoctor_possibles.SelectedItem.ToString();

                List<string> check = new List<string>();
                List<Doctor> d = dataBase.Doctors.Select(s => s).ToList();
                foreach (Doctor doc in d)
                {
                    check.Add(doc.First_Name + " " + doc.Last_Name);
                    if (check.Contains(doctorName))
                    {
                        idDoctor = doc.IDDoctor;
                        tbname_possibles.Text = doc.First_Name;
                        tblastname_possibles.Text = doc.Last_Name;
                        cbspecialisation2_possibles.Text = doc.Specialisation.Name;
                        cbworkStart_possibles.Text = doc.WorkStart.Hours.ToString();
                        cbworkEnd_possibles.Text = doc.WorkEnd.Hours.ToString();
                        MakeVisible();
                        break;
                    }
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Proszę wybrać imię lekarza!");
            }
        }

        private void name_possibles_TextChanged(object sender, EventArgs e)
        {
            if (!tbname_possibles.Text.All(ch => char.IsLetter(ch)))
            {
                MessageBox.Show("Możliwość wpisania tylko znaków alfabetycznych");
            }
        }

        private void lastname_possibles_TextChanged(object sender, EventArgs e)
        {
            if (!tblastname_possibles.Text.All(ch => char.IsLetter(ch)))
            {
                MessageBox.Show("Możliwość wpisania tylko znaków alfabetycznych");
            }
        }

        private void specialisation2_possibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            idSpecialisation = dataBase.Specialisations.Select(s => s.IDSpecialisation).Where(r => r == cbspecialisation_possibles.SelectedIndex + 1).FirstOrDefault();
        }

        private void workStart_possibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbworkEnd_possibles.Visible = true;
            lworkend.Visible = true;
            cbworkEnd_possibles.Items.Clear();

            string whichStart = cbworkStart_possibles.SelectedItem.ToString();
            var start = DateTime.Parse(whichStart).Hour;
            IEnumerable<string> endHours = null;

            for (int j = 0; j <= 18 - start; j++)
            {
                endHours = Enumerable.Range(start + 1, 0 + j).Select(i => (DateTime.MinValue.AddHours(i)).ToString("HH:mm tt"));

            }

            foreach (string s in endHours)
            {
                cbworkEnd_possibles.Items.Add(s);

            }
        }

        public void EditDoctor(int idDoctor)
        {
            Doctor doctor = dataBase.Doctors.Select(s => s).Where(r => r.IDDoctor == idDoctor).FirstOrDefault();
            if (tbname_possibles.Text != null && tbname_possibles.Text != "")
            {
                doctor.First_Name = tbname_possibles.Text;
            }

            if (tblastname_possibles.Text != null && tblastname_possibles.Text != "")
            {
                doctor.Last_Name = tblastname_possibles.Text;
            }

            if(cbspecialisation2_possibles.Text != null && cbspecialisation2_possibles.Text != "")
            {
                Specialisation id = dataBase.Specialisations.Select(s => s).Where(r => r.Name.Equals(cbspecialisation2_possibles.Text)).FirstOrDefault();
                doctor.IDSpecialisation = id.IDSpecialisation;
            }

            if(cbworkStart_possibles.SelectedItem != null)
            {
                doctor.WorkStart = TimeSpan.Parse(cbworkStart_possibles.SelectedItem.ToString());
            }

            if (cbworkEnd_possibles.SelectedItem != null)
            {
                doctor.WorkEnd = TimeSpan.Parse(cbworkEnd_possibles.SelectedItem.ToString());
            }


            dataBase.SaveChanges();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string[] doctor = cbdoctor_possibles.Text.ToString().Split(' ');
                string name = doctor[0];
                string lastname = doctor[1];
                Specialisation id = dataBase.Specialisations.Select(s => s).Where(r => r.Name.Equals(cbspecialisation_possibles.Text)).FirstOrDefault();
                Doctor doctorDelete = dataBase.Doctors.Select(s => s).Where(r => r.First_Name.Equals(name) && r.Last_Name.Equals(lastname) && r.IDSpecialisation == id.IDSpecialisation).FirstOrDefault();
                List<Visit> visitDelete = dataBase.Visits.Select(s => s).Where(r => r.IDDoctor == doctorDelete.IDDoctor).ToList();

                foreach (Visit v in visitDelete)
                {
                    dataBase.Visits.Remove(v);
                }

                dataBase.Doctors.Remove(doctorDelete);
                dataBase.SaveChanges();
                MessageBox.Show("Usunięto lekarza");
                DailyForm daily = new DailyForm(idReceptionist);
                daily.Show();
                this.Hide();
                    
                

            }
            catch(Exception)
            {
                MessageBox.Show("Dane lekarza są blędne, spróbuj ponownie"); 
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
