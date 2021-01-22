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
    public partial class ShowItemsOrderForm : Form
    {
        string idClient { get; set; }
        string itemsOrder { get; set; }
        public ShowItemsOrderForm(string idClient,string itemsOrder)
        {
            this.idClient = idClient;
            this.itemsOrder = itemsOrder;
            InitializeComponent();
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            ChangeWindow change = new ChangeWindow(this, new ClientForm("C", idClient));
        }

        private void showItems_Click(object sender, EventArgs e)
        {
            string[] array = itemsOrder.Split(';');
            viewProducts.Items.Clear();
            foreach (var item in array)
            {
                string[] items = item.Split(',');
                var listView = new ListViewItem(items);
                viewProducts.Items.Add(listView);
            }
        }
    }
}
