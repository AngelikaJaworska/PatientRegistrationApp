namespace ProjektOI
{
    partial class EgzaminationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EgzaminationForm));
            this.cbspecialisation_possibles = new System.Windows.Forms.ComboBox();
            this.lspecialization = new System.Windows.Forms.Label();
            this.lregister = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.lchooseDoctor = new System.Windows.Forms.Label();
            this.cbdoctors_possibles = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbspecialisation_possibles
            // 
            this.cbspecialisation_possibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbspecialisation_possibles.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbspecialisation_possibles.FormattingEnabled = true;
            this.cbspecialisation_possibles.Location = new System.Drawing.Point(220, 102);
            this.cbspecialisation_possibles.Name = "cbspecialisation_possibles";
            this.cbspecialisation_possibles.Size = new System.Drawing.Size(291, 23);
            this.cbspecialisation_possibles.TabIndex = 8;
            this.cbspecialisation_possibles.SelectedIndexChanged += new System.EventHandler(this.specialisation_possibles_SelectedIndexChanged);
            // 
            // lspecialization
            // 
            this.lspecialization.BackColor = System.Drawing.Color.Transparent;
            this.lspecialization.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lspecialization.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lspecialization.Location = new System.Drawing.Point(12, 97);
            this.lspecialization.Name = "lspecialization";
            this.lspecialization.Size = new System.Drawing.Size(210, 29);
            this.lspecialization.TabIndex = 9;
            this.lspecialization.Text = "Wybierz specjalność lekarza";
            // 
            // lregister
            // 
            this.lregister.BackColor = System.Drawing.Color.Transparent;
            this.lregister.Enabled = false;
            this.lregister.Font = new System.Drawing.Font("Georgia", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lregister.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lregister.Location = new System.Drawing.Point(108, 28);
            this.lregister.Name = "lregister";
            this.lregister.Size = new System.Drawing.Size(419, 40);
            this.lregister.TabIndex = 10;
            this.lregister.Text = "Rejestracja na badanie";
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
            this.btnsearch.Location = new System.Drawing.Point(28, 209);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(309, 70);
            this.btnsearch.TabIndex = 13;
            this.btnsearch.Text = "Wyszukaj";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // lchooseDoctor
            // 
            this.lchooseDoctor.BackColor = System.Drawing.Color.Transparent;
            this.lchooseDoctor.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lchooseDoctor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lchooseDoctor.Location = new System.Drawing.Point(12, 157);
            this.lchooseDoctor.Name = "lchooseDoctor";
            this.lchooseDoctor.Size = new System.Drawing.Size(148, 29);
            this.lchooseDoctor.TabIndex = 14;
            this.lchooseDoctor.Text = "Wybierz lekarza";
            // 
            // cbdoctors_possibles
            // 
            this.cbdoctors_possibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdoctors_possibles.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbdoctors_possibles.FormattingEnabled = true;
            this.cbdoctors_possibles.Location = new System.Drawing.Point(220, 153);
            this.cbdoctors_possibles.Name = "cbdoctors_possibles";
            this.cbdoctors_possibles.Size = new System.Drawing.Size(282, 23);
            this.cbdoctors_possibles.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(372, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 231);
            this.pictureBox1.TabIndex = 16;
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
            this.btnCancel.Location = new System.Drawing.Point(28, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(309, 70);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Wróć";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EgzaminationForm
            // 
            this.AcceptButton = this.btnsearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbdoctors_possibles);
            this.Controls.Add(this.lchooseDoctor);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.lregister);
            this.Controls.Add(this.lspecialization);
            this.Controls.Add(this.cbspecialisation_possibles);
            this.Name = "EgzaminationForm";
            this.Text = "Rejestracja na badanie";
            this.Load += new System.EventHandler(this.EgzaminationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbspecialisation_possibles;
        private System.Windows.Forms.Label lspecialization;
        private System.Windows.Forms.Label lregister;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label lchooseDoctor;
        private System.Windows.Forms.ComboBox cbdoctors_possibles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancel;
    }
}