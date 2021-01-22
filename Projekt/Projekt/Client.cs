using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace Projekt
{
    class Client : IClient
    {
        public void addProducts(int id,string name,float price,int amount,string idClient)
        {
            List<Items> cards = new List<Items>();

            if (!Basket.basket.ContainsKey(idClient))
            {
                Basket.basket.Add(idClient, cards);
            }
            Basket.basket[idClient].Add(new Items() { ID = id, name = name, price = price, amount = amount });
            
        }

        public void order()
        {
            throw new NotImplementedException();
        }

        public List<Items> showBasket(string id)
        {
            if (Basket.basket.ContainsKey(id))
            {
                return Basket.basket[id];
            }
            return null;
        }

        public void showLastOrders()
        {
            throw new NotImplementedException();
        }

        public List<Items> showProducts()
        {
            List<Items> items = new List<Items>();
            var connection = new DBConnection();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * from items",connection.getConnetion());

            connection.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            
            if (table.Rows.Count > 0) {
                for (int a = 0; a < table.Rows.Count; a++) {
                    items.Add(new Items() { ID = Convert.ToInt32(table.Rows[a][0]), name = (string)table.Rows[a][1], price = Convert.ToSingle(table.Rows[a][2]), amount = Convert.ToInt32(table.Rows[a][3]) });
                }
            }
            connection.closeConnection();
            return items;


        }
    }
}
