namespace Projekt
{
    partial class BasketForm
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
            this.showItemsButton = new System.Windows.Forms.Button();
            this.basketViewList = new System.Windows.Forms.ListView();
            this.IDField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amountField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeItemButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.countyField = new System.Windows.Forms.TextBox();
            this.cityField = new System.Windows.Forms.TextBox();
            this.adresField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.panel2.Size = new System.Drawing.Size(979, 105);
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
            this.logOutLableClick.Location = new System.Drawing.Point(719, 34);
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
            this.logOutButton.Text = "Wyloguj się";
            this.logOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // basketLableClick
            // 
            this.basketLableClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.basketLableClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.basketLableClick.Controls.Add(this.label2);
            this.basketLableClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.basketLableClick.Location = new System.Drawing.Point(561, 34);
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
            this.label2.Text = "Koszyk";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel19
            // 
            this.panel19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel19.Controls.Add(this.mainLableClick);
            this.panel19.Location = new System.Drawing.Point(408, 34);
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
            // showItemsButton
            // 
            this.showItemsButton.Location = new System.Drawing.Point(45, 494);
            this.showItemsButton.Name = "showItemsButton";
            this.showItemsButton.Size = new System.Drawing.Size(110, 30);
            this.showItemsButton.TabIndex = 3;
            this.showItemsButton.Text = "Wyświetl";
            this.showItemsButton.UseVisualStyleBackColor = true;
            this.showItemsButton.Click += new System.EventHandler(this.showItemsButton_Click);
            // 
            // basketViewList
            // 
            this.basketViewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDField,
            this.nameField,
            this.amountField,
            this.priceField});
            this.basketViewList.FullRowSelect = true;
            this.basketViewList.GridLines = true;
            this.basketViewList.HideSelection = false;
            this.basketViewList.Location = new System.Drawing.Point(486, 122);
            this.basketViewList.Name = "basketViewList";
            this.basketViewList.Size = new System.Drawing.Size(378, 402);
            this.basketViewList.TabIndex = 4;
            this.basketViewList.UseCompatibleStateImageBehavior = false;
            this.basketViewList.View = System.Windows.Forms.View.Details;
            // 
            // IDField
            // 
            this.IDField.Text = "ID";
            this.IDField.Width = 48;
            // 
            // nameField
            // 
            this.nameField.Text = "Nazwa";
            this.nameField.Width = 127;
            // 
            // amountField
            // 
            this.amountField.Text = "Illość";
            this.amountField.Width = 84;
            // 
            // priceField
            // 
            this.priceField.Text = "Cena";
            this.priceField.Width = 115;
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(177, 494);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(101, 30);
            this.removeItemButton.TabIndex = 5;
            this.removeItemButton.Text = "Usuń";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(300, 494);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(108, 29);
            this.orderButton.TabIndex = 6;
            this.orderButton.Text = "Zamów";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // countyField
            // 
            this.countyField.Location = new System.Drawing.Point(130, 143);
            this.countyField.Name = "countyField";
            this.countyField.Size = new System.Drawing.Size(148, 22);
            this.countyField.TabIndex = 7;
            // 
            // cityField
            // 
            this.cityField.Location = new System.Drawing.Point(130, 205);
            this.cityField.Name = "cityField";
            this.cityField.Size = new System.Drawing.Size(148, 22);
            this.cityField.TabIndex = 8;
            // 
            // adresField
            // 
            this.adresField.Location = new System.Drawing.Point(130, 270);
            this.adresField.Name = "adresField";
            this.adresField.Size = new System.Drawing.Size(148, 22);
            this.adresField.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Województwo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Miasto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Adres";
            // 
            // BasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 548);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adresField);
            this.Controls.Add(this.cityField);
            this.Controls.Add(this.countyField);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.basketViewList);
            this.Controls.Add(this.showItemsButton);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(1100, 900);
            this.MinimumSize = new System.Drawing.Size(997, 595);
            this.Name = "BasketForm";
            this.Text = "BasketForm";
            this.panel2.ResumeLayout(false);
            this.logOutLableClick.ResumeLayout(false);
            this.basketLableClick.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button showItemsButton;
        private System.Windows.Forms.ListView basketViewList;
        private System.Windows.Forms.ColumnHeader IDField;
        private System.Windows.Forms.ColumnHeader nameField;
        private System.Windows.Forms.ColumnHeader amountField;
        private System.Windows.Forms.ColumnHeader priceField;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.TextBox countyField;
        private System.Windows.Forms.TextBox cityField;
        private System.Windows.Forms.TextBox adresField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}