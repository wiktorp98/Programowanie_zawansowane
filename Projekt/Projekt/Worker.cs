using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    class Worker : IWorker
    {
        public Worker()  {

        }
        public void orders()
        {

        }

        public Items[] showProducts()
        {
            List<Items> items = new List<Items>();
            var connection = new DBConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM items", connection.getConnetion());
            DataTable table = new DataTable();

            connection.openConnection();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0) {
                for (int a = 0; a < table.Rows.Count;a++) {
                    items.Add(new Items() { ID = Convert.ToInt32(table.Rows[a][0]), name = (string)table.Rows[a][1], price = Convert.ToSingle(table.Rows[a][2]), amount = Convert.ToInt32(table.Rows[a][3])});
                }
                
            }
            connection.closeConnection();
            return items.ToArray();
        }

        public Person[] showClients()
        {
            List<Person> clients = new List<Person>();
            //Get datas from DataBase
            var connection = new DBConnection();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE position = 'C'", connection.getConnetion());

            connection.openConnection();

            mySqlDataAdapter.SelectCommand = command;
            mySqlDataAdapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                for (int a = 0; a < table.Rows.Count; a++)
                {
                        clients.Add(new Person() { name = (string)table.Rows[a][1], surname = (string)table.Rows[a][2], email = (string)table.Rows[a][3] });
                }

            }

            connection.closeConnection();
            return clients.ToArray();
        }

        public void insertProducts(string name,float price,int amount)
        {
            var connection = new DBConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO `items`(`name`, `price`, `amount`) VALUES (@name, @price, @amount)", connection.getConnetion());
            connection.openConnection();
            if (name.Length > 4)
            {
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@price", MySqlDbType.Decimal).Value = price;
                command.Parameters.Add("@amount", MySqlDbType.Int32).Value = amount;
                adapter.SelectCommand = command;
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Produkt został dodany");
                }
            }
            else
            {
                MessageBox.Show("Nazwa musi buć dłusza");
            }
            connection.closeConnection();
        }
        public Order[] showOrders()
        {
            List<Order> orders = new List<Order>();
            //Get datas from DataBase
            var connection = new DBConnection();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM orders WHERE status = 'W' ", connection.getConnetion());

            connection.openConnection();

            mySqlDataAdapter.SelectCommand = command;
            mySqlDataAdapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                for (int a = 0; a < table.Rows.Count; a++)
                {
                    orders.Add(new Order() { id = Convert.ToInt32(table.Rows[a][0]), county = (string)table.Rows[a][1], city = (string)table.Rows[a][2] ,adres = (string)table.Rows[a][3], status = Convert.ToChar(table.Rows[a][4]) , sum = Convert.ToSingle(table.Rows[a][5])});
                }
            }

            connection.closeConnection();
            return orders.ToArray();
        }
    }
}
