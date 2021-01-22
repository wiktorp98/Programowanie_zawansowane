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
    public partial class InsertNewProductForm : Form
    {
        Director director = new Director();
        string whoIs;
        string idClient;
        public InsertNewProductForm(string whoIs,string idClient)
        {
            InitializeComponent();
            this.whoIs = whoIs;
            this.idClient = idClient;
        }

        private void insertProduct_Click(object sender, EventArgs e)
        {
            director.insertProducts(nameField.Text,(float)PriceField.Value,(int)amountField.Value);
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
