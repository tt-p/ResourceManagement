using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_Group_27.ERMS.Model
{
    class Depot
    {

        public int Id;
        public string Name;
        public string Size;
        public int Occupancy;
        public string Address;

        public Depot() { }

        public Depot(int id, string name, string size, int occupancy, string address)
        {
            Id = id;
            Name = name;
            Size = size;
            Occupancy = occupancy;
            Address = address;
        }
    }
}
