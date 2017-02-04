namespace ProjektOI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btngoToDaily = new System.Windows.Forms.Button();
            this.llogin = new System.Windows.Forms.Label();
            this.lpassword = new System.Windows.Forms.Label();
            this.tbreceptionist_password = new System.Windows.Forms.TextBox();
            this.cblogin_possibles = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btngoToDaily
            // 
            this.btngoToDaily.BackColor = System.Drawing.Color.Transparent;
            this.btngoToDaily.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btngoToDaily.FlatAppearance.BorderSize = 0;
            this.btngoToDaily.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btngoToDaily.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btngoToDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngoToDaily.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btngoToDaily.ForeColor = System.Drawing.Color.Black;
            this.btngoToDaily.Image = ((System.Drawing.Image)(resources.GetObject("btngoToDaily.Image")));
            this.btngoToDaily.Location = new System.Drawing.Point(87, 221);
            this.btngoToDaily.Name = "btngoToDaily";
            this.btngoToDaily.Size = new System.Drawing.Size(212, 82);
            this.btngoToDaily.TabIndex = 0;
            this.btngoToDaily.Text = "Zaloguj ";
            this.btngoToDaily.UseVisualStyleBackColor = false;
            this.btngoToDaily.Click += new System.EventHandler(this.btngoToDaily_Click);
            this.AcceptButton = btngoToDaily;
            // 
            // llogin
            // 
            this.llogin.BackColor = System.Drawing.Color.Transparent;
            this.llogin.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.llogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.llogin.Location = new System.Drawing.Point(18, 118);
            this.llogin.Name = "llogin";
            this.llogin.Size = new System.Drawing.Size(62, 31);
            this.llogin.TabIndex = 2;
            this.llogin.Text = "Login";
            // 
            // lpassword
            // 
            this.lpassword.AutoSize = true;
            this.lpassword.BackColor = System.Drawing.Color.Transparent;
            this.lpassword.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lpassword.Location = new System.Drawing.Point(18, 185);
            this.lpassword.Name = "lpassword";
            this.lpassword.Size = new System.Drawing.Size(58, 23);
            this.lpassword.TabIndex = 3;
            this.lpassword.Text = "Hasło";
            // 
            // tbreceptionist_password
            // 
            this.tbreceptionist_password.Location = new System.Drawing.Point(107, 185);
            this.tbreceptionist_password.Name = "tbreceptionist_password";
            this.tbreceptionist_password.Size = new System.Drawing.Size(192, 20);
            this.tbreceptionist_password.TabIndex = 4;
            // 
            // cblogin_possibles
            // 
            this.cblogin_possibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblogin_possibles.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cblogin_possibles.FormattingEnabled = true;
            this.cblogin_possibles.Location = new System.Drawing.Point(107, 118);
            this.cblogin_possibles.Name = "cblogin_possibles";
            this.cblogin_possibles.Size = new System.Drawing.Size(192, 23);
            this.cblogin_possibles.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(338, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 258);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labelWelcome
            // 
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Georgia", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWelcome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelWelcome.Location = new System.Drawing.Point(12, 19);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(634, 67);
            this.labelWelcome.TabIndex = 9;
            this.labelWelcome.Text = "Witamy w ESCULCARE";
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.Transparent;
            this.btnEnd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEnd.FlatAppearance.BorderSize = 0;
            this.btnEnd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEnd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEnd.ForeColor = System.Drawing.Color.Black;
            this.btnEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnEnd.Image")));
            this.btnEnd.Location = new System.Drawing.Point(87, 309);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(212, 70);
            this.btnEnd.TabIndex = 10;
            this.btnEnd.Text = "Zakończ";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cblogin_possibles);
            this.Controls.Add(this.tbreceptionist_password);
            this.Controls.Add(this.lpassword);
            this.Controls.Add(this.llogin);
            this.Controls.Add(this.btngoToDaily);
            this.Name = "LoginForm";
            this.Text = "Logowanie";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label llogin;
        private System.Windows.Forms.Label lpassword;
        private System.Windows.Forms.TextBox tbreceptionist_password;
        private System.Windows.Forms.ComboBox cblogin_possibles;
        private System.Windows.Forms.Button btngoToDaily;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button btnEnd;
    }
}

