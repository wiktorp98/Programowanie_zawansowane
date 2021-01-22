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
    public partial class ShowProductsClientForm : Form
    {
        Client client = new Client();
        ChangeWindow change;
        string idClient;
        public ShowProductsClientForm(string idClient)
        {
            InitializeComponent();
            this.idClient = idClient;
        }

        private void showProductsButton_Click(object sender, EventArgs e)
        {
            List<Items> items = client.showProducts();
            viewProducts.Items.Clear();
            foreach (var item in items) {
                string[] array = new string[] { Convert.ToString(item.ID), item.name, Convert.ToString(item.price), Convert.ToString(item.amount) };
                ListViewItem listView = new ListViewItem(array);
                viewProducts.Items.Add(listView);

            }
        }

        private void MainLabel_Click(object sender, EventArgs e)
        {
            SystemDatas.serialize();
            change = new ChangeWindow(this, new ClientForm("C",idClient));
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            SystemDatas.serialize();
            change = new ChangeWindow(this,new LoginForm());
        }

        private void insertToBasket_Click(object sender, EventArgs e)
        {
            var connection = new DBConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            int bremainder = Convert.ToInt32(viewProducts.SelectedItems[0].SubItems[3].Text) - Convert.ToInt32(amountItems.Value);
            if (viewProducts.SelectedItems.Count > 0 && bremainder >= 0)
            {
                var item = viewProducts.SelectedItems[0];
                client.addProducts(Convert.ToInt32(item.SubItems[0].Text), item.SubItems[1].Text, Convert.ToSingle(item.SubItems[2].Text), Convert.ToInt32(amountItems.Value), idClient);

                viewProducts.SelectedItems[0].SubItems[3].Text = Convert.ToString(bremainder);

                MySqlCommand command = new MySqlCommand("UPDATE items SET amount = @bremainder WHERE ID = @id ", connection.getConnetion());
                command.Parameters.Add("@bremainder", MySqlDbType.Int32).Value = bremainder;
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(item.SubItems[0].Text);
                connection.openConnection();
                adapter.SelectCommand = command;
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Produkt dodany do koszyka");
                }

                connection.closeConnection();

            }
            else {
                MessageBox.Show("Nie mamy tyle tego towaru");
            }
           
        }

        private void amountItems_ValueChanged(object sender, EventArgs e)
        {
            var item = viewProducts.SelectedItems[0];
            amountItems.Maximum = Convert.ToDecimal(item.SubItems[3].Text);
        }

        private void insertToBasket_Leave(object sender, EventArgs e)
        {
            SystemDatas.serialize();
        }

        private void basketButton_Click(object sender, EventArgs e)
        {
            SystemDatas.serialize();
            change = new ChangeWindow(this,new BasketForm(idClient));
        }
    }
}
