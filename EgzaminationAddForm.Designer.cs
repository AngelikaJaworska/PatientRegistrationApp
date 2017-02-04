namespace ProjektOI
{
    partial class EgzaminationAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EgzaminationAddForm));
            this.lregister = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnReturnToExaminationForm = new System.Windows.Forms.Button();
            this.ldate = new System.Windows.Forms.Label();
            this.lbnewvisit = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lregister
            // 
            this.lregister.BackColor = System.Drawing.Color.Transparent;
            this.lregister.Enabled = false;
            this.lregister.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lregister.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lregister.Location = new System.Drawing.Point(143, 33);
            this.lregister.Name = "lregister";
            this.lregister.Size = new System.Drawing.Size(500, 40);
            this.lregister.TabIndex = 11;
            this.lregister.Text = "Rejestracja na badanie";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Transparent;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.Location = new System.Drawing.Point(47, 301);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(270, 74);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "Zapisz na badanie";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnReturnToExaminationForm
            // 
            this.btnReturnToExaminationForm.BackColor = System.Drawing.Color.Transparent;
            this.btnReturnToExaminationForm.FlatAppearance.BorderSize = 0;
            this.btnReturnToExaminationForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReturnToExaminationForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReturnToExaminationForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnToExaminationForm.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReturnToExaminationForm.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnToExaminationForm.Image")));
            this.btnReturnToExaminationForm.Location = new System.Drawing.Point(344, 301);
            this.btnReturnToExaminationForm.Name = "btnReturnToExaminationForm";
            this.btnReturnToExaminationForm.Size = new System.Drawing.Size(235, 74);
            this.btnReturnToExaminationForm.TabIndex = 15;
            this.btnReturnToExaminationForm.Text = "Powrót do wyboru specjalisty";
            this.btnReturnToExaminationForm.UseVisualStyleBackColor = false;
            this.btnReturnToExaminationForm.Click += new System.EventHandler(this.btnReturnToExaminationForm_Click);
            // 
            // ldate
            // 
            this.ldate.BackColor = System.Drawing.Color.Transparent;
            this.ldate.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ldate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ldate.Location = new System.Drawing.Point(28, 91);
            this.ldate.Name = "ldate";
            this.ldate.Size = new System.Drawing.Size(511, 34);
            this.ldate.TabIndex = 16;
            this.ldate.Text = "Możliwe do wyboru terminy w danym miesiącu:";
            // 
            // lbnewvisit
            // 
            this.lbnewvisit.FormattingEnabled = true;
            this.lbnewvisit.Location = new System.Drawing.Point(32, 128);
            this.lbnewvisit.Name = "lbnewvisit";
            this.lbnewvisit.Size = new System.Drawing.Size(589, 147);
            this.lbnewvisit.TabIndex = 17;
            // 
            // EgzaminationAddForm
            // 
            this.AcceptButton = this.btnsave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.lbnewvisit);
            this.Controls.Add(this.ldate);
            this.Controls.Add(this.btnReturnToExaminationForm);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lregister);
            this.Name = "EgzaminationAddForm";
            this.Text = "Rejestracja na badanie";
            this.Load += new System.EventHandler(this.AddEgzamination_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lregister;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnReturnToExaminationForm;
        private System.Windows.Forms.Label ldate;
        private System.Windows.Forms.ListBox lbnewvisit;
    }
}