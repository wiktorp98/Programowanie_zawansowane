namespace Projekt
{
    partial class ModifyProductForm
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
            this.loginTopPanel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.amountField = new System.Windows.Forms.NumericUpDown();
            this.PriceField = new System.Windows.Forms.NumericUpDown();
            this.nameField = new System.Windows.Forms.TextBox();
            this.nameCheckBox = new System.Windows.Forms.CheckBox();
            this.priceCheckBox = new System.Windows.Forms.CheckBox();
            this.amountCheckBox = new System.Windows.Forms.CheckBox();
            this.ModifyProductButton = new System.Windows.Forms.Button();
            this.mainLableClick = new System.Windows.Forms.Label();
            this.loginTopPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceField)).BeginInit();
            this.SuspendLayout();
            // 
            // loginTopPanel1
            // 
            this.loginTopPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTopPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(133)))), ((int)(((byte)(116)))));
            this.loginTopPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginTopPanel1.Controls.Add(this.label1);
            this.loginTopPanel1.Location = new System.Drawing.Point(-1, -1);
            this.loginTopPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.loginTopPanel1.Name = "loginTopPanel1";
            this.loginTopPanel1.Size = new System.Drawing.Size(506, 121);
            this.loginTopPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(503, 121);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zmodyfikuj";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ilość:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nazwa:";
            // 
            // amountField
            // 
            this.amountField.Location = new System.Drawing.Point(151, 329);
            this.amountField.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.amountField.Name = "amountField";
            this.amountField.Size = new System.Drawing.Size(208, 22);
            this.amountField.TabIndex = 9;
            this.amountField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PriceField
            // 
            this.PriceField.Location = new System.Drawing.Point(151, 253);
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
            this.PriceField.TabIndex = 8;
            this.PriceField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nameField
            // 
            this.nameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameField.Location = new System.Drawing.Point(141, 172);
            this.nameField.Multiline = true;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(232, 41);
            this.nameField.TabIndex = 7;
            // 
            // nameCheckBox
            // 
            this.nameCheckBox.AutoSize = true;
            this.nameCheckBox.Location = new System.Drawing.Point(37, 181);
            this.nameCheckBox.Name = "nameCheckBox";
            this.nameCheckBox.Size = new System.Drawing.Size(72, 21);
            this.nameCheckBox.TabIndex = 13;
            this.nameCheckBox.Text = "Nazwa";
            this.nameCheckBox.UseVisualStyleBackColor = true;
            // 
            // priceCheckBox
            // 
            this.priceCheckBox.AutoSize = true;
            this.priceCheckBox.Location = new System.Drawing.Point(37, 254);
            this.priceCheckBox.Name = "priceCheckBox";
            this.priceCheckBox.Size = new System.Drawing.Size(63, 21);
            this.priceCheckBox.TabIndex = 13;
            this.priceCheckBox.Text = "Cena";
            this.priceCheckBox.UseVisualStyleBackColor = true;
            // 
            // amountCheckBox
            // 
            this.amountCheckBox.AutoSize = true;
            this.amountCheckBox.Location = new System.Drawing.Point(37, 330);
            this.amountCheckBox.Name = "amountCheckBox";
            this.amountCheckBox.Size = new System.Drawing.Size(61, 21);
            this.amountCheckBox.TabIndex = 13;
            this.amountCheckBox.Text = "Illosć";
            this.amountCheckBox.UseVisualStyleBackColor = true;
            // 
            // ModifyProductButton
            // 
            this.ModifyProductButton.Location = new System.Drawing.Point(154, 383);
            this.ModifyProductButton.Name = "ModifyProductButton";
            this.ModifyProductButton.Size = new System.Drawing.Size(205, 42);
            this.ModifyProductButton.TabIndex = 14;
            this.ModifyProductButton.Text = "Zmodyfikój";
            this.ModifyProductButton.UseVisualStyleBackColor = true;
            this.ModifyProductButton.Click += new System.EventHandler(this.ModifyProductButton_Click);
            // 
            // mainLableClick
            // 
            this.mainLableClick.AutoSize = true;
            this.mainLableClick.Location = new System.Drawing.Point(206, 442);
            this.mainLableClick.Name = "mainLableClick";
            this.mainLableClick.Size = new System.Drawing.Size(98, 17);
            this.mainLableClick.TabIndex = 15;
            this.mainLableClick.Text = "Strona główna";
            this.mainLableClick.Click += new System.EventHandler(this.mainLableClick_Click);
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(505, 480);
            this.Controls.Add(this.mainLableClick);
            this.Controls.Add(this.ModifyProductButton);
            this.Controls.Add(this.amountCheckBox);
            this.Controls.Add(this.priceCheckBox);
            this.Controls.Add(this.nameCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.amountField);
            this.Controls.Add(this.PriceField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.loginTopPanel1);
            this.Name = "ModifyProductForm";
            this.Text = "Magazyn Budowalny";
            this.loginTopPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.amountField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel loginTopPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown amountField;
        private System.Windows.Forms.NumericUpDown PriceField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.CheckBox nameCheckBox;
        private System.Windows.Forms.CheckBox priceCheckBox;
        private System.Windows.Forms.CheckBox amountCheckBox;
        private System.Windows.Forms.Button ModifyProductButton;
        private System.Windows.Forms.Label mainLableClick;
    }
}