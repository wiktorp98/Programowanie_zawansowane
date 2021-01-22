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
    public partial class ClientForm : Form
    {
        string whoIs;
        public string idClient { get; set; }
        ChangeWindow change;
        public ClientForm(string whoIs, string idClient)
        {

            this.whoIs = whoIs;
            this.idClient = idClient;
            InitializeComponent();
        }

        private void logOutClick_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this, new LoginForm());
        }

        private void aboutUsButton_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this, new AboutUsForm(idClient));
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this, new ShowProductsClientForm(idClient));
        }

        private void contactButton_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this, new ContactForm(idClient));
        }

        private void basketButton_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this, new BasketForm(idClient));
        }

        private void baksetLableButton_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this, new BasketForm(idClient));
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this, new HistoryForm(idClient));
        }
    }
}
