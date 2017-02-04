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
    public partial class DoctorAddForm : Form
    {
        ClinicEntities dataBase = new ClinicEntities();
        int idReceptionist;
        int idSpecialisation;
        List<Specialisation> specialisationList;

        public DoctorAddForm(int idReceptionist)
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                Doctor doctor = new Doctor();
                doctor.First_Name = tbname_possibles.Text;
                doctor.Last_Name = tblastname_possibles.Text;
                doctor.IDSpecialisation = idSpecialisation;
                doctor.WorkStart = TimeSpan.Parse(cbworkStart_possibles.SelectedItem.ToString());
                doctor.WorkEnd = TimeSpan.Parse(cbworkEnd_possibles.SelectedItem.ToString());
           
                if(doctor.First_Name != null && doctor.Last_Name != null && doctor.IDSpecialisation != 0 && doctor.WorkStart != null && doctor.WorkEnd != null)
                {
                    dataBase.Doctors.Add(doctor);
                    dataBase.SaveChanges();
                    MessageBox.Show("Dodano lekarza");
                    DailyForm daily = new DailyForm(idReceptionist);
                    daily.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Błąd, proszę uzupełnić wszystkie pola odpowiednimi danymi");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd, proszę uzupełnić wszystkie pola odpowiednimi danymi");
            }
           
         }

        private void DoctorAddForm_Load(object sender, EventArgs e)
        {
            cbworkEnd_possibles.Visible = false;
            lworkend.Visible = false;
            specialisationList = dataBase.Specialisations.Select(s => s).ToList();
            
            foreach(Specialisation s in specialisationList)
            {
                cbspecialisation_possibles.Items.Add(s.Name);
            }

            var startHours = Enumerable.Range(09, 09).Select(i => (DateTime.MinValue.AddHours(i)).ToString("HH:mm tt"));
            foreach (string s in startHours)
            { 
                cbworkStart_possibles.Items.Add(s); 
            
            }

        }

        private void name_possibles_TextChanged(object sender, EventArgs e)
        {
            if(! tbname_possibles.Text.All(ch => char.IsLetter(ch)))
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

        private void specialisation_possibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            idSpecialisation= dataBase.Specialisations.Select(s => s.IDSpecialisation).Where(r => r == cbspecialisation_possibles.SelectedIndex+1).FirstOrDefault();
        }

     
        private void workStart_possibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbworkEnd_possibles.Visible = true;
            lworkend.Visible = true;
            cbworkEnd_possibles.Items.Clear();

            string whichStart = cbworkStart_possibles.SelectedItem.ToString();
            var start = DateTime.Parse(whichStart).Hour;
            IEnumerable<string> endHours = null;

            for(int j =0; j <= 18 - start; j++)
            {
                endHours = Enumerable.Range(start+1, 0 + j).Select(i => (DateTime.MinValue.AddHours(i)).ToString("HH:mm tt"));
                
            }

            foreach (string s in endHours)
            {
                cbworkEnd_possibles.Items.Add(s);

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
