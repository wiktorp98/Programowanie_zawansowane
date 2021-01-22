namespace Projekt
{
    partial class ShowProductsForm
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
            this.logOutLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ListOfClients = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MainLabel = new System.Windows.Forms.Label();
            this.ViewProducts = new System.Windows.Forms.ListView();
            this.IDField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AmountField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InsertProductButton = new System.Windows.Forms.Button();
            this.RemoveProductButton = new System.Windows.Forms.Button();
            this.ModificationProduktButton = new System.Windows.Forms.Button();
            this.ShowProductsButton = new System.Windows.Forms.Button();
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
            this.panel2.Size = new System.Drawing.Size(979, 105);
            this.panel2.TabIndex = 10;
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
            this.panel1.Controls.Add(this.logOutLabel);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(751, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 37);
            this.panel1.TabIndex = 1;
            // 
            // logOutLabel
            // 
            this.logOutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logOutLabel.Location = new System.Drawing.Point(0, 0);
            this.logOutLabel.Name = "logOutLabel";
            this.logOutLabel.Size = new System.Drawing.Size(134, 37);
            this.logOutLabel.TabIndex = 0;
            this.logOutLabel.Text = "Wyłoguj się";
            this.logOutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logOutLabel.Click += new System.EventHandler(this.logOutLabel_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.ListOfClients);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel3.Location = new System.Drawing.Point(593, 34);
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
            this.panel4.Location = new System.Drawing.Point(440, 34);
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
            // ViewProducts
            // 
            this.ViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDField,
            this.NameField,
            this.PriceField,
            this.AmountField});
            this.ViewProducts.FullRowSelect = true;
            this.ViewProducts.GridLines = true;
            this.ViewProducts.HideSelection = false;
            this.ViewProducts.Location = new System.Drawing.Point(314, 108);
            this.ViewProducts.Name = "ViewProducts";
            this.ViewProducts.Size = new System.Drawing.Size(653, 373);
            this.ViewProducts.TabIndex = 11;
            this.ViewProducts.UseCompatibleStateImageBehavior = false;
            this.ViewProducts.View = System.Windows.Forms.View.Details;
            // 
            // IDField
            // 
            this.IDField.Text = "ID";
            this.IDField.Width = 94;
            // 
            // NameField
            // 
            this.NameField.Text = "Nazwa";
            this.NameField.Width = 251;
            // 
            // PriceField
            // 
            this.PriceField.Text = "Cena";
            this.PriceField.Width = 70;
            // 
            // AmountField
            // 
            this.AmountField.Text = "Ilość";
            this.AmountField.Width = 227;
            // 
            // InsertProductButton
            // 
            this.InsertProductButton.Location = new System.Drawing.Point(314, 500);
            this.InsertProductButton.Name = "InsertProductButton";
            this.InsertProductButton.Size = new System.Drawing.Size(151, 36);
            this.InsertProductButton.TabIndex = 12;
            this.InsertProductButton.Text = "Dodaj produkt";
            this.InsertProductButton.UseVisualStyleBackColor = true;
            this.InsertProductButton.Click += new System.EventHandler(this.InsertProductButton_Click);
            // 
            // RemoveProductButton
            // 
            this.RemoveProductButton.Location = new System.Drawing.Point(565, 500);
            this.RemoveProductButton.Name = "RemoveProductButton";
            this.RemoveProductButton.Size = new System.Drawing.Size(151, 36);
            this.RemoveProductButton.TabIndex = 12;
            this.RemoveProductButton.Text = "Usuń produkt";
            this.RemoveProductButton.UseVisualStyleBackColor = true;
            this.RemoveProductButton.Click += new System.EventHandler(this.RemoveProductButton_Click);
            // 
            // ModificationProduktButton
            // 
            this.ModificationProduktButton.Location = new System.Drawing.Point(816, 500);
            this.ModificationProduktButton.Name = "ModificationProduktButton";
            this.ModificationProduktButton.Size = new System.Drawing.Size(151, 36);
            this.ModificationProduktButton.TabIndex = 12;
            this.ModificationProduktButton.Text = "Zmodyfikuj";
            this.ModificationProduktButton.UseVisualStyleBackColor = true;
            this.ModificationProduktButton.Click += new System.EventHandler(this.ModificationProduktButton_Click);
            // 
            // ShowProductsButton
            // 
            this.ShowProductsButton.Location = new System.Drawing.Point(59, 500);
            this.ShowProductsButton.Name = "ShowProductsButton";
            this.ShowProductsButton.Size = new System.Drawing.Size(151, 36);
            this.ShowProductsButton.TabIndex = 13;
            this.ShowProductsButton.Text = "Wyświetl towar";
            this.ShowProductsButton.UseVisualStyleBackColor = true;
            this.ShowProductsButton.Click += new System.EventHandler(this.ShowProductsButton_Click);
            // 
            // ShowProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(979, 548);
            this.Controls.Add(this.ShowProductsButton);
            this.Controls.Add(this.ModificationProduktButton);
            this.Controls.Add(this.RemoveProductButton);
            this.Controls.Add(this.InsertProductButton);
            this.Controls.Add(this.ViewProducts);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(1100, 900);
            this.MinimumSize = new System.Drawing.Size(997, 595);
            this.Name = "ShowProductsForm";
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
        private System.Windows.Forms.Label logOutLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ListOfClients;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.ListView ViewProducts;
        private System.Windows.Forms.ColumnHeader IDField;
        private System.Windows.Forms.ColumnHeader NameField;
        private System.Windows.Forms.ColumnHeader PriceField;
        private System.Windows.Forms.ColumnHeader AmountField;
        private System.Windows.Forms.Button InsertProductButton;
        private System.Windows.Forms.Button RemoveProductButton;
        private System.Windows.Forms.Button ModificationProduktButton;
        private System.Windows.Forms.Button ShowProductsButton;
    }
}