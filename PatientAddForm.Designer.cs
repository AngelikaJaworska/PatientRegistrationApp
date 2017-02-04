namespace ProjektOI
{
    partial class PatientAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientAddForm));
            this.lregister = new System.Windows.Forms.Label();
            this.laddpatient = new System.Windows.Forms.Label();
            this.llastname = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lname = new System.Windows.Forms.Label();
            this.lphone = new System.Windows.Forms.Label();
            this.lhomenr = new System.Windows.Forms.Label();
            this.lstreet = new System.Windows.Forms.Label();
            this.lcity = new System.Windows.Forms.Label();
            this.tbname_possibles = new System.Windows.Forms.TextBox();
            this.tblastname_possibles = new System.Windows.Forms.TextBox();
            this.tbstreet_possibles = new System.Windows.Forms.TextBox();
            this.tbhomeNr_possibles = new System.Windows.Forms.TextBox();
            this.tbcity_possibles = new System.Windows.Forms.TextBox();
            this.tbphoneNumber_possibles = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lregister
            // 
            this.lregister.BackColor = System.Drawing.Color.Transparent;
            this.lregister.Enabled = false;
            this.lregister.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lregister.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lregister.Location = new System.Drawing.Point(96, 25);
            this.lregister.Name = "lregister";
            this.lregister.Size = new System.Drawing.Size(536, 40);
            this.lregister.TabIndex = 8;
            this.lregister.Text = "Rejestracja nowego pacjenta";
            // 
            // laddpatient
            // 
            this.laddpatient.AutoSize = true;
            this.laddpatient.BackColor = System.Drawing.Color.Transparent;
            this.laddpatient.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.laddpatient.Location = new System.Drawing.Point(12, 84);
            this.laddpatient.Name = "laddpatient";
            this.laddpatient.Size = new System.Drawing.Size(116, 18);
            this.laddpatient.TabIndex = 9;
            this.laddpatient.Text = "Dodaj pacjenta:";
            // 
            // llastname
            // 
            this.llastname.AutoSize = true;
            this.llastname.BackColor = System.Drawing.Color.Transparent;
            this.llastname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.llastname.Location = new System.Drawing.Point(12, 192);
            this.llastname.Name = "llastname";
            this.llastname.Size = new System.Drawing.Size(138, 18);
            this.llastname.TabIndex = 11;
            this.llastname.Text = "Nazwisko pacjenta";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(77, 304);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(233, 82);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Dodaj pacjenta";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.BackColor = System.Drawing.Color.Transparent;
            this.lname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lname.Location = new System.Drawing.Point(12, 128);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(104, 18);
            this.lname.TabIndex = 14;
            this.lname.Text = "Imię pacjenta";
            // 
            // lphone
            // 
            this.lphone.AutoSize = true;
            this.lphone.BackColor = System.Drawing.Color.Transparent;
            this.lphone.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lphone.Location = new System.Drawing.Point(12, 258);
            this.lphone.Name = "lphone";
            this.lphone.Size = new System.Drawing.Size(119, 18);
            this.lphone.TabIndex = 15;
            this.lphone.Text = "Numer telefonu";
            // 
            // lhomenr
            // 
            this.lhomenr.AutoSize = true;
            this.lhomenr.BackColor = System.Drawing.Color.Transparent;
            this.lhomenr.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lhomenr.Location = new System.Drawing.Point(352, 189);
            this.lhomenr.Name = "lhomenr";
            this.lhomenr.Size = new System.Drawing.Size(102, 18);
            this.lhomenr.TabIndex = 16;
            this.lhomenr.Text = "Numer domu";
            // 
            // lstreet
            // 
            this.lstreet.AutoSize = true;
            this.lstreet.BackColor = System.Drawing.Color.Transparent;
            this.lstreet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstreet.Location = new System.Drawing.Point(352, 125);
            this.lstreet.Name = "lstreet";
            this.lstreet.Size = new System.Drawing.Size(92, 18);
            this.lstreet.TabIndex = 17;
            this.lstreet.Text = "Nazwa ulicy";
            // 
            // lcity
            // 
            this.lcity.AutoSize = true;
            this.lcity.BackColor = System.Drawing.Color.Transparent;
            this.lcity.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lcity.Location = new System.Drawing.Point(352, 255);
            this.lcity.Name = "lcity";
            this.lcity.Size = new System.Drawing.Size(106, 18);
            this.lcity.TabIndex = 18;
            this.lcity.Text = "Nazwa miasta";
            // 
            // tbname_possibles
            // 
            this.tbname_possibles.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbname_possibles.Location = new System.Drawing.Point(199, 126);
            this.tbname_possibles.MaxLength = 100;
            this.tbname_possibles.Name = "tbname_possibles";
            this.tbname_possibles.Size = new System.Drawing.Size(132, 21);
            this.tbname_possibles.TabIndex = 19;
            this.tbname_possibles.TextChanged += new System.EventHandler(this.name_possibles_TextChanged);
            // 
            // tblastname_possibles
            // 
            this.tblastname_possibles.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tblastname_possibles.Location = new System.Drawing.Point(199, 190);
            this.tblastname_possibles.MaxLength = 100;
            this.tblastname_possibles.Name = "tblastname_possibles";
            this.tblastname_possibles.Size = new System.Drawing.Size(132, 21);
            this.tblastname_possibles.TabIndex = 20;
            this.tblastname_possibles.TextChanged += new System.EventHandler(this.lastname_possibles_TextChanged);
            // 
            // tbstreet_possibles
            // 
            this.tbstreet_possibles.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbstreet_possibles.Location = new System.Drawing.Point(500, 123);
            this.tbstreet_possibles.MaxLength = 100;
            this.tbstreet_possibles.Name = "tbstreet_possibles";
            this.tbstreet_possibles.Size = new System.Drawing.Size(132, 21);
            this.tbstreet_possibles.TabIndex = 21;
            // 
            // tbhomeNr_possibles
            // 
            this.tbhomeNr_possibles.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbhomeNr_possibles.Location = new System.Drawing.Point(500, 187);
            this.tbhomeNr_possibles.MaxLength = 4;
            this.tbhomeNr_possibles.Name = "tbhomeNr_possibles";
            this.tbhomeNr_possibles.Size = new System.Drawing.Size(132, 21);
            this.tbhomeNr_possibles.TabIndex = 22;
            // 
            // tbcity_possibles
            // 
            this.tbcity_possibles.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbcity_possibles.Location = new System.Drawing.Point(500, 255);
            this.tbcity_possibles.MaxLength = 100;
            this.tbcity_possibles.Name = "tbcity_possibles";
            this.tbcity_possibles.Size = new System.Drawing.Size(132, 21);
            this.tbcity_possibles.TabIndex = 23;
            this.tbcity_possibles.TextChanged += new System.EventHandler(this.city_possibles_TextChanged);
            // 
            // tbphoneNumber_possibles
            // 
            this.tbphoneNumber_possibles.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbphoneNumber_possibles.Location = new System.Drawing.Point(200, 258);
            this.tbphoneNumber_possibles.MaxLength = 9;
            this.tbphoneNumber_possibles.Name = "tbphoneNumber_possibles";
            this.tbphoneNumber_possibles.Size = new System.Drawing.Size(132, 21);
            this.tbphoneNumber_possibles.TabIndex = 24;
            this.tbphoneNumber_possibles.TextChanged += new System.EventHandler(this.phoneNumber_possibles_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(355, 304);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(233, 82);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Wróć";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PatientAddForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbphoneNumber_possibles);
            this.Controls.Add(this.tbcity_possibles);
            this.Controls.Add(this.tbhomeNr_possibles);
            this.Controls.Add(this.tbstreet_possibles);
            this.Controls.Add(this.tblastname_possibles);
            this.Controls.Add(this.tbname_possibles);
            this.Controls.Add(this.lcity);
            this.Controls.Add(this.lstreet);
            this.Controls.Add(this.lhomenr);
            this.Controls.Add(this.lphone);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.llastname);
            this.Controls.Add(this.laddpatient);
            this.Controls.Add(this.lregister);
            this.Name = "PatientAddForm";
            this.Text = "Rejestracja nowego pacjenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lregister;
        private System.Windows.Forms.Label laddpatient;
        private System.Windows.Forms.Label llastname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label lphone;
        private System.Windows.Forms.Label lhomenr;
        private System.Windows.Forms.Label lstreet;
        private System.Windows.Forms.Label lcity;
        private System.Windows.Forms.TextBox tbname_possibles;
        private System.Windows.Forms.TextBox tblastname_possibles;
        private System.Windows.Forms.TextBox tbstreet_possibles;
        private System.Windows.Forms.TextBox tbhomeNr_possibles;
        private System.Windows.Forms.TextBox tbcity_possibles;
        private System.Windows.Forms.TextBox tbphoneNumber_possibles;
        private System.Windows.Forms.Button btnCancel;
    }
}