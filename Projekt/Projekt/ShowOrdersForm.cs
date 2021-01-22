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
    public partial class ShowOrdersForm : Form
    {
        Director director = new Director();
        ChangeWindow change;
        string idClient;
        string whoIs;
        public ShowOrdersForm(string whoIs,string idClient)
        {
            InitializeComponent();
            this.whoIs = whoIs;
            this.idClient = idClient;
        }

        private void showOrdersButton_Click(object sender, EventArgs e)
        {
            Order[] orders = director.showOrders();
            ViewOrders.Items.Clear();
            foreach (var order in orders)
            {
                string[] array = new string[] { Convert.ToString(order.id),order.county,order.city,order.adres,Convert.ToString(order.status),Convert.ToString(order.sum) };
                var listView = new ListViewItem(array);
                ViewOrders.Items.Add(listView);
            }
        }

        private void realiseOrder_Click(object sender, EventArgs e)
        {
            if (ViewOrders.SelectedItems.Count != 0)
            {
                change = new ChangeWindow(this, new RealiseOrderForm(ViewOrders.SelectedItems[0].Text, whoIs,idClient));
            }
                
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
