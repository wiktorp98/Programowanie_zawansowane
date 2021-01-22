namespace Projekt
{
    partial class ShowOrdersForm
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
            this.closeLable = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ListOfClients = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.mainLableClick = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewOrders = new System.Windows.Forms.ListView();
            this.IdField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.countyField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cityField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adresField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sumField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showOrdersButton = new System.Windows.Forms.Button();
            this.realiseOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel19.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(133)))), ((int)(((byte)(116)))));
            this.panel1.Controls.Add(this.closeLable);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel19);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 107);
            this.panel1.TabIndex = 1;
            // 
            // closeLable
            // 
            this.closeLable.Location = new System.Drawing.Point(0, 0);
            this.closeLable.Name = "closeLable";
            this.closeLable.Size = new System.Drawing.Size(100, 23);
            this.closeLable.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.logOutButton);
            this.panel3.Location = new System.Drawing.Point(804, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 37);
            this.panel3.TabIndex = 9;
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logOutButton.Location = new System.Drawing.Point(0, 0);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(0);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(132, 37);
            this.logOutButton.TabIndex = 1;
            this.logOutButton.Text = "Wyloguj się";
            this.logOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.ListOfClients);
            this.panel2.Location = new System.Drawing.Point(649, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 37);
            this.panel2.TabIndex = 8;
            // 
            // ListOfClients
            // 
            this.ListOfClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListOfClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListOfClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListOfClients.Location = new System.Drawing.Point(0, 0);
            this.ListOfClients.Margin = new System.Windows.Forms.Padding(0);
            this.ListOfClients.Name = "ListOfClients";
            this.ListOfClients.Size = new System.Drawing.Size(132, 37);
            this.ListOfClients.TabIndex = 2;
            this.ListOfClients.Text = "Lista Klientów";
            this.ListOfClients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ListOfClients.Click += new System.EventHandler(this.ListOfClients_Click);
            // 
            // panel19
            // 
            this.panel19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel19.Controls.Add(this.mainLableClick);
            this.panel19.Location = new System.Drawing.Point(493, 37);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(132, 37);
            this.panel19.TabIndex = 7;
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
            this.mainLableClick.TabIndex = 2;
            this.mainLableClick.Text = "Strona Główna";
            this.mainLableClick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainLableClick.Click += new System.EventHandler(this.mainLableClick_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "Witam cię";
            // 
            // ViewOrders
            // 
            this.ViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdField,
            this.countyField,
            this.cityField,
            this.adresField,
            this.statusField,
            this.sumField});
            this.ViewOrders.FullRowSelect = true;
            this.ViewOrders.GridLines = true;
            this.ViewOrders.HideSelection = false;
            this.ViewOrders.Location = new System.Drawing.Point(267, 112);
            this.ViewOrders.Name = "ViewOrders";
            this.ViewOrders.Size = new System.Drawing.Size(669, 388);
            this.ViewOrders.TabIndex = 2;
            this.ViewOrders.UseCompatibleStateImageBehavior = false;
            this.ViewOrders.View = System.Windows.Forms.View.Details;
            // 
            // IdField
            // 
            this.IdField.Text = "ID";
            this.IdField.Width = 32;
            // 
            // countyField
            // 
            this.countyField.Text = "Wojewódzstwo";
            this.countyField.Width = 145;
            // 
            // cityField
            // 
            this.cityField.Text = "Miasto";
            this.cityField.Width = 92;
            // 
            // adresField
            // 
            this.adresField.Text = "Adres";
            this.adresField.Width = 165;
            // 
            // statusField
            // 
            this.statusField.Text = "Status";
            // 
            // sumField
            // 
            this.sumField.Text = "Kwota";
            this.sumField.Width = 84;
            // 
            // showOrdersButton
            // 
            this.showOrdersButton.Location = new System.Drawing.Point(68, 506);
            this.showOrdersButton.Name = "showOrdersButton";
            this.showOrdersButton.Size = new System.Drawing.Size(91, 27);
            this.showOrdersButton.TabIndex = 3;
            this.showOrdersButton.Text = "Wyświetl";
            this.showOrdersButton.UseVisualStyleBackColor = true;
            this.showOrdersButton.Click += new System.EventHandler(this.showOrdersButton_Click);
            // 
            // realiseOrder
            // 
            this.realiseOrder.Location = new System.Drawing.Point(509, 506);
            this.realiseOrder.Name = "realiseOrder";
            this.realiseOrder.Size = new System.Drawing.Size(193, 30);
            this.realiseOrder.TabIndex = 4;
            this.realiseOrder.Text = "Zrealizować";
            this.realiseOrder.UseVisualStyleBackColor = true;
            this.realiseOrder.Click += new System.EventHandler(this.realiseOrder_Click);
            // 
            // ShowOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(979, 548);
            this.Controls.Add(this.realiseOrder);
            this.Controls.Add(this.showOrdersButton);
            this.Controls.Add(this.ViewOrders);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1100, 900);
            this.MinimumSize = new System.Drawing.Size(997, 595);
            this.Name = "ShowOrdersForm";
            this.Text = "Magazyn Budowalny";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label closeLable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label logOutButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ListOfClients;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label mainLableClick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ViewOrders;
        private System.Windows.Forms.ColumnHeader IdField;
        private System.Windows.Forms.ColumnHeader countyField;
        private System.Windows.Forms.ColumnHeader cityField;
        private System.Windows.Forms.ColumnHeader adresField;
        private System.Windows.Forms.ColumnHeader statusField;
        private System.Windows.Forms.ColumnHeader sumField;
        private System.Windows.Forms.Button showOrdersButton;
        private System.Windows.Forms.Button realiseOrder;
    }
}