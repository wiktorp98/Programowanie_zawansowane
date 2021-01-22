namespace Projekt
{
    partial class ListOfWorkersForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ListOfClients = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MainLabel = new System.Windows.Forms.Label();
            this.ShowWorkers = new System.Windows.Forms.ListView();
            this.NameField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SurnameField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GanarateListOfClients = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(133)))), ((int)(((byte)(116)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 109);
            this.panel2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(36, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 52);
            this.label4.TabIndex = 2;
            this.label4.Text = "Witamy!";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.logOutButton);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(769, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 37);
            this.panel1.TabIndex = 1;
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
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.ListOfClients);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel3.Location = new System.Drawing.Point(611, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(134, 37);
            this.panel3.TabIndex = 1;
            // 
            // ListOfClients
            // 
            this.ListOfClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListOfClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListOfClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListOfClients.Location = new System.Drawing.Point(0, 0);
            this.ListOfClients.Name = "ListOfClients";
            this.ListOfClients.Size = new System.Drawing.Size(134, 37);
            this.ListOfClients.TabIndex = 0;
            this.ListOfClients.Text = "Lista Klientów";
            this.ListOfClients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ListOfClients.Click += new System.EventHandler(this.ListOfClients_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel4.Controls.Add(this.MainLabel);
            this.panel4.Location = new System.Drawing.Point(458, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(132, 37);
            this.panel4.TabIndex = 1;
            // 
            // MainLabel
            // 
            this.MainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MainLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel.Location = new System.Drawing.Point(0, 0);
            this.MainLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(132, 37);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "Strona Główna";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainLabel.Click += new System.EventHandler(this.MainLabel_Click);
            // 
            // ShowWorkers
            // 
            this.ShowWorkers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameField,
            this.SurnameField,
            this.EmailField});
            this.ShowWorkers.FullRowSelect = true;
            this.ShowWorkers.GridLines = true;
            this.ShowWorkers.HideSelection = false;
            this.ShowWorkers.Location = new System.Drawing.Point(300, 127);
            this.ShowWorkers.Name = "ShowWorkers";
            this.ShowWorkers.Size = new System.Drawing.Size(685, 419);
            this.ShowWorkers.TabIndex = 11;
            this.ShowWorkers.UseCompatibleStateImageBehavior = false;
            this.ShowWorkers.View = System.Windows.Forms.View.Details;
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
            // GanarateListOfClients
            // 
            this.GanarateListOfClients.Location = new System.Drawing.Point(27, 513);
            this.GanarateListOfClients.Name = "GanarateListOfClients";
            this.GanarateListOfClients.Size = new System.Drawing.Size(75, 23);
            this.GanarateListOfClients.TabIndex = 10;
            this.GanarateListOfClients.Text = "Wyświetl";
            this.GanarateListOfClients.UseVisualStyleBackColor = true;
            this.GanarateListOfClients.Click += new System.EventHandler(this.GanarateListOfClients_Click);
            // 
            // ListOfWorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(997, 595);
            this.Controls.Add(this.ShowWorkers);
            this.Controls.Add(this.GanarateListOfClients);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(1100, 900);
            this.MinimumSize = new System.Drawing.Size(997, 595);
            this.Name = "ListOfWorkersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magazyn Budowalny";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label logOutButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ListOfClients;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.ListView ShowWorkers;
        private System.Windows.Forms.ColumnHeader NameField;
        private System.Windows.Forms.ColumnHeader SurnameField;
        private System.Windows.Forms.ColumnHeader EmailField;
        private System.Windows.Forms.Button GanarateListOfClients;
    }
}