using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    public class Dog : Pet
    {
        public string type2;
        public string name2;
        public string owner2;
        public double weight2;
        public Dog(string name, string owner, double weight) : base(string.Empty, name, owner, weight)
        {
            
            name = name2;
            owner = owner2;
            weight = weight2;
        }
        public string bark(int count)
        {
            string bark = "";
            for (int i = 0; i < count; i++)
            {
                bark = bark + "bark!";
            }
            return bark;
        }
    }
}
