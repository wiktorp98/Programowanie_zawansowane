namespace Projekt
{
    partial class ListOfClientsForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.logOutLableClick = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Label();
            this.basketLableClick = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.mainLableClick = new System.Windows.Forms.Label();
            this.GanarateListOfClients = new System.Windows.Forms.Button();
            this.ShowClients = new System.Windows.Forms.ListView();
            this.NameField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SurnameField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2.SuspendLayout();
            this.logOutLableClick.SuspendLayout();
            this.basketLableClick.SuspendLayout();
            this.panel19.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(133)))), ((int)(((byte)(116)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.logOutLableClick);
            this.panel2.Controls.Add(this.basketLableClick);
            this.panel2.Controls.Add(this.panel19);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 105);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Witamy!";
            // 
            // logOutLableClick
            // 
            this.logOutLableClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutLableClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.logOutLableClick.Controls.Add(this.logOutButton);
            this.logOutLableClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logOutLableClick.Location = new System.Drawing.Point(769, 34);
            this.logOutLableClick.Name = "logOutLableClick";
            this.logOutLableClick.Size = new System.Drawing.Size(134, 37);
            this.logOutLableClick.TabIndex = 1;
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logOutButton.Location = new System.Drawing.Point(0, 0);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(134, 37);
            this.logOutButton.TabIndex = 0;
            this.logOutButton.Text = "Wyłoguj się";
            this.logOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // basketLableClick
            // 
            this.basketLableClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.basketLableClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.basketLableClick.Controls.Add(this.label2);
            this.basketLableClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.basketLableClick.Location = new System.Drawing.Point(611, 34);
            this.basketLableClick.Name = "basketLableClick";
            this.basketLableClick.Size = new System.Drawing.Size(134, 37);
            this.basketLableClick.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lista Klientów";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel19
            // 
            this.panel19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel19.Controls.Add(this.mainLableClick);
            this.panel19.Location = new System.Drawing.Point(458, 34);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(132, 37);
            this.panel19.TabIndex = 1;
            // 
            // mainLableClick
            // 
            this.mainLableClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mainLableClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainLableClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLableClick.Location = new System.Drawing.Point(0, 0);
            this.mainLableClick.Margin = new System.Windows.Forms.Padding(0);
            this.mainLableClick.Name = "mainLableClick";
            this.mainLableClick.Size = new System.Drawing.Size(132, 37);
            this.mainLableClick.TabIndex = 0;
            this.mainLableClick.Text = "Strona Główna";
            this.mainLableClick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainLableClick.Click += new System.EventHandler(this.mainLableClick_Click);
            // 
            // GanarateListOfClients
            // 
            this.GanarateListOfClients.Location = new System.Drawing.Point(45, 513);
            this.GanarateListOfClients.Name = "GanarateListOfClients";
            this.GanarateListOfClients.Size = new System.Drawing.Size(75, 23);
            this.GanarateListOfClients.TabIndex = 4;
            this.GanarateListOfClients.Text = "Wyświetl";
            this.GanarateListOfClients.UseVisualStyleBackColor = true;
            this.GanarateListOfClients.Click += new System.EventHandler(this.GanarateListOfClients_Click);
            // 
            // ShowClients
            // 
            this.ShowClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameField,
            this.SurnameField,
            this.EmailField});
            this.ShowClients.FullRowSelect = true;
            this.ShowClients.GridLines = true;
            this.ShowClients.HideSelection = false;
            this.ShowClients.Location = new System.Drawing.Point(300, 117);
            this.ShowClients.Name = "ShowClients";
            this.ShowClients.Size = new System.Drawing.Size(685, 419);
            this.ShowClients.TabIndex = 6;
            this.ShowClients.UseCompatibleStateImageBehavior = false;
            this.ShowClients.View = System.Windows.Forms.View.Details;
            // 
            // NameField
            // 
            this.NameField.Text = "Imię";
            this.NameField.Width = 167;
            // 
            // SurnameField
            // 
            this.SurnameField.Text = "Nazwisko";
            this.SurnameField.Width = 169;
            // 
            // EmailField
            // 
            this.EmailField.Text = "Email";
            this.EmailField.Width = 342;
            // 
            // ListOfClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(997, 595);
            this.Controls.Add(this.ShowClients);
            this.Controls.Add(this.GanarateListOfClients);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(1100, 900);
            this.MinimumSize = new System.Drawing.Size(997, 595);
            this.Name = "ListOfClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magazyn Budowalny";
            this.panel2.ResumeLayout(false);
            this.logOutLableClick.ResumeLayout(false);
            this.basketLableClick.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel logOutLableClick;
        private System.Windows.Forms.Label logOutButton;
        private System.Windows.Forms.Panel basketLableClick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label mainLableClick;
        private System.Windows.Forms.Button GanarateListOfClients;
        private System.Windows.Forms.ListView ShowClients;
        private System.Windows.Forms.ColumnHeader NameField;
        private System.Windows.Forms.ColumnHeader SurnameField;
        private System.Windows.Forms.ColumnHeader EmailField;
    }
}