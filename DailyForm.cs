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
    public partial class DailyForm : Form
    {
        ClinicEntities dataBase = new ClinicEntities();
        List<Visit> visitsList; 
        int idReceptionist;


        public DailyForm(int idReceptionist)
        {
            this.idReceptionist = idReceptionist;
            InitializeComponent();
        }

        

        private void btnnewPatientRegister_Click(object sender, EventArgs e)
        {
            RegisterForm r = new RegisterForm(idReceptionist);
            r.Show();
            this.Hide();
        }
        
        private void Exit_program(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Show();
            this.Hide();
        }

        private void DailyForm_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            DateTime dt;
            visitsList = dataBase.Visits.Select(s => s).ToList();
            foreach (Visit v in visitsList)
                {
                    if (DateTime.TryParse(v.VisitDate.ToString(), out dt) && dt.Date == DateTime.Today)
                   {
                        ListViewItem lvi = new ListViewItem(v.Patient.First_Name + " " + v.Patient.Last_Name);
                        lvi.SubItems.Add(v.Doctor.Specialisation.Name.ToString());
                        lvi.SubItems.Add(v.Doctor.First_Name + " " + v.Doctor.Last_Name.ToString());
                        lvi.SubItems.Add(v.VisitDate.ToString());
                        listView1.Items.Add(lvi);
                    }
             }
            
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                Application.Exit();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        

    }
}
