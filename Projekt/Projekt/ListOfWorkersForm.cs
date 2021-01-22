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
    public partial class ListOfWorkersForm : Form
    {
        Director director = new Director();
        string whoIs;
        ChangeWindow change;
        string idClient;
        public ListOfWorkersForm(string whoIs,string idClient)
        {
            InitializeComponent();
            this.whoIs = whoIs;
            this.idClient = idClient;
        }

        private void GanarateListOfClients_Click(object sender, EventArgs e)
        {
            //ShowWorkers
            Person[] workers = null;
            workers = director.showWorkers();
            ShowWorkers.Items.Clear();
            foreach (var client in workers)
            {
                string[] row = new string[] { client.name, client.surname, client.email };
                var item = new ListViewItem(row);
                item.Tag = "Client";
                ShowWorkers.Items.Add(item);

            }
        }

        private void MainLabel_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this, new DirectorForm("D",idClient));
        }

        private void ListOfClients_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this, new ListOfClientsForm(whoIs,idClient));
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this, new LoginForm());
        }
    }
}
