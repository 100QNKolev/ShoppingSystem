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
            this.products.Add(product);
            Console.WriteLine(() => {
                this.products.Sum(x => x.Price);
            }
            );
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Receipt of ${this.customerName}");
            sb.AppendLine($"Total Price: ${this.products.Sum(x => x.Price)}");

            foreach (var item in this.products)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}
