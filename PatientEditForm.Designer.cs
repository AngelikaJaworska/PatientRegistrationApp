namespace ProjektOI
{
    partial class PatientEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientEditForm));
            this.ledit = new System.Windows.Forms.Label();
            this.leditpatient = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.llastname = new System.Windows.Forms.Label();
            this.lphone = new System.Windows.Forms.Label();
            this.lstreet = new System.Windows.Forms.Label();
            this.lhomenr = new System.Windows.Forms.Label();
            this.lcity = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbname_possibles = new System.Windows.Forms.TextBox();
            this.tblastname_possibles = new System.Windows.Forms.TextBox();
            this.tbphoneNumber_possibles = new System.Windows.Forms.TextBox();
            this.tbstreet_possibles = new System.Windows.Forms.TextBox();
            this.tbhomeNumber_possibles = new System.Windows.Forms.TextBox();
            this.tbcity_possibles = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ledit
            // 
            this.ledit.BackColor = System.Drawing.Color.Transparent;
            this.ledit.Enabled = false;
            this.ledit.Font = new System.Drawing.Font("Georgia", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ledit.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ledit.Location = new System.Drawing.Point(191, 18);
            this.ledit.Name = "ledit";
            this.ledit.Size = new System.Drawing.Size(291, 40);
            this.ledit.TabIndex = 9;
            this.ledit.Text = "Edycja pacjenta";
            // 
            // leditpatient
            // 
            this.leditpatient.AutoSize = true;
            this.leditpatient.BackColor = System.Drawing.Color.Transparent;
            this.leditpatient.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leditpatient.Location = new System.Drawing.Point(12, 68);
            this.leditpatient.Name = "leditpatient";
            this.leditpatient.Size = new System.Drawing.Size(172, 23);
            this.leditpatient.TabIndex = 10;
            this.leditpatient.Text = "Edytuj pacjenta:";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.BackColor = System.Drawing.Color.Transparent;
            this.lname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lname.Location = new System.Drawing.Point(12, 122);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(104, 18);
            this.lname.TabIndex = 15;
            this.lname.Text = "Imię pacjenta";
            // 
            // llastname
            // 
            this.llastname.AutoSize = true;
            this.llastname.BackColor = System.Drawing.Color.Transparent;
            this.llastname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.llastname.Location = new System.Drawing.Point(11, 192);
            this.llastname.Name = "llastname";
            this.llastname.Size = new System.Drawing.Size(138, 18);
            this.llastname.TabIndex = 16;
            this.llastname.Text = "Nazwisko pacjenta";
            // 
            // lphone
            // 
            this.lphone.AutoSize = true;
            this.lphone.BackColor = System.Drawing.Color.Transparent;
            this.lphone.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lphone.Location = new System.Drawing.Point(11, 270);
            this.lphone.Name = "lphone";
            this.lphone.Size = new System.Drawing.Size(119, 18);
            this.lphone.TabIndex = 17;
            this.lphone.Text = "Numer telefonu";
            // 
            // lstreet
            // 
            this.lstreet.AutoSize = true;
            this.lstreet.BackColor = System.Drawing.Color.Transparent;
            this.lstreet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstreet.Location = new System.Drawing.Point(349, 122);
            this.lstreet.Name = "lstreet";
            this.lstreet.Size = new System.Drawing.Size(92, 18);
            this.lstreet.TabIndex = 18;
            this.lstreet.Text = "Nazwa ulicy";
            // 
            // lhomenr
            // 
            this.lhomenr.AutoSize = true;
            this.lhomenr.BackColor = System.Drawing.Color.Transparent;
            this.lhomenr.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lhomenr.Location = new System.Drawing.Point(349, 189);
            this.lhomenr.Name = "lhomenr";
            this.lhomenr.Size = new System.Drawing.Size(102, 18);
            this.lhomenr.TabIndex = 19;
            this.lhomenr.Text = "Numer domu";
            // 
            // lcity
            // 
            this.lcity.AutoSize = true;
            this.lcity.BackColor = System.Drawing.Color.Transparent;
            this.lcity.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lcity.Location = new System.Drawing.Point(349, 267);
            this.lcity.Name = "lcity";
            this.lcity.Size = new System.Drawing.Size(106, 18);
            this.lcity.TabIndex = 20;
            this.lcity.Text = "Nazwa miasta";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(37, 321);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(256, 66);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Zapisz zmiany";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbname_possibles
            // 
            this.tbname_possibles.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbname_possibles.Location = new System.Drawing.Point(198, 120);
            this.tbname_possibles.MaxLength = 100;
            this.tbname_possibles.Name = "tbname_possibles";
            this.tbname_possibles.Size = new System.Drawing.Size(132, 21);
            this.tbname_possibles.TabIndex = 22;
            this.tbname_possibles.TextChanged += new System.EventHandler(this.name_possibles_TextChanged);
            // 
            // tblastname_possibles
            // 
            this.tblastname_possibles.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tblastname_possibles.Location = new System.Drawing.Point(198, 190);
            this.tblastname_possibles.MaxLength = 100;
            this.tblastname_possibles.Name = "tblastname_possibles";
            this.tblastname_possibles.Size = new System.Drawing.Size(132, 21);
            this.tblastname_possibles.TabIndex = 23;
            this.tblastname_possibles.TextChanged += new System.EventHandler(this.lastname_possibles_TextChanged);
            // 
            // tbphoneNumber_possibles
            // 
            this.tbphoneNumber_possibles.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbphoneNumber_possibles.Location = new System.Drawing.Point(198, 268);
            this.tbphoneNumber_possibles.MaxLength = 100;
            this.tbphoneNumber_possibles.Name = "tbphoneNumber_possibles";
            this.tbphoneNumber_possibles.Size = new System.Drawing.Size(132, 21);
            this.tbphoneNumber_possibles.TabIndex = 24;
            this.tbphoneNumber_possibles.TextChanged += new System.EventHandler(this.phoneNumber_possibles_TextChanged);
            // 
            // tbstreet_possibles
            // 
            this.tbstreet_possibles.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbstreet_possibles.Location = new System.Drawing.Point(504, 120);
            this.tbstreet_possibles.MaxLength = 100;
            this.tbstreet_possibles.Name = "tbstreet_possibles";
            this.tbstreet_possibles.Size = new System.Drawing.Size(132, 21);
            this.tbstreet_possibles.TabIndex = 25;
            // 
            // tbhomeNumber_possibles
            // 
            this.tbhomeNumber_possibles.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbhomeNumber_possibles.Location = new System.Drawing.Point(504, 187);
            this.tbhomeNumber_possibles.MaxLength = 100;
            this.tbhomeNumber_possibles.Name = "tbhomeNumber_possibles";
            this.tbhomeNumber_possibles.Size = new System.Drawing.Size(132, 21);
            this.tbhomeNumber_possibles.TabIndex = 26;
            // 
            // tbcity_possibles
            // 
            this.tbcity_possibles.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbcity_possibles.Location = new System.Drawing.Point(504, 265);
            this.tbcity_possibles.MaxLength = 100;
            this.tbcity_possibles.Name = "tbcity_possibles";
            this.tbcity_possibles.Size = new System.Drawing.Size(132, 21);
            this.tbcity_possibles.TabIndex = 27;
            this.tbcity_possibles.TextChanged += new System.EventHandler(this.city_possibles_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(352, 321);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(256, 66);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Wróć";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PatientEditForm
            // 
            this.AcceptButton = this.btnEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbcity_possibles);
            this.Controls.Add(this.tbhomeNumber_possibles);
            this.Controls.Add(this.tbstreet_possibles);
            this.Controls.Add(this.tbphoneNumber_possibles);
            this.Controls.Add(this.tblastname_possibles);
            this.Controls.Add(this.tbname_possibles);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lcity);
            this.Controls.Add(this.lhomenr);
            this.Controls.Add(this.lstreet);
            this.Controls.Add(this.lphone);
            this.Controls.Add(this.llastname);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.leditpatient);
            this.Controls.Add(this.ledit);
            this.Name = "PatientEditForm";
            this.Text = "Edycja pacjenta";
            this.Load += new System.EventHandler(this.PatientEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ledit;
        private System.Windows.Forms.Label leditpatient;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label llastname;
        private System.Windows.Forms.Label lphone;
        private System.Windows.Forms.Label lstreet;
        private System.Windows.Forms.Label lhomenr;
        private System.Windows.Forms.Label lcity;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbname_possibles;
        private System.Windows.Forms.TextBox tblastname_possibles;
        private System.Windows.Forms.TextBox tbphoneNumber_possibles;
        private System.Windows.Forms.TextBox tbstreet_possibles;
        private System.Windows.Forms.TextBox tbhomeNumber_possibles;
        private System.Windows.Forms.TextBox tbcity_possibles;
        private System.Windows.Forms.Button btnCancel;
    }
}