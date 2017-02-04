namespace ProjektOI
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.lfindpatient = new System.Windows.Forms.Label();
            this.lnrId = new System.Windows.Forms.Label();
            this.llastname = new System.Windows.Forms.Label();
            this.tbId_possibles = new System.Windows.Forms.TextBox();
            this.tblastName_possibles = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnaddNewPatient = new System.Windows.Forms.Button();
            this.lRegister = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnaddNewDoctor = new System.Windows.Forms.Button();
            this.btneditDoctor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lfindpatient
            // 
            this.lfindpatient.AutoSize = true;
            this.lfindpatient.BackColor = System.Drawing.Color.Transparent;
            this.lfindpatient.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lfindpatient.Location = new System.Drawing.Point(16, 98);
            this.lfindpatient.Name = "lfindpatient";
            this.lfindpatient.Size = new System.Drawing.Size(175, 23);
            this.lfindpatient.TabIndex = 0;
            this.lfindpatient.Text = "Wyszukaj pacjenta:";
            // 
            // lnrId
            // 
            this.lnrId.AutoSize = true;
            this.lnrId.BackColor = System.Drawing.Color.Transparent;
            this.lnrId.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lnrId.Location = new System.Drawing.Point(16, 140);
            this.lnrId.Name = "lnrId";
            this.lnrId.Size = new System.Drawing.Size(220, 23);
            this.lnrId.TabIndex = 1;
            this.lnrId.Text = "Wpisz nr identyfikacyjny";
            // 
            // llastname
            // 
            this.llastname.AutoSize = true;
            this.llastname.BackColor = System.Drawing.Color.Transparent;
            this.llastname.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.llastname.Location = new System.Drawing.Point(12, 195);
            this.llastname.Name = "llastname";
            this.llastname.Size = new System.Drawing.Size(222, 23);
            this.llastname.TabIndex = 2;
            this.llastname.Text = "Wpisz nazwisko pacjenta";
            // 
            // tbId_possibles
            // 
            this.tbId_possibles.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbId_possibles.Location = new System.Drawing.Point(261, 140);
            this.tbId_possibles.MaxLength = 3;
            this.tbId_possibles.Name = "tbId_possibles";
            this.tbId_possibles.Size = new System.Drawing.Size(132, 21);
            this.tbId_possibles.TabIndex = 3;
            this.tbId_possibles.TextChanged += new System.EventHandler(this.Id_possibles_TextChanged);
            // 
            // tblastName_possibles
            // 
            this.tblastName_possibles.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tblastName_possibles.Location = new System.Drawing.Point(261, 195);
            this.tblastName_possibles.Name = "tblastName_possibles";
            this.tblastName_possibles.Size = new System.Drawing.Size(132, 21);
            this.tblastName_possibles.TabIndex = 4;
            this.tblastName_possibles.TextChanged += new System.EventHandler(this.LastName_possibles_TextChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Transparent;
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.Location = new System.Drawing.Point(117, 241);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(215, 56);
            this.btnsearch.TabIndex = 5;
            this.btnsearch.Text = "Wyszukaj";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            this.AcceptButton = btnsearch;
            // 
            // btnaddNewPatient
            // 
            this.btnaddNewPatient.BackColor = System.Drawing.Color.Transparent;
            this.btnaddNewPatient.FlatAppearance.BorderSize = 0;
            this.btnaddNewPatient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnaddNewPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnaddNewPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddNewPatient.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnaddNewPatient.Image = ((System.Drawing.Image)(resources.GetObject("btnaddNewPatient.Image")));
            this.btnaddNewPatient.Location = new System.Drawing.Point(-3, 315);
            this.btnaddNewPatient.Name = "btnaddNewPatient";
            this.btnaddNewPatient.Size = new System.Drawing.Size(210, 56);
            this.btnaddNewPatient.TabIndex = 6;
            this.btnaddNewPatient.Text = "Dodaj nowego pacjenta";
            this.btnaddNewPatient.UseVisualStyleBackColor = false;
            this.btnaddNewPatient.Click += new System.EventHandler(this.btnaddNewPatient_Click);
            // 
            // lRegister
            // 
            this.lRegister.BackColor = System.Drawing.Color.Transparent;
            this.lRegister.Enabled = false;
            this.lRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lRegister.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lRegister.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lRegister.Location = new System.Drawing.Point(12, 31);
            this.lRegister.Name = "lRegister";
            this.lRegister.Size = new System.Drawing.Size(381, 45);
            this.lRegister.TabIndex = 7;
            this.lRegister.Text = "Rejestracja";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(399, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 263);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(213, 315);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(206, 56);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Wróć";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnaddNewDoctor
            // 
            this.btnaddNewDoctor.BackColor = System.Drawing.Color.Transparent;
            this.btnaddNewDoctor.FlatAppearance.BorderSize = 0;
            this.btnaddNewDoctor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnaddNewDoctor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnaddNewDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddNewDoctor.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnaddNewDoctor.Image = ((System.Drawing.Image)(resources.GetObject("btnaddNewDoctor.Image")));
            this.btnaddNewDoctor.Location = new System.Drawing.Point(412, 12);
            this.btnaddNewDoctor.Name = "btnaddNewDoctor";
            this.btnaddNewDoctor.Size = new System.Drawing.Size(233, 64);
            this.btnaddNewDoctor.TabIndex = 10;
            this.btnaddNewDoctor.Text = "Dodaj nowego lekarza";
            this.btnaddNewDoctor.UseVisualStyleBackColor = false;
            this.btnaddNewDoctor.Click += new System.EventHandler(this.btnaddNewDoctor_Click);
            // 
            // btneditDoctor
            // 
            this.btneditDoctor.BackColor = System.Drawing.Color.Transparent;
            this.btneditDoctor.FlatAppearance.BorderSize = 0;
            this.btneditDoctor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btneditDoctor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btneditDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditDoctor.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btneditDoctor.Image = ((System.Drawing.Image)(resources.GetObject("btneditDoctor.Image")));
            this.btneditDoctor.Location = new System.Drawing.Point(412, 80);
            this.btneditDoctor.Name = "btneditDoctor";
            this.btneditDoctor.Size = new System.Drawing.Size(233, 64);
            this.btneditDoctor.TabIndex = 11;
            this.btneditDoctor.Text = "Edytuj/Usuń dane lekarza";
            this.btneditDoctor.UseVisualStyleBackColor = false;
            this.btneditDoctor.Click += new System.EventHandler(this.btneditDoctor_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.btneditDoctor);
            this.Controls.Add(this.btnaddNewDoctor);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lRegister);
            this.Controls.Add(this.btnaddNewPatient);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.tblastName_possibles);
            this.Controls.Add(this.tbId_possibles);
            this.Controls.Add(this.llastname);
            this.Controls.Add(this.lnrId);
            this.Controls.Add(this.lfindpatient);
            this.Name = "RegisterForm";
            this.Text = "Rejestracja pacjenta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lfindpatient;
        private System.Windows.Forms.Label lnrId;
        private System.Windows.Forms.Label llastname;
        private System.Windows.Forms.TextBox tbId_possibles;
        private System.Windows.Forms.TextBox tblastName_possibles;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnaddNewPatient;
        private System.Windows.Forms.Label lRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnaddNewDoctor;
        private System.Windows.Forms.Button btneditDoctor;
    }
}