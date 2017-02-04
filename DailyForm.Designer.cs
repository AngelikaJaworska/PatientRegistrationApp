namespace ProjektOI
{
    partial class DailyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyForm));
            this.btnnewPatientRegister = new System.Windows.Forms.Button();
            this.labelDaily = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cHPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHSpecialisation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHDoctor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnnewPatientRegister
            // 
            this.btnnewPatientRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnnewPatientRegister.FlatAppearance.BorderSize = 0;
            this.btnnewPatientRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnnewPatientRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnnewPatientRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnewPatientRegister.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnnewPatientRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnnewPatientRegister.Image")));
            this.btnnewPatientRegister.Location = new System.Drawing.Point(-1, 301);
            this.btnnewPatientRegister.Name = "btnnewPatientRegister";
            this.btnnewPatientRegister.Size = new System.Drawing.Size(213, 74);
            this.btnnewPatientRegister.TabIndex = 2;
            this.btnnewPatientRegister.Text = "Przejdź do rejestracji";
            this.btnnewPatientRegister.UseVisualStyleBackColor = false;
            this.btnnewPatientRegister.Click += new System.EventHandler(this.btnnewPatientRegister_Click);
            // 
            // labelDaily
            // 
            this.labelDaily.BackColor = System.Drawing.Color.Transparent;
            this.labelDaily.Enabled = false;
            this.labelDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDaily.Font = new System.Drawing.Font("Georgia", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDaily.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelDaily.Location = new System.Drawing.Point(133, 9);
            this.labelDaily.Name = "labelDaily";
            this.labelDaily.Size = new System.Drawing.Size(446, 52);
            this.labelDaily.TabIndex = 8;
            this.labelDaily.Text = "Dzisiejsze wizyty";
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.Transparent;
            this.btnEnd.FlatAppearance.BorderSize = 0;
            this.btnEnd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEnd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnEnd.Image")));
            this.btnEnd.Location = new System.Drawing.Point(426, 307);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(220, 62);
            this.btnEnd.TabIndex = 9;
            this.btnEnd.Text = "Zakończ";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.Exit_program);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(218, 298);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(211, 80);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Wyloguj";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHPatient,
            this.cHSpecialisation,
            this.cHDoctor,
            this.cHour});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(21, 79);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(601, 202);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // cHPatient
            // 
            this.cHPatient.Text = "Imię i nazwisko pacjenta";
            this.cHPatient.Width = 171;
            // 
            // cHSpecialisation
            // 
            this.cHSpecialisation.Text = "Wizyta do specjalisty";
            this.cHSpecialisation.Width = 156;
            // 
            // cHDoctor
            // 
            this.cHDoctor.Text = "Imię i nazwisko lekarza";
            this.cHDoctor.Width = 142;
            // 
            // cHour
            // 
            this.cHour.Text = "Godzina wizyty";
            this.cHour.Width = 121;
            // 
            // DailyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.labelDaily);
            this.Controls.Add(this.btnnewPatientRegister);
            this.Name = "DailyForm";
            this.Text = "Dzisiejsze wizyty";
            this.Load += new System.EventHandler(this.DailyForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnnewPatientRegister;
        private System.Windows.Forms.Label labelDaily;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader cHPatient;
        private System.Windows.Forms.ColumnHeader cHSpecialisation;
        private System.Windows.Forms.ColumnHeader cHDoctor;
        private System.Windows.Forms.ColumnHeader cHour;
    }
}