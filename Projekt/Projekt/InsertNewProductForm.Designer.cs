namespace Projekt
{
    partial class InsertNewProductForm
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
            this.nameField = new System.Windows.Forms.TextBox();
            this.PriceField = new System.Windows.Forms.NumericUpDown();
            this.amountField = new System.Windows.Forms.NumericUpDown();
            this.insertProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginTopPanel1 = new System.Windows.Forms.Panel();
            this.mainLableClick = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PriceField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountField)).BeginInit();
            this.loginTopPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameField
            // 
            this.nameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameField.Location = new System.Drawing.Point(119, 144);
            this.nameField.Multiline = true;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(232, 41);
            this.nameField.TabIndex = 0;
            // 
            // PriceField
            // 
            this.PriceField.Location = new System.Drawing.Point(129, 225);
            this.PriceField.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PriceField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PriceField.Name = "PriceField";
            this.PriceField.Size = new System.Drawing.Size(208, 22);
            this.PriceField.TabIndex = 1;
            this.PriceField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // amountField
            // 
            this.amountField.Location = new System.Drawing.Point(129, 301);
            this.amountField.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.amountField.Name = "amountField";
            this.amountField.Size = new System.Drawing.Size(208, 22);
            this.amountField.TabIndex = 2;
            this.amountField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // insertProduct
            // 
            this.insertProduct.Location = new System.Drawing.Point(149, 346);
            this.insertProduct.Name = "insertProduct";
            this.insertProduct.Size = new System.Drawing.Size(160, 45);
            this.insertProduct.TabIndex = 3;
            this.insertProduct.Text = "Dodaj Produkt";
            this.insertProduct.UseVisualStyleBackColor = true;
            this.insertProduct.Click += new System.EventHandler(this.insertProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nazwa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ilość:";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(479, 105);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dodawanie towaru";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginTopPanel1
            // 
            this.loginTopPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTopPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(133)))), ((int)(((byte)(116)))));
            this.loginTopPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginTopPanel1.Controls.Add(this.label4);
            this.loginTopPanel1.Location = new System.Drawing.Point(1, -2);
            this.loginTopPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.loginTopPanel1.Name = "loginTopPanel1";
            this.loginTopPanel1.Size = new System.Drawing.Size(482, 105);
            this.loginTopPanel1.TabIndex = 7;
            // 
            // mainLableClick
            // 
            this.mainLableClick.AutoSize = true;
            this.mainLableClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainLableClick.Location = new System.Drawing.Point(179, 410);
            this.mainLableClick.Name = "mainLableClick";
            this.mainLableClick.Size = new System.Drawing.Size(101, 17);
            this.mainLableClick.TabIndex = 8;
            this.mainLableClick.Text = "Strona Główna";
            this.mainLableClick.Click += new System.EventHandler(this.mainLableClick_Click);
            // 
            // InsertNewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.mainLableClick);
            this.Controls.Add(this.loginTopPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insertProduct);
            this.Controls.Add(this.amountField);
            this.Controls.Add(this.PriceField);
            this.Controls.Add(this.nameField);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "InsertNewProductForm";
            this.Text = "Magazyn Budowalny";
            ((System.ComponentModel.ISupportInitialize)(this.PriceField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountField)).EndInit();
            this.loginTopPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.NumericUpDown PriceField;
        private System.Windows.Forms.NumericUpDown amountField;
        private System.Windows.Forms.Button insertProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel loginTopPanel1;
        private System.Windows.Forms.Label mainLableClick;
    }
}