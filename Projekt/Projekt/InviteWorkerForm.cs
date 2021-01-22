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
    public partial class InviteWorkerForm : Form
    {
        Director director = new Director();
        string idClient;
        public InviteWorkerForm(string idClient)
        {
            InitializeComponent();
            this.idClient = idClient;
        }

        private void mainLableClick_Click(object sender, EventArgs e)
        {
            ChangeWindow change = new ChangeWindow(this,new DirectorForm("D",idClient));
        }

        private void inviteButton_Click(object sender, EventArgs e)
        {
            if (director.inviteWorker(emailField.Text))
                MessageBox.Show("Osoba została zatrudniona");
            else
                MessageBox.Show("Osoba nie została zatrudniona");
        }
    }
}
