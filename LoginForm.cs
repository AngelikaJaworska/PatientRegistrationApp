using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace ProjektOI
{
    public partial class LoginForm : Form
    {
        ClinicEntities dataBase = new ClinicEntities();
        List<Receptionist> receptionistList;
        int idReceptionist;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btngoToDaily_Click(object sender, EventArgs e)
        {
            string password = tbreceptionist_password.Text;
            
            if (Checking(password) == true)
            {
                DailyForm d = new DailyForm(idReceptionist);
                d.Show();
                this.Hide();
            }
            else MessageBox.Show("Błąd! Spróbuj ponownie");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            receptionistList = dataBase.Receptionists.Select( r => r).ToList();

            foreach(Receptionist r in receptionistList)
            {
                cblogin_possibles.Items.Add(r.Login);
            }
            tbreceptionist_password.PasswordChar = '*';
        }

        public bool Checking(string password)
        {
            bool b = false;
            password = CalculateMD5Hash(password);
            password = password.ToLower();

            try
            {
                int id = cblogin_possibles.SelectedIndex;
                Receptionist selected = receptionistList.ElementAt(id);
                List<Receptionist> rList = dataBase.Receptionists.Select(s => s).Where(r => r.IDReceptionist == selected.IDReceptionist).ToList();

                foreach (Receptionist r in rList)
                {
                    idReceptionist = r.IDReceptionist;
                }

                if (selected.Password.ToLower() == password)
                {
                    b = true;
                }

                return b;

            }
            catch (System.ArgumentOutOfRangeException) { }
            return b;
        }
        

        public string CalculateMD5Hash(string s)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(s);

            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
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
