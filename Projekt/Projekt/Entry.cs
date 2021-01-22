using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Entry
    {
        public string Key;
        public List<Items> Item;

        public Entry() {

        }

        public Entry(string key, List<Items> item)
        {
            Key = key;
            this.Item = item;
        }
    }
}
