using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem
{
    public class PhysicalProduct : Product
    {
        private double weight;

        public double Weight
        {
            get { return weight; }
            set
            {
                if (weight < 0)
                {
                    throw new ArgumentException("Weight cannot be less or equal to 0!");
                }
                weight = value;
            }
        }


        public PhysicalProduct(string name, double price, double weight) : base(name, price)
        {
            this.Weight = weight;
        }

        public override string ToString()
        {
            return $"Name: ${this.Name}\nPrice: ${this.Price}\nWeight: ${this.Weight}";
        }
    }
}
