namespace Projekt
{
    partial class RealiseOrderForm
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
            this.sendOrder = new System.Windows.Forms.Button();
            this.viewOrder = new System.Windows.Forms.ListView();
            this.IDField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amountField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showItems = new System.Windows.Forms.Button();
            this.orderReady = new System.Windows.Forms.CheckBox();
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
            this.panel2.Size = new System.Drawing.Size(979, 109);
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
            // sendOrder
            // 
            this.sendOrder.Location = new System.Drawing.Point(26, 479);
            this.sendOrder.Name = "sendOrder";
            this.sendOrder.Size = new System.Drawing.Size(122, 30);
            this.sendOrder.TabIndex = 15;
            this.sendOrder.Text = "Wysłać";
            this.sendOrder.UseVisualStyleBackColor = true;
            this.sendOrder.Click += new System.EventHandler(this.sendOrder_Click);
            // 
            // viewOrder
            // 
            this.viewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDField,
            this.nameField,
            this.amountField});
            this.viewOrder.FullRowSelect = true;
            this.viewOrder.GridLines = true;
            this.viewOrder.HideSelection = false;
            this.viewOrder.Location = new System.Drawing.Point(566, 112);
            this.viewOrder.Name = "viewOrder";
            this.viewOrder.Size = new System.Drawing.Size(387, 397);
            this.viewOrder.TabIndex = 16;
            this.viewOrder.UseCompatibleStateImageBehavior = false;
            this.viewOrder.View = System.Windows.Forms.View.Details;
            // 
            // IDField
            // 
            this.IDField.Text = "ID Produktu";
            this.IDField.Width = 88;
            // 
            // nameField
            // 
            this.nameField.Text = "Nazwa";
            this.nameField.Width = 234;
            // 
            // amountField
            // 
            this.amountField.Text = "Illość";
            // 
            // showItems
            // 
            this.showItems.Location = new System.Drawing.Point(566, 515);
            this.showItems.Name = "showItems";
            this.showItems.Size = new System.Drawing.Size(161, 29);
            this.showItems.TabIndex = 17;
            this.showItems.Text = "Wyświetl zamówienie";
            this.showItems.UseVisualStyleBackColor = true;
            this.showItems.Click += new System.EventHandler(this.showItems_Click);
            // 
            // orderReady
            // 
            this.orderReady.AutoSize = true;
            this.orderReady.Location = new System.Drawing.Point(26, 408);
            this.orderReady.Name = "orderReady";
            this.orderReady.Size = new System.Drawing.Size(113, 21);
            this.orderReady.TabIndex = 18;
            this.orderReady.Text = "Zrealizowany";
            this.orderReady.UseVisualStyleBackColor = true;
            // 
            // RealiseOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(979, 548);
            this.Controls.Add(this.orderReady);
            this.Controls.Add(this.showItems);
            this.Controls.Add(this.viewOrder);
            this.Controls.Add(this.sendOrder);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(1100, 900);
            this.MinimumSize = new System.Drawing.Size(997, 595);
            this.Name = "RealiseOrderForm";
            this.Text = "Magazyn Budowalny";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button sendOrder;
        private System.Windows.Forms.ListView viewOrder;
        private System.Windows.Forms.Button showItems;
        private System.Windows.Forms.CheckBox orderReady;
        private System.Windows.Forms.ColumnHeader IDField;
        private System.Windows.Forms.ColumnHeader nameField;
        private System.Windows.Forms.ColumnHeader amountField;
    }
}