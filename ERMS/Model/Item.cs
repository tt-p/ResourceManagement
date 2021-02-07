using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_Group_27.ERMS.Model
{
    public class Item
    {
        public int Id;
        public string Name;
        public string Catagory;
        public Dictionary<String, String> Attributes;

        public Item() { }

        public Item(int Id, string Name, string Catagory, Dictionary<String, String> Attributes)
        {
            this.Id = Id;
            this.Name = Name;
            this.Catagory = Catagory;
            this.Attributes = Attributes;
        }

        public override string ToString()
        {
            string atts = "";

            foreach (string att in Attributes.Keys)
            {
                atts += $"({att} = {Attributes[att]}) ";
            }

            return $"{Id} | {Name} | {Catagory} | {atts}";
        }

    }
}
