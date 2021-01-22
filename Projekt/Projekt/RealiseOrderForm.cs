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
    public partial class RealiseOrderForm : Form
    {
        string id;
        string whoIs;
        string idClient;
        ChangeWindow change;
        public RealiseOrderForm(string id, string whoIs, string idClient)
        {
            InitializeComponent();
            this.id = id;
            this.whoIs = whoIs;
            this.idClient = idClient;
        }

        private void showItems_Click(object sender, EventArgs e)
        {

            string itemsOrder = "";
            var connection = new DBConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand($"SELECT items FROM orders WHERE id = {id}", connection.getConnetion());
            connection.openConnection();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0) {
                itemsOrder = (string)table.Rows[0][0];
            }

            connection.closeConnection();

            string[] array = itemsOrder.Split(';');
            viewOrder.Items.Clear();
            foreach(var item in array)
            {
                string[] items = item.Split(',');
                var listView = new ListViewItem(items);
                viewOrder.Items.Add(listView);
            }


        }

        private void sendOrder_Click(object sender, EventArgs e)
        {
            var connection = new DBConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            
            if (orderReady.CheckState == CheckState.Checked) {
                connection.openConnection();
                MySqlCommand command = new MySqlCommand($"UPDATE `orders` SET `status`= 'R' WHERE id = @id", connection.getConnetion());
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(id);

                adapter.SelectCommand = command;
                if (command.ExecuteNonQuery() == 1) {
                    MessageBox.Show("Zamówienie zostało wysłane");
                    SystemDatas.returnToMain(this,whoIs,idClient);
                }
                connection.closeConnection();
            }
        }

        private void MainLabel_Click(object sender, EventArgs e)
        {
            if (whoIs == "D")
            {
                change = new ChangeWindow(this, new DirectorForm("D",idClient));
            }
            else
            {
                change = new ChangeWindow(this, new WorkerForm("W",idClient));
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
