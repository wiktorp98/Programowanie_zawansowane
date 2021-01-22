namespace Projekt
{
    partial class InviteWorkerForm
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
            this.emailField = new System.Windows.Forms.TextBox();
            this.loginTopPanel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inviteButton = new System.Windows.Forms.Button();
            this.mainLableClick = new System.Windows.Forms.Label();
            this.loginTopPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailField
            // 
            this.emailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailField.Location = new System.Drawing.Point(148, 246);
            this.emailField.Multiline = true;
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(238, 37);
            this.emailField.TabIndex = 0;
            // 
            // loginTopPanel1
            // 
            this.loginTopPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTopPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(133)))), ((int)(((byte)(116)))));
            this.loginTopPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginTopPanel1.Controls.Add(this.label2);
            this.loginTopPanel1.Location = new System.Drawing.Point(0, 0);
            this.loginTopPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.loginTopPanel1.Name = "loginTopPanel1";
            this.loginTopPanel1.Size = new System.Drawing.Size(547, 115);
            this.loginTopPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(547, 115);
            this.label2.TabIndex = 0;
            this.label2.Text = "Zatrudnienie";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email:";
            // 
            // inviteButton
            // 
            this.inviteButton.Location = new System.Drawing.Point(148, 346);
            this.inviteButton.Name = "inviteButton";
            this.inviteButton.Size = new System.Drawing.Size(238, 47);
            this.inviteButton.TabIndex = 3;
            this.inviteButton.Text = "Zatrudnić";
            this.inviteButton.UseVisualStyleBackColor = true;
            this.inviteButton.Click += new System.EventHandler(this.inviteButton_Click);
            // 
            // mainLableClick
            // 
            this.mainLableClick.AutoSize = true;
            this.mainLableClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainLableClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLableClick.Location = new System.Drawing.Point(204, 449);
            this.mainLableClick.Name = "mainLableClick";
            this.mainLableClick.Size = new System.Drawing.Size(115, 20);
            this.mainLableClick.TabIndex = 4;
            this.mainLableClick.Text = "Strona główna";
            this.mainLableClick.Click += new System.EventHandler(this.mainLableClick_Click);
            // 
            // InviteWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(545, 523);
            this.Controls.Add(this.mainLableClick);
            this.Controls.Add(this.inviteButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginTopPanel1);
            this.Controls.Add(this.emailField);
            this.MaximumSize = new System.Drawing.Size(563, 570);
            this.MinimumSize = new System.Drawing.Size(563, 570);
            this.Name = "InviteWorkerForm";
            this.Text = "Magazyn Budowalny";
            this.loginTopPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.Panel loginTopPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button inviteButton;
        private System.Windows.Forms.Label mainLableClick;
    }
}