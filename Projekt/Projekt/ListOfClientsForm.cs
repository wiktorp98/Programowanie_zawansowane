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
    public partial class ListOfClientsForm : Form
    {
        string whoIs;
        Director director = new Director();
        ChangeWindow change;
        string idClient;
        public ListOfClientsForm(string whoIs,string idClient)
        {
            InitializeComponent();
            this.whoIs = whoIs;
            this.idClient = idClient;
        }

        private void mainLableClick_Click(object sender, EventArgs e)
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

        private void logOutButton_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this, new LoginForm());
        }

        private void GanarateListOfClients_Click(object sender, EventArgs e)
        {
            Person[] clients = null; 
            clients = director.showClients();
            ShowClients.Items.Clear();
            foreach (var client in clients) {
                string[] row = new string[] { client.name, client.surname, client.email };
                var item = new ListViewItem(row);
                item.Tag = "Client";
                ShowClients.Items.Add(item);

            }
        }
    }
}
