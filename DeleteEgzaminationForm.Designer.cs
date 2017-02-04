namespace ProjektOI
{
    partial class DeleteEgzaminationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteEgzaminationForm));
            this.cbdate_possibles = new System.Windows.Forms.ComboBox();
            this.ldelete = new System.Windows.Forms.Label();
            this.btnpatientQuit = new System.Windows.Forms.Button();
            this.btnsaveDelete = new System.Windows.Forms.Button();
            this.cbdoctor_possibles = new System.Windows.Forms.ComboBox();
            this.ldoctor = new System.Windows.Forms.Label();
            this.lvisitDate = new System.Windows.Forms.Label();
            this.lspecialization = new System.Windows.Forms.Label();
            this.cbspecialisation_possibles = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbdate_possibles
            // 
            this.cbdate_possibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdate_possibles.FormattingEnabled = true;
            this.cbdate_possibles.Location = new System.Drawing.Point(223, 250);
            this.cbdate_possibles.Name = "cbdate_possibles";
            this.cbdate_possibles.Size = new System.Drawing.Size(344, 21);
            this.cbdate_possibles.TabIndex = 0;
            // 
            // ldelete
            // 
            this.ldelete.AutoSize = true;
            this.ldelete.BackColor = System.Drawing.Color.Transparent;
            this.ldelete.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ldelete.Location = new System.Drawing.Point(84, 29);
            this.ldelete.Name = "ldelete";
            this.ldelete.Size = new System.Drawing.Size(496, 38);
            this.ldelete.TabIndex = 1;
            this.ldelete.Text = "Wybierz wizytę do odwołania";
            // 
            // btnpatientQuit
            // 
            this.btnpatientQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnpatientQuit.FlatAppearance.BorderSize = 0;
            this.btnpatientQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnpatientQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnpatientQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpatientQuit.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnpatientQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnpatientQuit.Image")));
            this.btnpatientQuit.Location = new System.Drawing.Point(342, 297);
            this.btnpatientQuit.Name = "btnpatientQuit";
            this.btnpatientQuit.Size = new System.Drawing.Size(264, 74);
            this.btnpatientQuit.TabIndex = 9;
            this.btnpatientQuit.Text = "Zakończ";
            this.btnpatientQuit.UseVisualStyleBackColor = false;
            this.btnpatientQuit.Click += new System.EventHandler(this.btnpatientQuit_Click);
            // 
            // btnsaveDelete
            // 
            this.btnsaveDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnsaveDelete.FlatAppearance.BorderSize = 0;
            this.btnsaveDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnsaveDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsaveDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaveDelete.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnsaveDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnsaveDelete.Image")));
            this.btnsaveDelete.Location = new System.Drawing.Point(50, 304);
            this.btnsaveDelete.Name = "btnsaveDelete";
            this.btnsaveDelete.Size = new System.Drawing.Size(222, 61);
            this.btnsaveDelete.TabIndex = 10;
            this.btnsaveDelete.Text = "Odwołaj wizytę";
            this.btnsaveDelete.UseVisualStyleBackColor = false;
            this.btnsaveDelete.Click += new System.EventHandler(this.btnsaveDelete_Click);
            this.AcceptButton = btnsaveDelete;
            // 
            // cbdoctor_possibles
            // 
            this.cbdoctor_possibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdoctor_possibles.FormattingEnabled = true;
            this.cbdoctor_possibles.Location = new System.Drawing.Point(223, 178);
            this.cbdoctor_possibles.Name = "cbdoctor_possibles";
            this.cbdoctor_possibles.Size = new System.Drawing.Size(344, 21);
            this.cbdoctor_possibles.TabIndex = 11;
            this.cbdoctor_possibles.SelectedIndexChanged += new System.EventHandler(this.doctor_possibles_SelectedIndexChanged);
            // 
            // ldoctor
            // 
            this.ldoctor.AutoSize = true;
            this.ldoctor.BackColor = System.Drawing.Color.Transparent;
            this.ldoctor.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ldoctor.Location = new System.Drawing.Point(63, 178);
            this.ldoctor.Name = "ldoctor";
            this.ldoctor.Size = new System.Drawing.Size(66, 23);
            this.ldoctor.TabIndex = 12;
            this.ldoctor.Text = "Lekarz";
            // 
            // lvisitDate
            // 
            this.lvisitDate.AutoSize = true;
            this.lvisitDate.BackColor = System.Drawing.Color.Transparent;
            this.lvisitDate.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvisitDate.Location = new System.Drawing.Point(63, 250);
            this.lvisitDate.Name = "lvisitDate";
            this.lvisitDate.Size = new System.Drawing.Size(109, 23);
            this.lvisitDate.TabIndex = 13;
            this.lvisitDate.Text = "Data wizyty";
            // 
            // lspecialization
            // 
            this.lspecialization.AutoSize = true;
            this.lspecialization.BackColor = System.Drawing.Color.Transparent;
            this.lspecialization.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lspecialization.Location = new System.Drawing.Point(63, 110);
            this.lspecialization.Name = "lspecialization";
            this.lspecialization.Size = new System.Drawing.Size(120, 23);
            this.lspecialization.TabIndex = 14;
            this.lspecialization.Text = "Specjalizacja";
            // 
            // cbspecialisation_possibles
            // 
            this.cbspecialisation_possibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbspecialisation_possibles.FormattingEnabled = true;
            this.cbspecialisation_possibles.Location = new System.Drawing.Point(223, 110);
            this.cbspecialisation_possibles.Name = "cbspecialisation_possibles";
            this.cbspecialisation_possibles.Size = new System.Drawing.Size(344, 21);
            this.cbspecialisation_possibles.TabIndex = 15;
            this.cbspecialisation_possibles.SelectedIndexChanged += new System.EventHandler(this.specialisation_possibles_SelectedIndexChanged);
            // 
            // DeleteEgzaminationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.cbspecialisation_possibles);
            this.Controls.Add(this.lspecialization);
            this.Controls.Add(this.lvisitDate);
            this.Controls.Add(this.ldoctor);
            this.Controls.Add(this.cbdoctor_possibles);
            this.Controls.Add(this.btnsaveDelete);
            this.Controls.Add(this.btnpatientQuit);
            this.Controls.Add(this.ldelete);
            this.Controls.Add(this.cbdate_possibles);
            this.Name = "DeleteEgzaminationForm";
            this.Text = "Usuń wizyte";
            this.Load += new System.EventHandler(this.DeleteEgzaminationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbdate_possibles;
        private System.Windows.Forms.Label ldelete;
        private System.Windows.Forms.Button btnpatientQuit;
        private System.Windows.Forms.Button btnsaveDelete;
        private System.Windows.Forms.ComboBox cbdoctor_possibles;
        private System.Windows.Forms.Label ldoctor;
        private System.Windows.Forms.Label lvisitDate;
        private System.Windows.Forms.Label lspecialization;
        private System.Windows.Forms.ComboBox cbspecialisation_possibles;
    }
}