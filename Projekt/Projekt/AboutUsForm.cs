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
    public partial class AboutUsForm : Form
    {
        string idClient { get; set; }
        public AboutUsForm(string idClient)
        {
            this.idClient = idClient;
            InitializeComponent();
        }

        private void AboutUsForm_Load(object sender, EventArgs e)
        {

        }

        private void mainLableClick_Click(object sender, EventArgs e)
        {
            ChangeWindow change = new ChangeWindow(this,new ClientForm("C",idClient));
        }
    }
}
