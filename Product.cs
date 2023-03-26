using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem
{
    public abstract class Product
    {
        private string name;
        private double price;

        public string Name
        {
            get { return name; }
            set { 
                if (value.Length < 3 || value.Length > 30) 
                {
                    throw new Exception("Name must be between 3 and 30 characters");
                }
                name = value;
            }
        }

        public double Price
        {
            get { return price; }
            set { 
                if (price < 0) 
                {
                    throw new Exception("Price must be positive integer");
                }
            price = value;
            }
        }

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            return base.ToString();
            //TODO: create ToString method
        }
    }
}
