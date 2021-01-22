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
    public partial class WorkerForm : Form
    {
        string whoIs;
        ChangeWindow change;
        public string idClient { get; set; }
        public WorkerForm(string whoIs,string idClient)
        {
            this.idClient = idClient;
            this.whoIs = whoIs;
            InitializeComponent();

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this, new LoginForm());
        }

        private void showClientsButton_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this, new ListOfClientsForm(whoIs, idClient));
        }

        private void showProductsButton_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this, new ShowProductsForm("W", idClient));
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this, new InsertNewProductForm("W", idClient));
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this, new ShowOrdersForm("W", idClient));
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this,new ShowOrdersForm(whoIs, idClient));
        }
    }
}
