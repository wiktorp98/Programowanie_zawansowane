namespace Projekt
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.clickRegistration = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.picturePassLogin = new System.Windows.Forms.PictureBox();
            this.pictureUserLogin = new System.Windows.Forms.PictureBox();
            this.passFieldLogin = new System.Windows.Forms.TextBox();
            this.loginFieldLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginTopPanel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePassLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUserLogin)).BeginInit();
            this.loginTopPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(198)))));
            this.panel1.Controls.Add(this.clickRegistration);
            this.panel1.Controls.Add(this.logInButton);
            this.panel1.Controls.Add(this.picturePassLogin);
            this.panel1.Controls.Add(this.pictureUserLogin);
            this.panel1.Controls.Add(this.passFieldLogin);
            this.panel1.Controls.Add(this.loginFieldLogin);
            this.panel1.Location = new System.Drawing.Point(0, 111);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 402);
            this.panel1.TabIndex = 1;
            // 
            // clickRegistration
            // 
            this.clickRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clickRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clickRegistration.Location = new System.Drawing.Point(140, 332);
            this.clickRegistration.Name = "clickRegistration";
            this.clickRegistration.Size = new System.Drawing.Size(162, 23);
            this.clickRegistration.TabIndex = 4;
            this.clickRegistration.Text = "Zarejestruj się";
            this.clickRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clickRegistration.Click += new System.EventHandler(this.clickRegistration_Click);
            // 
            // logInButton
            // 
            this.logInButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logInButton.Location = new System.Drawing.Point(139, 259);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(152, 39);
            this.logInButton.TabIndex = 3;
            this.logInButton.Text = "zaloguj się";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // picturePassLogin
            // 
            this.picturePassLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picturePassLogin.Image = global::Projekt.Properties.Resources.icon_password;
            this.picturePassLogin.InitialImage = global::Projekt.Properties.Resources.icon_user;
            this.picturePassLogin.Location = new System.Drawing.Point(48, 188);
            this.picturePassLogin.Name = "picturePassLogin";
            this.picturePassLogin.Size = new System.Drawing.Size(51, 38);
            this.picturePassLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePassLogin.TabIndex = 2;
            this.picturePassLogin.TabStop = false;
            // 
            // pictureUserLogin
            // 
            this.pictureUserLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureUserLogin.Image = global::Projekt.Properties.Resources.icon_user;
            this.pictureUserLogin.Location = new System.Drawing.Point(48, 103);
            this.pictureUserLogin.Name = "pictureUserLogin";
            this.pictureUserLogin.Size = new System.Drawing.Size(46, 38);
            this.pictureUserLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUserLogin.TabIndex = 1;
            this.pictureUserLogin.TabStop = false;
            // 
            // passFieldLogin
            // 
            this.passFieldLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passFieldLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passFieldLogin.Location = new System.Drawing.Point(105, 188);
            this.passFieldLogin.Multiline = true;
            this.passFieldLogin.Name = "passFieldLogin";
            this.passFieldLogin.PasswordChar = '*';
            this.passFieldLogin.Size = new System.Drawing.Size(259, 38);
            this.passFieldLogin.TabIndex = 0;
            // 
            // loginFieldLogin
            // 
            this.loginFieldLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginFieldLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginFieldLogin.Location = new System.Drawing.Point(105, 103);
            this.loginFieldLogin.Multiline = true;
            this.loginFieldLogin.Name = "loginFieldLogin";
            this.loginFieldLogin.Size = new System.Drawing.Size(259, 38);
            this.loginFieldLogin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(419, 111);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logowanie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginTopPanel1
            // 
            this.loginTopPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTopPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(133)))), ((int)(((byte)(116)))));
            this.loginTopPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginTopPanel1.Controls.Add(this.label1);
            this.loginTopPanel1.Location = new System.Drawing.Point(0, 0);
            this.loginTopPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.loginTopPanel1.Name = "loginTopPanel1";
            this.loginTopPanel1.Size = new System.Drawing.Size(422, 111);
            this.loginTopPanel1.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(421, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginTopPanel1);
            this.MaximumSize = new System.Drawing.Size(668, 663);
            this.MinimumSize = new System.Drawing.Size(421, 511);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magazyn Budowalny";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePassLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUserLogin)).EndInit();
            this.loginTopPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox loginFieldLogin;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.PictureBox picturePassLogin;
        private System.Windows.Forms.PictureBox pictureUserLogin;
        private System.Windows.Forms.TextBox passFieldLogin;
        private System.Windows.Forms.Panel loginTopPanel1;
        private System.Windows.Forms.Label clickRegistration;
    }
}

