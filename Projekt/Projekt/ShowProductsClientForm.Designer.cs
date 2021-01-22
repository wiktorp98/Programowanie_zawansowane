namespace Projekt
{
    partial class ShowProductsClientForm
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
            this.basketButton = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MainLabel = new System.Windows.Forms.Label();
            this.viewProducts = new System.Windows.Forms.ListView();
            this.idField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amountField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showProductsButton = new System.Windows.Forms.Button();
            this.insertToBasket = new System.Windows.Forms.Button();
            this.amountItems = new System.Windows.Forms.NumericUpDown();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountItems)).BeginInit();
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
            this.panel2.TabIndex = 11;
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
            this.panel1.Location = new System.Drawing.Point(751, 34);
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
            this.panel3.Controls.Add(this.basketButton);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel3.Location = new System.Drawing.Point(593, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(134, 37);
            this.panel3.TabIndex = 1;
            // 
            // basketButton
            // 
            this.basketButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.basketButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.basketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.basketButton.Location = new System.Drawing.Point(0, 0);
            this.basketButton.Name = "basketButton";
            this.basketButton.Size = new System.Drawing.Size(134, 37);
            this.basketButton.TabIndex = 0;
            this.basketButton.Text = "Koszyk";
            this.basketButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.basketButton.Click += new System.EventHandler(this.basketButton_Click);
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
            // viewProducts
            // 
            this.viewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idField,
            this.nameField,
            this.priceField,
            this.amountField});
            this.viewProducts.FullRowSelect = true;
            this.viewProducts.GridLines = true;
            this.viewProducts.HideSelection = false;
            this.viewProducts.Location = new System.Drawing.Point(502, 129);
            this.viewProducts.Name = "viewProducts";
            this.viewProducts.Size = new System.Drawing.Size(445, 407);
            this.viewProducts.TabIndex = 12;
            this.viewProducts.UseCompatibleStateImageBehavior = false;
            this.viewProducts.View = System.Windows.Forms.View.Details;
            // 
            // idField
            // 
            this.idField.Text = "ID";
            // 
            // nameField
            // 
            this.nameField.Text = "Nazwa";
            this.nameField.Width = 215;
            // 
            // priceField
            // 
            this.priceField.Text = "Cena";
            this.priceField.Width = 75;
            // 
            // amountField
            // 
            this.amountField.Text = "Illość";
            this.amountField.Width = 91;
            // 
            // showProductsButton
            // 
            this.showProductsButton.Location = new System.Drawing.Point(24, 503);
            this.showProductsButton.Name = "showProductsButton";
            this.showProductsButton.Size = new System.Drawing.Size(143, 33);
            this.showProductsButton.TabIndex = 13;
            this.showProductsButton.Text = "Wyświetl towar";
            this.showProductsButton.UseVisualStyleBackColor = true;
            this.showProductsButton.Click += new System.EventHandler(this.showProductsButton_Click);
            // 
            // insertToBasket
            // 
            this.insertToBasket.Location = new System.Drawing.Point(263, 503);
            this.insertToBasket.Name = "insertToBasket";
            this.insertToBasket.Size = new System.Drawing.Size(147, 33);
            this.insertToBasket.TabIndex = 14;
            this.insertToBasket.Text = "Dodaj do koszyka";
            this.insertToBasket.UseVisualStyleBackColor = true;
            this.insertToBasket.Click += new System.EventHandler(this.insertToBasket_Click);
            this.insertToBasket.Leave += new System.EventHandler(this.insertToBasket_Leave);
            // 
            // amountItems
            // 
            this.amountItems.Location = new System.Drawing.Point(263, 464);
            this.amountItems.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountItems.Name = "amountItems";
            this.amountItems.Size = new System.Drawing.Size(147, 22);
            this.amountItems.TabIndex = 15;
            this.amountItems.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountItems.ValueChanged += new System.EventHandler(this.amountItems_ValueChanged);
            // 
            // ShowProductsClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 548);
            this.Controls.Add(this.amountItems);
            this.Controls.Add(this.insertToBasket);
            this.Controls.Add(this.showProductsButton);
            this.Controls.Add(this.viewProducts);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(1100, 900);
            this.MinimumSize = new System.Drawing.Size(997, 595);
            this.Name = "ShowProductsClientForm";
            this.Text = "ShowProductsClientForm";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.amountItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label logOutButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label basketButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.ListView viewProducts;
        private System.Windows.Forms.Button showProductsButton;
        private System.Windows.Forms.Button insertToBasket;
        private System.Windows.Forms.ColumnHeader idField;
        private System.Windows.Forms.ColumnHeader nameField;
        private System.Windows.Forms.ColumnHeader priceField;
        private System.Windows.Forms.ColumnHeader amountField;
        private System.Windows.Forms.NumericUpDown amountItems;
    }
}