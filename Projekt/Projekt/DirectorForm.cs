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
    public partial class DirectorForm : Form
    {
        string whoIs;
        ChangeWindow change;
        public string idClient { get; set; }
        public DirectorForm(string whoIs, string idClient)
        {
            this.idClient = idClient;
            this.whoIs = whoIs;
            InitializeComponent();
        }

        private void showClients_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this, new ListOfClientsForm(whoIs,idClient));
        }

        private void showWorkers_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this, new ListOfWorkersForm(whoIs, idClient));
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this,new LoginForm());
        }

        private void inviteWorker_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this, new InviteWorkerForm(idClient));
        }

        private void showProducts_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this,new ShowProductsForm("D", idClient));
        }

        private void insertProduct_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this,new InsertNewProductForm("D", idClient));
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this, new ShowOrdersForm("D", idClient));
        }
    }
}
