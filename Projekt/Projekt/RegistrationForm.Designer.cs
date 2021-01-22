namespace Projekt
{
    partial class RegistrationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clickLogIn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createRegistration = new System.Windows.Forms.Button();
            this.passRegistration = new System.Windows.Forms.TextBox();
            this.emailRegistration = new System.Windows.Forms.TextBox();
            this.surnameRegistration = new System.Windows.Forms.TextBox();
            this.nameRegistration = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(133)))), ((int)(((byte)(116)))));
            this.panel1.Controls.Add(this.registrationLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 94);
            this.panel1.TabIndex = 0;
            // 
            // registrationLabel
            // 
            this.registrationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registrationLabel.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationLabel.Location = new System.Drawing.Point(0, 0);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(541, 94);
            this.registrationLabel.TabIndex = 0;
            this.registrationLabel.Text = "Rejestracja";
            this.registrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(198)))));
            this.panel2.Controls.Add(this.clickLogIn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.createRegistration);
            this.panel2.Controls.Add(this.passRegistration);
            this.panel2.Controls.Add(this.emailRegistration);
            this.panel2.Controls.Add(this.surnameRegistration);
            this.panel2.Controls.Add(this.nameRegistration);
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 412);
            this.panel2.TabIndex = 1;
            // 
            // clickLogIn
            // 
            this.clickLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clickLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clickLogIn.Location = new System.Drawing.Point(174, 337);
            this.clickLogIn.Name = "clickLogIn";
            this.clickLogIn.Size = new System.Drawing.Size(194, 31);
            this.clickLogIn.TabIndex = 3;
            this.clickLogIn.Text = "Zaloguj się";
            this.clickLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clickLogIn.Click += new System.EventHandler(this.clickLogIn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hasło:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imie:";
            // 
            // createRegistration
            // 
            this.createRegistration.Location = new System.Drawing.Point(174, 278);
            this.createRegistration.Name = "createRegistration";
            this.createRegistration.Size = new System.Drawing.Size(194, 40);
            this.createRegistration.TabIndex = 1;
            this.createRegistration.Text = "Zarejestruj się";
            this.createRegistration.UseVisualStyleBackColor = true;
            this.createRegistration.Click += new System.EventHandler(this.createRegistration_Click);
            // 
            // passRegistration
            // 
            this.passRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passRegistration.Location = new System.Drawing.Point(284, 196);
            this.passRegistration.Multiline = true;
            this.passRegistration.Name = "passRegistration";
            this.passRegistration.PasswordChar = '*';
            this.passRegistration.Size = new System.Drawing.Size(224, 38);
            this.passRegistration.TabIndex = 0;
            // 
            // emailRegistration
            // 
            this.emailRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailRegistration.Location = new System.Drawing.Point(31, 196);
            this.emailRegistration.Name = "emailRegistration";
            this.emailRegistration.Size = new System.Drawing.Size(224, 38);
            this.emailRegistration.TabIndex = 0;
            // 
            // surnameRegistration
            // 
            this.surnameRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameRegistration.Location = new System.Drawing.Point(284, 112);
            this.surnameRegistration.Name = "surnameRegistration";
            this.surnameRegistration.Size = new System.Drawing.Size(224, 38);
            this.surnameRegistration.TabIndex = 0;
            // 
            // nameRegistration
            // 
            this.nameRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameRegistration.Location = new System.Drawing.Point(31, 112);
            this.nameRegistration.Name = "nameRegistration";
            this.nameRegistration.Size = new System.Drawing.Size(222, 38);
            this.nameRegistration.TabIndex = 0;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(559, 547);
            this.MinimumSize = new System.Drawing.Size(559, 547);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magazyn Budowalny";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createRegistration;
        private System.Windows.Forms.TextBox passRegistration;
        private System.Windows.Forms.TextBox emailRegistration;
        private System.Windows.Forms.TextBox surnameRegistration;
        private System.Windows.Forms.TextBox nameRegistration;
        private System.Windows.Forms.Label clickLogIn;
    }
}