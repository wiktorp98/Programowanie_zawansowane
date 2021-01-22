using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    interface IWorker
    {
         void orders();

         void insertProducts(string name, float price, int amount);

         Person[] showClients();

         Items[] showProducts();

    }
}
