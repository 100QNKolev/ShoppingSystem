using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem
{
    public class Receipt
    {
        private string customerName;
        private List<Product> products;

        public string CustomerName
        {
            get { return customerName; }
            set
            {
                if (value.Length < 2 || value.Length > 40)
                {
                    throw new ArgumentException("Customer Name should be between 2 and 40 characters!");
                }
                customerName = value;
            }
        }

        public Receipt(string customerName)
        {
            this.CustomerName = customerName;
        }

        public void AddProduct(Product product) 
        {
          //TODO: create AddProduct function
        }

        public override string ToString()
        {
            return base.ToString();
            //TODO: create ToString function
        }
    }
}
