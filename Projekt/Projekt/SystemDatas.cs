using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Projekt
{
    public static class SystemDatas
    {
        static  XmlSerializer serializer = new XmlSerializer(typeof(List<Entry>));
        public static void serialize()
        {
            List<Entry> entries = new List<Entry>(Basket.basket.Count);
            foreach (var item in Basket.basket.Keys) {
                entries.Add(new Entry(item,Basket.basket[item]));
            }
            using (FileStream stream = new FileStream("basket.xml",FileMode.Create,FileAccess.Write))
            {
                
                serializer.Serialize(stream, entries);
            }
        }

        public static void deserialize()
        {
            using (FileStream writer = new FileStream("basket.xml", FileMode.OpenOrCreate))
            {
                if (!isEmptyFile(writer)) {
                    writer.Position = 0;
                    List<Entry> entries = (List<Entry>)serializer.Deserialize(writer);
                    foreach (var items in entries)
                    {
                        Basket.basket.Add(items.Key, items.Item);
                    }
                }
            }
        }
        static private bool isEmptyFile(FileStream file)
        {
            if (file.Length <= 0)
            {
                return true;
            }
            return false;
        }


        public static void returnToMain(Form form,string whoIs,string idClient) {
            if (whoIs == "D")
            {
                ChangeWindow change = new ChangeWindow(form, new DirectorForm("D",idClient));
            }
            else
            {
                ChangeWindow change = new ChangeWindow(form, new WorkerForm("W",idClient));
            }
        }
        static public Form logIn(string whoIs, string id)
        {
            Dictionary<string, Form> logedIn = new Dictionary<string, Form>()
            {
                { "C", new ClientForm("C",id) },
                { "W", new WorkerForm("W",id) },
                { "D", new DirectorForm("D",id) }
            };
            return logedIn[whoIs];

        }
    }
}
