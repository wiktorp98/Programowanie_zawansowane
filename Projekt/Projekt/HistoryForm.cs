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
    public partial class HistoryForm : Form
    {
        string idClient { get; set; }
        public HistoryForm(string idClient)
        {
            this.idClient = idClient;
            InitializeComponent();
        }

        private void showHistory_Click(object sender, EventArgs e)
        {
            var connection = new DBConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT id,sum FROM orders WHERE id_client = @id",connection.getConnetion());
            DataTable table = new DataTable();

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(idClient);
            adapter.SelectCommand = command;
            adapter.Fill(table);

            historyView.Items.Clear();
            if (table.Rows.Count > 0)
            {
                for (int a = 0; a < table.Rows.Count; a++)
                {
                    string[] array = new string[] { Convert.ToString(table.Rows[a][0]), Convert.ToString(table.Rows[a][1]) };
                    ListViewItem item = new ListViewItem(array);
                    historyView.Items.Add(item);
                }
            }
        }

        private void showProducts_Click(object sender, EventArgs e)
        {
            var connection = new DBConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT items from orders WHERE id = @id",connection.getConnetion());
            DataTable table = new DataTable();


            if (historyView.SelectedItems.Count > 0) {
                int id = Convert.ToInt32(historyView.SelectedItems[0].SubItems[0].Text);

                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                string items = Convert.ToString(table.Rows[0][0]);

                ChangeWindow change = new ChangeWindow(this,new ShowItemsOrderForm(idClient,items));
            }
        }

        private void mainLableClick_Click(object sender, EventArgs e)
        {
            ChangeWindow change = new ChangeWindow(this, new ClientForm("C", idClient));
        }
    }
}
