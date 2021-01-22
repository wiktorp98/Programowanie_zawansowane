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
    public partial class ContactForm : Form
    {
        string idClient;
        public ContactForm(string idClient)
        {
            InitializeComponent();
            this.idClient = idClient;
        }

        private void mainLableClick_Click(object sender, EventArgs e)
        {
            ChangeWindow change = new ChangeWindow(this,new ClientForm("C", idClient));
        }
    }
}
