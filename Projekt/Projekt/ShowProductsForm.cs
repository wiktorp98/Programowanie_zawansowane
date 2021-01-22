using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Projekt
{
    public partial class ShowProductsForm : Form
    {
        Director director = new Director();
        ChangeWindow change;
        string whoIs;
        string idClient;

        public ShowProductsForm(string whoIs,string idClient)
        {
            InitializeComponent();
            this.whoIs = whoIs;
            this.idClient = idClient;
        }

        private void ShowProductsButton_Click(object sender, EventArgs e)
        {
            Items[] items = director.showProducts();
            ViewProducts.Items.Clear();
            foreach (var item in items) {
                string[] array = new string[] { Convert.ToString(item.ID), item.name, Convert.ToString(item.price), Convert.ToString(item.amount) };
                var listView = new ListViewItem(array);
                ViewProducts.Items.Add(listView);
            }
        }

        private void InsertProductButton_Click(object sender, EventArgs e)
        {
           change = new ChangeWindow(this, new InsertNewProductForm(whoIs,idClient));
        }

        private void RemoveProductButton_Click(object sender, EventArgs e)
        {
            var connection = new DBConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("DELETE from items WHERE id = @id",connection.getConnetion());
            if(ViewProducts.SelectedItems.Count != 0)
            {
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = ViewProducts.SelectedItems[0].Text;
                if (MessageBox.Show($"Czy napewno chcesz usunąć produkt?  - { ViewProducts.SelectedItems[0].Text}", "Usunąć", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    connection.openConnection();
                    if (command.ExecuteNonQuery() == 1) {
                        MessageBox.Show("Produkt został usunięty");
                    }
                    connection.closeConnection();
                }
            }
        }

        private void ModificationProduktButton_Click(object sender, EventArgs e)
        {
            if (ViewProducts.SelectedItems.Count != 0)
                change = new ChangeWindow(this, new ModifyProductForm(whoIs,ViewProducts.SelectedItems[0].Text,idClient));
        }

        private void MainLabel_Click(object sender, EventArgs e)
        {
            if (whoIs == "D")
            {
                ChangeWindow change = new ChangeWindow(this, new DirectorForm("D",idClient));
            }
            else
            {
                ChangeWindow change = new ChangeWindow(this, new WorkerForm("W",idClient));
            }
        }

        private void ListOfClients_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this, new ListOfClientsForm(whoIs,idClient));
        }

        private void logOutLabel_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this, new LoginForm());
        }
    }
}
