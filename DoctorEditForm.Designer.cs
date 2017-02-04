namespace ProjektOI
{
    partial class DoctorEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorEditForm));
            this.leditdoctor = new System.Windows.Forms.Label();
            this.lsearch = new System.Windows.Forms.Label();
            this.ldoctor = new System.Windows.Forms.Label();
            this.lspecialisation = new System.Windows.Forms.Label();
            this.cbspecialisation_possibles = new System.Windows.Forms.ComboBox();
            this.cbdoctor_possibles = new System.Windows.Forms.ComboBox();
            this.ledit = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.llastname = new System.Windows.Forms.Label();
            this.lspecialisation2 = new System.Windows.Forms.Label();
            this.lworkstart = new System.Windows.Forms.Label();
            this.lworkend = new System.Windows.Forms.Label();
            this.cbworkStart_possibles = new System.Windows.Forms.ComboBox();
            this.cbworkEnd_possibles = new System.Windows.Forms.ComboBox();
            this.tbname_possibles = new System.Windows.Forms.TextBox();
            this.tblastname_possibles = new System.Windows.Forms.TextBox();
            this.cbspecialisation2_possibles = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // leditdoctor
            // 
            this.leditdoctor.BackColor = System.Drawing.Color.Transparent;
            this.leditdoctor.Enabled = false;
            this.leditdoctor.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leditdoctor.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.leditdoctor.Location = new System.Drawing.Point(188, 2);
            this.leditdoctor.Name = "leditdoctor";
            this.leditdoctor.Size = new System.Drawing.Size(297, 29);
            this.leditdoctor.TabIndex = 12;
            this.leditdoctor.Text = "Edycja danych lekarza";
            // 
            // lsearch
            // 
            this.lsearch.AutoSize = true;
            this.lsearch.BackColor = System.Drawing.Color.Transparent;
            this.lsearch.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lsearch.Location = new System.Drawing.Point(6, 31);
            this.lsearch.Name = "lsearch";
            this.lsearch.Size = new System.Drawing.Size(136, 18);
            this.lsearch.TabIndex = 13;
            this.lsearch.Text = "Wyszukaj lekarza:";
            // 
            // ldoctor
            // 
            this.ldoctor.AutoSize = true;
            this.ldoctor.BackColor = System.Drawing.Color.Transparent;
            this.ldoctor.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ldoctor.Location = new System.Drawing.Point(399, 43);
            this.ldoctor.Name = "ldoctor";
            this.ldoctor.Size = new System.Drawing.Size(117, 18);
            this.ldoctor.TabIndex = 16;
            this.ldoctor.Text = "Imię i nazwisko";
            // 
            // lspecialisation
            // 
            this.lspecialisation.AutoSize = true;
            this.lspecialisation.BackColor = System.Drawing.Color.Transparent;
            this.lspecialisation.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lspecialisation.Location = new System.Drawing.Point(6, 67);
            this.lspecialisation.Name = "lspecialisation";
            this.lspecialisation.Size = new System.Drawing.Size(95, 18);
            this.lspecialisation.TabIndex = 23;
            this.lspecialisation.Text = "Specjalizacja";
            // 
            // cbspecialisation_possibles
            // 
            this.cbspecialisation_possibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbspecialisation_possibles.FormattingEnabled = true;
            this.cbspecialisation_possibles.Location = new System.Drawing.Point(152, 67);
            this.cbspecialisation_possibles.Name = "cbspecialisation_possibles";
            this.cbspecialisation_possibles.Size = new System.Drawing.Size(210, 21);
            this.cbspecialisation_possibles.TabIndex = 27;
            this.cbspecialisation_possibles.SelectedIndexChanged += new System.EventHandler(this.specialisation_possibles_SelectedIndexChanged);
            // 
            // cbdoctor_possibles
            // 
            this.cbdoctor_possibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdoctor_possibles.FormattingEnabled = true;
            this.cbdoctor_possibles.Location = new System.Drawing.Point(402, 64);
            this.cbdoctor_possibles.Name = "cbdoctor_possibles";
            this.cbdoctor_possibles.Size = new System.Drawing.Size(197, 21);
            this.cbdoctor_possibles.TabIndex = 28;
            // 
            // ledit
            // 
            this.ledit.AutoSize = true;
            this.ledit.BackColor = System.Drawing.Color.Transparent;
            this.ledit.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ledit.Location = new System.Drawing.Point(6, 167);
            this.ledit.Name = "ledit";
            this.ledit.Size = new System.Drawing.Size(115, 18);
            this.ledit.TabIndex = 29;
            this.ledit.Text = "Dane do edycji:";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.BackColor = System.Drawing.Color.Transparent;
            this.lname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lname.Location = new System.Drawing.Point(6, 214);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(96, 18);
            this.lname.TabIndex = 30;
            this.lname.Text = "Imię lekarza";
            // 
            // llastname
            // 
            this.llastname.AutoSize = true;
            this.llastname.BackColor = System.Drawing.Color.Transparent;
            this.llastname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.llastname.Location = new System.Drawing.Point(6, 262);
            this.llastname.Name = "llastname";
            this.llastname.Size = new System.Drawing.Size(130, 18);
            this.llastname.TabIndex = 31;
            this.llastname.Text = "Nazwisko lekarza";
            // 
            // lspecialisation2
            // 
            this.lspecialisation2.AutoSize = true;
            this.lspecialisation2.BackColor = System.Drawing.Color.Transparent;
            this.lspecialisation2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lspecialisation2.Location = new System.Drawing.Point(11, 312);
            this.lspecialisation2.Name = "lspecialisation2";
            this.lspecialisation2.Size = new System.Drawing.Size(95, 18);
            this.lspecialisation2.TabIndex = 32;
            this.lspecialisation2.Text = "Specjalizacja";
            // 
            // lworkstart
            // 
            this.lworkstart.AutoSize = true;
            this.lworkstart.BackColor = System.Drawing.Color.Transparent;
            this.lworkstart.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lworkstart.Location = new System.Drawing.Point(409, 177);
            this.lworkstart.Name = "lworkstart";
            this.lworkstart.Size = new System.Drawing.Size(193, 18);
            this.lworkstart.TabIndex = 33;
            this.lworkstart.Text = "Godzina rozpoczęcia pracy";
            // 
            // lworkend
            // 
            this.lworkend.AutoSize = true;
            this.lworkend.BackColor = System.Drawing.Color.Transparent;
            this.lworkend.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lworkend.Location = new System.Drawing.Point(409, 232);
            this.lworkend.Name = "lworkend";
            this.lworkend.Size = new System.Drawing.Size(197, 18);
            this.lworkend.TabIndex = 34;
            this.lworkend.Text = "Godzina zakończenia pracy";
            // 
            // cbworkStart_possibles
            // 
            this.cbworkStart_possibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbworkStart_possibles.FormattingEnabled = true;
            this.cbworkStart_possibles.Location = new System.Drawing.Point(412, 208);
            this.cbworkStart_possibles.Name = "cbworkStart_possibles";
            this.cbworkStart_possibles.Size = new System.Drawing.Size(190, 21);
            this.cbworkStart_possibles.TabIndex = 35;
            this.cbworkStart_possibles.SelectedIndexChanged += new System.EventHandler(this.workStart_possibles_SelectedIndexChanged);
            // 
            // cbworkEnd_possibles
            // 
            this.cbworkEnd_possibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbworkEnd_possibles.FormattingEnabled = true;
            this.cbworkEnd_possibles.Location = new System.Drawing.Point(412, 263);
            this.cbworkEnd_possibles.Name = "cbworkEnd_possibles";
            this.cbworkEnd_possibles.Size = new System.Drawing.Size(190, 21);
            this.cbworkEnd_possibles.TabIndex = 36;
            // 
            // tbname_possibles
            // 
            this.tbname_possibles.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbname_possibles.Location = new System.Drawing.Point(152, 211);
            this.tbname_possibles.MaxLength = 100;
            this.tbname_possibles.Name = "tbname_possibles";
            this.tbname_possibles.Size = new System.Drawing.Size(197, 21);
            this.tbname_possibles.TabIndex = 37;
            this.tbname_possibles.TextChanged += new System.EventHandler(this.name_possibles_TextChanged);
            // 
            // tblastname_possibles
            // 
            this.tblastname_possibles.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tblastname_possibles.Location = new System.Drawing.Point(152, 259);
            this.tblastname_possibles.MaxLength = 100;
            this.tblastname_possibles.Name = "tblastname_possibles";
            this.tblastname_possibles.Size = new System.Drawing.Size(197, 21);
            this.tblastname_possibles.TabIndex = 38;
            this.tblastname_possibles.TextChanged += new System.EventHandler(this.lastname_possibles_TextChanged);
            // 
            // cbspecialisation2_possibles
            // 
            this.cbspecialisation2_possibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbspecialisation2_possibles.FormattingEnabled = true;
            this.cbspecialisation2_possibles.Location = new System.Drawing.Point(152, 309);
            this.cbspecialisation2_possibles.Name = "cbspecialisation2_possibles";
            this.cbspecialisation2_possibles.Size = new System.Drawing.Size(197, 21);
            this.cbspecialisation2_possibles.TabIndex = 39;
            this.cbspecialisation2_possibles.SelectedIndexChanged += new System.EventHandler(this.specialisation2_possibles_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(412, 293);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(203, 56);
            this.btnEdit.TabIndex = 40;
            this.btnEdit.Text = "Edytuj dane lekarza";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(425, 101);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(207, 60);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Wróć";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Transparent;
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.Location = new System.Drawing.Point(9, 101);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(213, 60);
            this.btnsearch.TabIndex = 42;
            this.btnsearch.Text = "Wyszukaj";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(215, 103);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(213, 56);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Usuń lekarza";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DoctorEditForm
            // 
            this.AcceptButton = this.btnsearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(644, 361);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbspecialisation2_possibles);
            this.Controls.Add(this.tblastname_possibles);
            this.Controls.Add(this.tbname_possibles);
            this.Controls.Add(this.cbworkEnd_possibles);
            this.Controls.Add(this.cbworkStart_possibles);
            this.Controls.Add(this.lworkend);
            this.Controls.Add(this.lworkstart);
            this.Controls.Add(this.lspecialisation2);
            this.Controls.Add(this.llastname);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.ledit);
            this.Controls.Add(this.cbdoctor_possibles);
            this.Controls.Add(this.cbspecialisation_possibles);
            this.Controls.Add(this.lspecialisation);
            this.Controls.Add(this.ldoctor);
            this.Controls.Add(this.lsearch);
            this.Controls.Add(this.leditdoctor);
            this.Name = "DoctorEditForm";
            this.Text = "Edytuj dane lekarza";
            this.Load += new System.EventHandler(this.DoctorEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label leditdoctor;
        private System.Windows.Forms.Label lsearch;
        private System.Windows.Forms.Label ldoctor;
        private System.Windows.Forms.Label lspecialisation;
        private System.Windows.Forms.ComboBox cbspecialisation_possibles;
        private System.Windows.Forms.ComboBox cbdoctor_possibles;
        private System.Windows.Forms.Label ledit;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label llastname;
        private System.Windows.Forms.Label lspecialisation2;
        private System.Windows.Forms.Label lworkstart;
        private System.Windows.Forms.Label lworkend;
        private System.Windows.Forms.ComboBox cbworkStart_possibles;
        private System.Windows.Forms.ComboBox cbworkEnd_possibles;
        private System.Windows.Forms.TextBox tbname_possibles;
        private System.Windows.Forms.TextBox tblastname_possibles;
        private System.Windows.Forms.ComboBox cbspecialisation2_possibles;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnDelete;
    }
}