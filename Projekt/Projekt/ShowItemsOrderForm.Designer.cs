namespace Projekt
{
    partial class ShowItemsOrderForm
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
            this.viewProducts = new System.Windows.Forms.ListView();
            this.showItems = new System.Windows.Forms.Button();
            this.mainButton = new System.Windows.Forms.Button();
            this.idField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // viewProducts
            // 
            this.viewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idField,
            this.nameField});
            this.viewProducts.HideSelection = false;
            this.viewProducts.Location = new System.Drawing.Point(60, 12);
            this.viewProducts.Name = "viewProducts";
            this.viewProducts.Size = new System.Drawing.Size(362, 456);
            this.viewProducts.TabIndex = 0;
            this.viewProducts.UseCompatibleStateImageBehavior = false;
            this.viewProducts.View = System.Windows.Forms.View.Details;
            // 
            // showItems
            // 
            this.showItems.Location = new System.Drawing.Point(13, 474);
            this.showItems.Name = "showItems";
            this.showItems.Size = new System.Drawing.Size(136, 39);
            this.showItems.TabIndex = 1;
            this.showItems.Text = "Wyświetl";
            this.showItems.UseVisualStyleBackColor = true;
            this.showItems.Click += new System.EventHandler(this.showItems_Click);
            // 
            // mainButton
            // 
            this.mainButton.Location = new System.Drawing.Point(337, 474);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(136, 39);
            this.mainButton.TabIndex = 2;
            this.mainButton.Text = "Strona główna";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // idField
            // 
            this.idField.Text = "ID";
            this.idField.Width = 88;
            // 
            // nameField
            // 
            this.nameField.Text = "Nazwa";
            this.nameField.Width = 369;
            // 
            // ShowItemsOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 525);
            this.Controls.Add(this.mainButton);
            this.Controls.Add(this.showItems);
            this.Controls.Add(this.viewProducts);
            this.MaximumSize = new System.Drawing.Size(504, 572);
            this.MinimumSize = new System.Drawing.Size(504, 572);
            this.Name = "ShowItemsOrderForm";
            this.Text = "ShowItemsOrderForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView viewProducts;
        private System.Windows.Forms.ColumnHeader idField;
        private System.Windows.Forms.ColumnHeader nameField;
        private System.Windows.Forms.Button showItems;
        private System.Windows.Forms.Button mainButton;
    }
}