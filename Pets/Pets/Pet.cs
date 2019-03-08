using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    public class Pet
    {
        public string type;
        public string name;
        public string owner;
        public double weight;
        public Pet(string type2, string name2, string owner2, double weight2)
        {
            type = type2;
            name = name2;
            owner = owner2;
            weight = weight2;
        }
        public string getTag()
        {
            return "If lost, call " + owner;
        }
    }
}
