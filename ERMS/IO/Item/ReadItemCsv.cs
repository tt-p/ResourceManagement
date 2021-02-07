using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FP_Group_27.ERMS.Model;

namespace FP_Group_27.IO
{
    class ReadItemCsv: IReadItemStrategy
    {
        private string _path;
        public ReadItemCsv(String path)
        {
            _path = path;
        }
        public IList<Item> Read()
        {
            IList<Item> items = new List<Item>();

            using (StreamReader reader = File.OpenText(_path))
            {
                string line;
                while ((line = reader.ReadLine()) != null & line != "")
                {
                    string[] tokens = line.Split(',');
                    int id = Convert.ToInt32(tokens[0]);
                    string name = tokens[1];
                    string catagory = tokens[2];

                    Dictionary<string, string> dict = new Dictionary<string, string>();

                    if (tokens.Length > 3)
                    {
                        for (int i = 3; i < tokens.Count(); i++)
                        {
                            string[] atts = tokens[i].Split('/');
                            dict.Add(atts[0], atts[1]);
                        }
                    }

                    items.Add(new Item(id, name, catagory, dict));
                }
            }

            return items;
        }
    }
}
