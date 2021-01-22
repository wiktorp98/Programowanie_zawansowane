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
    public partial class ModifyProductForm : Form
    {   string whoIs;
        string idClient;
        string id;
        public ModifyProductForm(string whoIs,string id,string idClient)
        {
            InitializeComponent();
            this.id = id;
            this.whoIs = whoIs;
            this.idClient = idClient;
        }

        private void ModifyProductButton_Click(object sender, EventArgs e)
        {
            string stringCommand = "UPDATE `items` SET";
            if (nameCheckBox.CheckState == CheckState.Checked) {
                stringCommand += $"`name`='{nameField.Text}'";
            }
            if (nameCheckBox.CheckState == CheckState.Checked && (priceCheckBox.CheckState == CheckState.Checked || amountCheckBox.CheckState == CheckState.Checked)) {
                stringCommand += ",";
            }
            if (priceCheckBox.CheckState == CheckState.Checked)
            {
                stringCommand += $"`price`={PriceField.Value}";
            }
            if (priceCheckBox.CheckState == CheckState.Checked && amountCheckBox.CheckState == CheckState.Checked) {
                stringCommand += ",";
            }
            if (amountCheckBox.CheckState == CheckState.Checked)
            {
                stringCommand += $"`amount`= {amountField.Value}";
            }
            stringCommand += $" WHERE ID = {id}";

            var connection = new DBConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand(stringCommand, connection.getConnetion());
            connection.openConnection();
            adapter.SelectCommand = command;

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Dane zostały zmienione");
            }
            else {
                MessageBox.Show("Wystąpił błąd");
            }
            connection.closeConnection();
        }

        private void mainLableClick_Click(object sender, EventArgs e)
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
    }
}
