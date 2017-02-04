namespace ProjektOI
{
    partial class EgzaminationEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EgzaminationEditForm));
            this.leditvisit = new System.Windows.Forms.Label();
            this.lsearch = new System.Windows.Forms.Label();
            this.lspecialisation = new System.Windows.Forms.Label();
            this.cbspecialisation_possibles = new System.Windows.Forms.ComboBox();
            this.ldoctor = new System.Windows.Forms.Label();
            this.cbdoctor_possibles = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ledit = new System.Windows.Forms.Label();
            this.lnewvisit = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lvisit = new System.Windows.Forms.Label();
            this.cbdate_possibles = new System.Windows.Forms.ComboBox();
            this.lbnewvisit = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leditvisit
            // 
            this.leditvisit.BackColor = System.Drawing.Color.Transparent;
            this.leditvisit.Enabled = false;
            this.leditvisit.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leditvisit.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.leditvisit.Location = new System.Drawing.Point(193, 9);
            this.leditvisit.Name = "leditvisit";
            this.leditvisit.Size = new System.Drawing.Size(308, 54);
            this.leditvisit.TabIndex = 13;
            this.leditvisit.Text = "Edycja wizyty";
            // 
            // lsearch
            // 
            this.lsearch.AutoSize = true;
            this.lsearch.BackColor = System.Drawing.Color.Transparent;
            this.lsearch.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lsearch.Location = new System.Drawing.Point(12, 54);
            this.lsearch.Name = "lsearch";
            this.lsearch.Size = new System.Drawing.Size(136, 18);
            this.lsearch.TabIndex = 14;
            this.lsearch.Text = "Wyszukaj lekarza:";
            // 
            // lspecialisation
            // 
            this.lspecialisation.AutoSize = true;
            this.lspecialisation.BackColor = System.Drawing.Color.Transparent;
            this.lspecialisation.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lspecialisation.Location = new System.Drawing.Point(12, 78);
            this.lspecialisation.Name = "lspecialisation";
            this.lspecialisation.Size = new System.Drawing.Size(95, 18);
            this.lspecialisation.TabIndex = 24;
            this.lspecialisation.Text = "Specjalizacja";
            // 
            // cbspecialisation_possibles
            // 
            this.cbspecialisation_possibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbspecialisation_possibles.FormattingEnabled = true;
            this.cbspecialisation_possibles.Location = new System.Drawing.Point(146, 79);
            this.cbspecialisation_possibles.Name = "cbspecialisation_possibles";
            this.cbspecialisation_possibles.Size = new System.Drawing.Size(197, 21);
            this.cbspecialisation_possibles.TabIndex = 28;
            this.cbspecialisation_possibles.SelectedIndexChanged += new System.EventHandler(this.specialisation_possibles_SelectedIndexChanged);
            // 
            // ldoctor
            // 
            this.ldoctor.AutoSize = true;
            this.ldoctor.BackColor = System.Drawing.Color.Transparent;
            this.ldoctor.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ldoctor.Location = new System.Drawing.Point(403, 54);
            this.ldoctor.Name = "ldoctor";
            this.ldoctor.Size = new System.Drawing.Size(117, 18);
            this.ldoctor.TabIndex = 29;
            this.ldoctor.Text = "Imię i nazwisko";
            // 
            // cbdoctor_possibles
            // 
            this.cbdoctor_possibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdoctor_possibles.FormattingEnabled = true;
            this.cbdoctor_possibles.Location = new System.Drawing.Point(406, 79);
            this.cbdoctor_possibles.Name = "cbdoctor_possibles";
            this.cbdoctor_possibles.Size = new System.Drawing.Size(197, 21);
            this.cbdoctor_possibles.TabIndex = 30;
            this.cbdoctor_possibles.SelectedIndexChanged += new System.EventHandler(this.doctor_possibles_SelectedIndexChanged);
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
            this.btnsearch.Location = new System.Drawing.Point(138, 138);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(204, 60);
            this.btnsearch.TabIndex = 43;
            this.btnsearch.Text = "Wyszukaj";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(138, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(205, 60);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Wróć";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ledit
            // 
            this.ledit.AutoSize = true;
            this.ledit.BackColor = System.Drawing.Color.Transparent;
            this.ledit.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ledit.Location = new System.Drawing.Point(12, 218);
            this.ledit.Name = "ledit";
            this.ledit.Size = new System.Drawing.Size(115, 18);
            this.ledit.TabIndex = 45;
            this.ledit.Text = "Dane do edycji:";
            // 
            // lnewvisit
            // 
            this.lnewvisit.AutoSize = true;
            this.lnewvisit.BackColor = System.Drawing.Color.Transparent;
            this.lnewvisit.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lnewvisit.Location = new System.Drawing.Point(12, 245);
            this.lnewvisit.Name = "lnewvisit";
            this.lnewvisit.Size = new System.Drawing.Size(92, 18);
            this.lnewvisit.TabIndex = 47;
            this.lnewvisit.Text = "Data wizyty";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Transparent;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.Location = new System.Drawing.Point(139, 296);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(204, 60);
            this.btnsave.TabIndex = 48;
            this.btnsave.Text = "Zapisz";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            this.AcceptButton = btnsave;

            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(379, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 261);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // lvisit
            // 
            this.lvisit.AutoSize = true;
            this.lvisit.BackColor = System.Drawing.Color.Transparent;
            this.lvisit.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvisit.Location = new System.Drawing.Point(12, 115);
            this.lvisit.Name = "lvisit";
            this.lvisit.Size = new System.Drawing.Size(92, 18);
            this.lvisit.TabIndex = 50;
            this.lvisit.Text = "Data wizyty";
            // 
            // cbdate_possibles
            // 
            this.cbdate_possibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdate_possibles.FormattingEnabled = true;
            this.cbdate_possibles.Location = new System.Drawing.Point(146, 115);
            this.cbdate_possibles.Name = "cbdate_possibles";
            this.cbdate_possibles.Size = new System.Drawing.Size(197, 21);
            this.cbdate_possibles.TabIndex = 51;
            // 
            // lbnewvisit
            // 
            this.lbnewvisit.FormattingEnabled = true;
            this.lbnewvisit.Location = new System.Drawing.Point(146, 218);
            this.lbnewvisit.Name = "lbnewvisit";
            this.lbnewvisit.Size = new System.Drawing.Size(197, 69);
            this.lbnewvisit.TabIndex = 52;
            // 
            // EgzaminationEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.lbnewvisit);
            this.Controls.Add(this.cbdate_possibles);
            this.Controls.Add(this.lvisit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lnewvisit);
            this.Controls.Add(this.ledit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.cbdoctor_possibles);
            this.Controls.Add(this.ldoctor);
            this.Controls.Add(this.cbspecialisation_possibles);
            this.Controls.Add(this.lspecialisation);
            this.Controls.Add(this.lsearch);
            this.Controls.Add(this.leditvisit);
            this.Name = "EgzaminationEditForm";
            this.Text = "Edycja Wizyty";
            this.Load += new System.EventHandler(this.EgzaminationEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label leditvisit;
        private System.Windows.Forms.Label lsearch;
        private System.Windows.Forms.Label lspecialisation;
        private System.Windows.Forms.ComboBox cbspecialisation_possibles;
        private System.Windows.Forms.Label ldoctor;
        private System.Windows.Forms.ComboBox cbdoctor_possibles;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label ledit;
        private System.Windows.Forms.Label lnewvisit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lvisit;
        private System.Windows.Forms.ComboBox cbdate_possibles;
        private System.Windows.Forms.ListBox lbnewvisit;

    }
}