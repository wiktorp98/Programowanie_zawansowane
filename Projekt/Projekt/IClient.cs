using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    interface IClient
    {
        List<Items> showProducts();
        void addProducts(int id, string name, float price, int amount, string IDClient);
        void order();
        void showLastOrders();
        List<Items> showBasket(string id);
    }
}
