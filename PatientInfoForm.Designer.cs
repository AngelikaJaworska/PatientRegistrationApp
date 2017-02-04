namespace ProjektOI
{
    partial class PatientInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientInfoForm));
            this.lpatientData = new System.Windows.Forms.Label();
            this.loption = new System.Windows.Forms.Label();
            this.btnpatientAddEgzamination = new System.Windows.Forms.Button();
            this.btnpatientDelete = new System.Windows.Forms.Button();
            this.btnpatientEdit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.laddress = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.addres = new System.Windows.Forms.Label();
            this.lLastname = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.lsurname = new System.Windows.Forms.Label();
            this.btnpatientQuit = new System.Windows.Forms.Button();
            this.btnEditEgzamination = new System.Windows.Forms.Button();
            this.btnDelateEgamination = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lpatientData
            // 
            this.lpatientData.AutoSize = true;
            this.lpatientData.BackColor = System.Drawing.Color.Transparent;
            this.lpatientData.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lpatientData.Location = new System.Drawing.Point(27, 29);
            this.lpatientData.Name = "lpatientData";
            this.lpatientData.Size = new System.Drawing.Size(157, 23);
            this.lpatientData.TabIndex = 0;
            this.lpatientData.Text = "Dane pacjenta:";
            // 
            // loption
            // 
            this.loption.AutoSize = true;
            this.loption.BackColor = System.Drawing.Color.Transparent;
            this.loption.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loption.Location = new System.Drawing.Point(27, 157);
            this.loption.Name = "loption";
            this.loption.Size = new System.Drawing.Size(74, 23);
            this.loption.TabIndex = 1;
            this.loption.Text = "Opcje:";
            // 
            // btnpatientAddEgzamination
            // 
            this.btnpatientAddEgzamination.BackColor = System.Drawing.Color.Transparent;
            this.btnpatientAddEgzamination.FlatAppearance.BorderSize = 0;
            this.btnpatientAddEgzamination.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnpatientAddEgzamination.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnpatientAddEgzamination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpatientAddEgzamination.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnpatientAddEgzamination.Image = ((System.Drawing.Image)(resources.GetObject("btnpatientAddEgzamination.Image")));
            this.btnpatientAddEgzamination.Location = new System.Drawing.Point(42, 256);
            this.btnpatientAddEgzamination.Name = "btnpatientAddEgzamination";
            this.btnpatientAddEgzamination.Size = new System.Drawing.Size(262, 63);
            this.btnpatientAddEgzamination.TabIndex = 2;
            this.btnpatientAddEgzamination.Text = "Zapisz na wizytę";
            this.btnpatientAddEgzamination.UseVisualStyleBackColor = false;
            this.btnpatientAddEgzamination.Click += new System.EventHandler(this.btnpatientAddEgzamination_Click);
            // 
            // btnpatientDelete
            // 
            this.btnpatientDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnpatientDelete.FlatAppearance.BorderSize = 0;
            this.btnpatientDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnpatientDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnpatientDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpatientDelete.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnpatientDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnpatientDelete.Image")));
            this.btnpatientDelete.Location = new System.Drawing.Point(342, 187);
            this.btnpatientDelete.Name = "btnpatientDelete";
            this.btnpatientDelete.Size = new System.Drawing.Size(264, 63);
            this.btnpatientDelete.TabIndex = 5;
            this.btnpatientDelete.Text = "Usuń  pacjenta";
            this.btnpatientDelete.UseVisualStyleBackColor = false;
            this.btnpatientDelete.Click += new System.EventHandler(this.btnpatientDelete_Click);
            // 
            // btnpatientEdit
            // 
            this.btnpatientEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnpatientEdit.FlatAppearance.BorderSize = 0;
            this.btnpatientEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnpatientEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnpatientEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpatientEdit.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnpatientEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnpatientEdit.Image")));
            this.btnpatientEdit.Location = new System.Drawing.Point(44, 183);
            this.btnpatientEdit.Name = "btnpatientEdit";
            this.btnpatientEdit.Size = new System.Drawing.Size(260, 74);
            this.btnpatientEdit.TabIndex = 6;
            this.btnpatientEdit.Text = "Edytuj pacjenta";
            this.btnpatientEdit.UseVisualStyleBackColor = false;
            this.btnpatientEdit.Click += new System.EventHandler(this.btnpatientEdit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.laddress, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.addres, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lLastname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lname, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lsurname, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(31, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.84848F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.15151F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(571, 87);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // laddress
            // 
            this.laddress.AutoSize = true;
            this.laddress.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.laddress.Location = new System.Drawing.Point(384, 1);
            this.laddress.Name = "laddress";
            this.laddress.Size = new System.Drawing.Size(50, 18);
            this.laddress.TabIndex = 3;
            this.laddress.Text = "Adres";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.name.Location = new System.Drawing.Point(4, 31);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(47, 18);
            this.name.TabIndex = 4;
            this.name.Text = "name";
            // 
            // addres
            // 
            this.addres.AutoSize = true;
            this.addres.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addres.Location = new System.Drawing.Point(384, 31);
            this.addres.Name = "addres";
            this.addres.Size = new System.Drawing.Size(56, 18);
            this.addres.TabIndex = 5;
            this.addres.Text = "addres";
            // 
            // lLastname
            // 
            this.lLastname.AutoSize = true;
            this.lLastname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lLastname.Location = new System.Drawing.Point(194, 31);
            this.lLastname.Name = "lLastname";
            this.lLastname.Size = new System.Drawing.Size(75, 18);
            this.lLastname.TabIndex = 9;
            this.lLastname.Text = "lastName";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lname.Location = new System.Drawing.Point(4, 1);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(41, 18);
            this.lname.TabIndex = 0;
            this.lname.Text = "Imię";
            // 
            // lsurname
            // 
            this.lsurname.AutoSize = true;
            this.lsurname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lsurname.Location = new System.Drawing.Point(194, 1);
            this.lsurname.Name = "lsurname";
            this.lsurname.Size = new System.Drawing.Size(75, 18);
            this.lsurname.TabIndex = 1;
            this.lsurname.Text = "Nazwisko";
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
            this.btnpatientQuit.Location = new System.Drawing.Point(342, 321);
            this.btnpatientQuit.Name = "btnpatientQuit";
            this.btnpatientQuit.Size = new System.Drawing.Size(264, 74);
            this.btnpatientQuit.TabIndex = 8;
            this.btnpatientQuit.Text = "Zakończ";
            this.btnpatientQuit.UseVisualStyleBackColor = false;
            this.btnpatientQuit.Click += new System.EventHandler(this.btnpatientQuit_Click);
            // 
            // btnEditEgzamination
            // 
            this.btnEditEgzamination.BackColor = System.Drawing.Color.Transparent;
            this.btnEditEgzamination.FlatAppearance.BorderSize = 0;
            this.btnEditEgzamination.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditEgzamination.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditEgzamination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEgzamination.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditEgzamination.Image = ((System.Drawing.Image)(resources.GetObject("btnEditEgzamination.Image")));
            this.btnEditEgzamination.Location = new System.Drawing.Point(346, 256);
            this.btnEditEgzamination.Name = "btnEditEgzamination";
            this.btnEditEgzamination.Size = new System.Drawing.Size(260, 63);
            this.btnEditEgzamination.TabIndex = 9;
            this.btnEditEgzamination.Text = "Edytuj wizytę";
            this.btnEditEgzamination.UseVisualStyleBackColor = false;
            this.btnEditEgzamination.Click += new System.EventHandler(this.btnEditEgzamination_Click);
            // 
            // btnDelateEgamination
            // 
            this.btnDelateEgamination.BackColor = System.Drawing.Color.Transparent;
            this.btnDelateEgamination.FlatAppearance.BorderSize = 0;
            this.btnDelateEgamination.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDelateEgamination.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelateEgamination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelateEgamination.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelateEgamination.Image = ((System.Drawing.Image)(resources.GetObject("btnDelateEgamination.Image")));
            this.btnDelateEgamination.Location = new System.Drawing.Point(44, 332);
            this.btnDelateEgamination.Name = "btnDelateEgamination";
            this.btnDelateEgamination.Size = new System.Drawing.Size(264, 63);
            this.btnDelateEgamination.TabIndex = 10;
            this.btnDelateEgamination.Text = "Usuń  wizytę";
            this.btnDelateEgamination.UseVisualStyleBackColor = false;
            this.btnDelateEgamination.Click += new System.EventHandler(this.btnDelateEgamination_Click);
            // 
            // PatientInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.btnDelateEgamination);
            this.Controls.Add(this.btnEditEgzamination);
            this.Controls.Add(this.btnpatientQuit);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnpatientEdit);
            this.Controls.Add(this.btnpatientDelete);
            this.Controls.Add(this.btnpatientAddEgzamination);
            this.Controls.Add(this.loption);
            this.Controls.Add(this.lpatientData);
            this.Name = "PatientInfoForm";
            this.Text = "Dane pacjenta";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lpatientData;
        private System.Windows.Forms.Label loption;
        private System.Windows.Forms.Button btnpatientAddEgzamination;
        private System.Windows.Forms.Button btnpatientDelete;
        private System.Windows.Forms.Button btnpatientEdit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lsurname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label laddress;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label addres;
        private System.Windows.Forms.Button btnpatientQuit;
        private System.Windows.Forms.Label lLastname;
        private System.Windows.Forms.Button btnEditEgzamination;
        private System.Windows.Forms.Button btnDelateEgamination;
    }
}