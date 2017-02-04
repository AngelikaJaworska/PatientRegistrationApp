namespace ProjektOI
{
    partial class DoctorAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorAddForm));
            this.laddpatient = new System.Windows.Forms.Label();
            this.lregister = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.tbname_possibles = new System.Windows.Forms.TextBox();
            this.llastname = new System.Windows.Forms.Label();
            this.lspecialisation = new System.Windows.Forms.Label();
            this.lworkstart = new System.Windows.Forms.Label();
            this.lworkend = new System.Windows.Forms.Label();
            this.tblastname_possibles = new System.Windows.Forms.TextBox();
            this.cbspecialisation_possibles = new System.Windows.Forms.ComboBox();
            this.cbworkStart_possibles = new System.Windows.Forms.ComboBox();
            this.cbworkEnd_possibles = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // laddpatient
            // 
            this.laddpatient.AutoSize = true;
            this.laddpatient.BackColor = System.Drawing.Color.Transparent;
            this.laddpatient.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.laddpatient.Location = new System.Drawing.Point(40, 103);
            this.laddpatient.Name = "laddpatient";
            this.laddpatient.Size = new System.Drawing.Size(108, 18);
            this.laddpatient.TabIndex = 10;
            this.laddpatient.Text = "Dodaj lekarza:";
            // 
            // lregister
            // 
            this.lregister.BackColor = System.Drawing.Color.Transparent;
            this.lregister.Enabled = false;
            this.lregister.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lregister.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lregister.Location = new System.Drawing.Point(77, 28);
            this.lregister.Name = "lregister";
            this.lregister.Size = new System.Drawing.Size(536, 40);
            this.lregister.TabIndex = 11;
            this.lregister.Text = "Rejestracja nowego lekarza";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.BackColor = System.Drawing.Color.Transparent;
            this.lname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lname.Location = new System.Drawing.Point(40, 149);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(96, 18);
            this.lname.TabIndex = 15;
            this.lname.Text = "Imie lekarza";
            // 
            // tbname_possibles
            // 
            this.tbname_possibles.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbname_possibles.Location = new System.Drawing.Point(209, 146);
            this.tbname_possibles.MaxLength = 100;
            this.tbname_possibles.Name = "tbname_possibles";
            this.tbname_possibles.Size = new System.Drawing.Size(153, 21);
            this.tbname_possibles.TabIndex = 20;
            this.tbname_possibles.TextChanged += new System.EventHandler(this.name_possibles_TextChanged);
            // 
            // llastname
            // 
            this.llastname.AutoSize = true;
            this.llastname.BackColor = System.Drawing.Color.Transparent;
            this.llastname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.llastname.Location = new System.Drawing.Point(40, 201);
            this.llastname.Name = "llastname";
            this.llastname.Size = new System.Drawing.Size(130, 18);
            this.llastname.TabIndex = 21;
            this.llastname.Text = "Nazwisko lekarza";
            // 
            // lspecialisation
            // 
            this.lspecialisation.AutoSize = true;
            this.lspecialisation.BackColor = System.Drawing.Color.Transparent;
            this.lspecialisation.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lspecialisation.Location = new System.Drawing.Point(40, 253);
            this.lspecialisation.Name = "lspecialisation";
            this.lspecialisation.Size = new System.Drawing.Size(95, 18);
            this.lspecialisation.TabIndex = 22;
            this.lspecialisation.Text = "Specjalizacja";
            // 
            // lworkstart
            // 
            this.lworkstart.AutoSize = true;
            this.lworkstart.BackColor = System.Drawing.Color.Transparent;
            this.lworkstart.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lworkstart.Location = new System.Drawing.Point(389, 103);
            this.lworkstart.Name = "lworkstart";
            this.lworkstart.Size = new System.Drawing.Size(193, 18);
            this.lworkstart.TabIndex = 23;
            this.lworkstart.Text = "Godzina rozpoczęcia pracy";
            // 
            // lworkend
            // 
            this.lworkend.AutoSize = true;
            this.lworkend.BackColor = System.Drawing.Color.Transparent;
            this.lworkend.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lworkend.Location = new System.Drawing.Point(389, 201);
            this.lworkend.Name = "lworkend";
            this.lworkend.Size = new System.Drawing.Size(197, 18);
            this.lworkend.TabIndex = 24;
            this.lworkend.Text = "Godzina zakonczenia pracy";
            // 
            // tblastname_possibles
            // 
            this.tblastname_possibles.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tblastname_possibles.Location = new System.Drawing.Point(209, 201);
            this.tblastname_possibles.MaxLength = 100;
            this.tblastname_possibles.Name = "tblastname_possibles";
            this.tblastname_possibles.Size = new System.Drawing.Size(153, 21);
            this.tblastname_possibles.TabIndex = 25;
            this.tblastname_possibles.TextChanged += new System.EventHandler(this.lastname_possibles_TextChanged);
            // 
            // cbspecialisation_possibles
            // 
            this.cbspecialisation_possibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbspecialisation_possibles.FormattingEnabled = true;
            this.cbspecialisation_possibles.Location = new System.Drawing.Point(209, 253);
            this.cbspecialisation_possibles.Name = "cbspecialisation_possibles";
            this.cbspecialisation_possibles.Size = new System.Drawing.Size(153, 21);
            this.cbspecialisation_possibles.TabIndex = 26;
            this.cbspecialisation_possibles.SelectedIndexChanged += new System.EventHandler(this.specialisation_possibles_SelectedIndexChanged);
            // 
            // cbworkStart_possibles
            // 
            this.cbworkStart_possibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbworkStart_possibles.FormattingEnabled = true;
            this.cbworkStart_possibles.Location = new System.Drawing.Point(392, 147);
            this.cbworkStart_possibles.Name = "cbworkStart_possibles";
            this.cbworkStart_possibles.Size = new System.Drawing.Size(190, 21);
            this.cbworkStart_possibles.TabIndex = 27;
            this.cbworkStart_possibles.SelectedIndexChanged += new System.EventHandler(this.workStart_possibles_SelectedIndexChanged);
            // 
            // cbworkEnd_possibles
            // 
            this.cbworkEnd_possibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbworkEnd_possibles.FormattingEnabled = true;
            this.cbworkEnd_possibles.Location = new System.Drawing.Point(392, 253);
            this.cbworkEnd_possibles.Name = "cbworkEnd_possibles";
            this.cbworkEnd_possibles.Size = new System.Drawing.Size(190, 21);
            this.cbworkEnd_possibles.TabIndex = 28;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Transparent;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(66, 303);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(233, 82);
            this.btnadd.TabIndex = 29;
            this.btnadd.Text = "Dodaj lekarza";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(339, 303);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(233, 82);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Wróć";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DoctorAddForm
            // 
            this.AcceptButton = this.btnadd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cbworkEnd_possibles);
            this.Controls.Add(this.cbworkStart_possibles);
            this.Controls.Add(this.cbspecialisation_possibles);
            this.Controls.Add(this.tblastname_possibles);
            this.Controls.Add(this.lworkend);
            this.Controls.Add(this.lworkstart);
            this.Controls.Add(this.lspecialisation);
            this.Controls.Add(this.llastname);
            this.Controls.Add(this.tbname_possibles);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.lregister);
            this.Controls.Add(this.laddpatient);
            this.Name = "DoctorAddForm";
            this.Text = "Rejestracja nowego lekarza";
            this.Load += new System.EventHandler(this.DoctorAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laddpatient;
        private System.Windows.Forms.Label lregister;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.TextBox tbname_possibles;
        private System.Windows.Forms.Label llastname;
        private System.Windows.Forms.Label lspecialisation;
        private System.Windows.Forms.Label lworkstart;
        private System.Windows.Forms.Label lworkend;
        private System.Windows.Forms.TextBox tblastname_possibles;
        private System.Windows.Forms.ComboBox cbspecialisation_possibles;
        private System.Windows.Forms.ComboBox cbworkStart_possibles;
        private System.Windows.Forms.ComboBox cbworkEnd_possibles;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnCancel;
    }
}