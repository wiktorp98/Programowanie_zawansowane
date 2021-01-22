using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class BasketForm : Form
    {
        string idClient;
        Client client = new Client();
        ChangeWindow change;
        public BasketForm(string idClient)
        {
            InitializeComponent();
            this.idClient = idClient;
        }

        private void mainLableClick_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this, new ClientForm("C", idClient));
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this, new LoginForm());
        }

        private void showItemsButton_Click(object sender, EventArgs e)
        {
            List<Items> items = client.showBasket(idClient);
            basketViewList.Items.Clear();
            if (items != null)
            {
                basketViewList.Items.Clear();
                foreach (var item in items)
                {
                    string[] array = new string[] { Convert.ToString(item.ID), item.name, Convert.ToString(item.amount), Convert.ToString(item.amount * item.price) };
                    ListViewItem listView = new ListViewItem(array);
                    basketViewList.Items.Add(listView);
                }
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            List<Items> items = client.showBasket(idClient);
            List<string> errors = new List<string>();

            var connection = new DBConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            connection.openConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO `orders`(`county`, `city`, `adres`, `status`, `sum`, `items`, `id_client`) VALUES ( @county , @city , @adres , 'W' , @sum , @items, @idClient ) ",connection.getConnetion());

            if (countyField.Text.Length <= 0) {
                errors.Add("Pole wojewodzsto puste");
            }
            if (cityField.Text.Length <= 0) {
                errors.Add("Pole miasto jest puste");
            }
            if (adresField.Text.Length <= 0) {
                errors.Add("Pole adres jest puste");
            }

            if (errors.ToArray().Length > 0 || items.ToArray().Length <= 0 )
            {
                string errorString = "";
                foreach (var error in errors)
                {
                    errorString += error + "\n";
                }
                MessageBox.Show(errorString + " lub koszyk jest pusty ");
            }
            else {
                if (items != null)
                {
                    string orderString = "";
                    float sum = 0;
                    foreach (var item in items)
                    {
                        orderString += $"{item.ID},{item.name},{item.amount};";
                        sum += item.amount * item.price;
                    }
                    command.Parameters.Add("@county",MySqlDbType.VarChar).Value = countyField.Text;
                    command.Parameters.Add("@city",MySqlDbType.VarChar).Value = cityField.Text;
                    command.Parameters.Add("@adres",MySqlDbType.VarChar).Value = adresField.Text;
                    command.Parameters.Add("sum",MySqlDbType.Decimal).Value = sum;
                    command.Parameters.Add("@items",MySqlDbType.Text).Value = orderString;
                    command.Parameters.Add("@idClient", MySqlDbType.Int32).Value = Convert.ToInt32(idClient);

                    connection.openConnection();

                    if (command.ExecuteNonQuery() == 1) {
                        MessageBox.Show("Zamówenie zostało złożone");
                        Basket.basket.Remove(idClient);
                        SystemDatas.serialize();
                    }

                    connection.closeConnection();
                }
            }


        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            var connection = new DBConnection();
            List<Items> item = client.showBasket(idClient);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand updateCommand = new MySqlCommand("UPDATE items SET amount = @amount WHERE ID = @id",connection.getConnetion());
            MySqlCommand getCommand = new MySqlCommand("SELECT amount FROM items WHERE id = @id",connection.getConnetion());



            if (basketViewList.SelectedItems.Count > 0) {
                int cout = 0;
                var items = basketViewList.SelectedItems[0];
                // 0 - ID , 2 - amount
                string id = Convert.ToString(items.SubItems[0].Text);
                int amount = Convert.ToInt32(items.SubItems[2].Text);
                string itemName = items.SubItems[1].Text;

                connection.openConnection();

                getCommand.Parameters.Add("@id",MySqlDbType.Int32).Value = Convert.ToInt32(id);

                adapter.SelectCommand = getCommand;
                adapter.Fill(table);
                amount += Convert.ToInt32(table.Rows[0][0]);

                updateCommand.Parameters.Add("@amount",MySqlDbType.Int32).Value = amount;
                updateCommand.Parameters.Add("@id" ,MySqlDbType.Int32).Value = Convert.ToInt32(id);

                if (updateCommand.ExecuteNonQuery() == 1) {
                    MessageBox.Show("Produkt usunięnty");
                }

                foreach(var i in item)
                {
                    if (i.name == itemName) {
                        break;
                    }
                    cout++;
                }
                Basket.basket[idClient].RemoveAt(cout);
                SystemDatas.serialize();
                connection.closeConnection();
            }
            
        }
    }
}
