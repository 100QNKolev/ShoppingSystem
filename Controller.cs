using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem
{
    public class Controller
    {
        private List<Product> products { get; set; }
        private List<Receipt> recipes { get; set; }

        public Controller()
        {
            this.products = new List<Product>();
            this.recipes = new List<Receipt>();
        }

        public string ProcessProductCommand(List<string> args)
        {
            string name = args[0];
            double price = double.Parse(args[1]);
            double weight = double.Parse(args[2]);


            PhysicalProduct newProduct = new PhysicalProduct(name, price, weight);
            this.products.Add(newProduct);

            return $"The current customer has bought ${newProduct.Name}.";
        }

        public string ProcessServiceCommand(List<string> args)
        {
            string name = args[0];
            double price = double.Parse(args[1]);
            double time = double.Parse(args[2]);


            ServiceProduct newProduct = new ServiceProduct(name, price, time);
            this.products.Add(newProduct);

            return $"The current customer has applied for ${newProduct.Name} service.";
        }

        public string ProcessCheckoutCommand(List<string> args)
        {
            string name = args[0];

            Receipt receipt = new Receipt(name);

            this.products.ForEach(x => receipt.AddProduct(x));

            this.recipes.Add(receipt);

            double totalSum = 0;

            this.products.ForEach(x => totalSum += x.Price);

            this.products.Clear();

            return $"Customer checked out for a total of ${totalSum : D2}.";
        }

        public string ProcessInfoCommand(List<string> args)
        {
            string command = args[0];
            StringBuilder sb = new StringBuilder();

            if (command == "Customer")
            {
                double totalSum = 0;

                this.products.ForEach(x => totalSum += x.Price);

                sb.AppendLine("Current customer has:");
                sb.AppendLine($"Products: ${this.products.Count : D2}");
                sb.AppendLine($"Total Bill: ${totalSum : D2}");

            }
            else
            {
                sb.AppendLine("Receips: ");

                if (this.recipes.Count > 0)
                {
                    this.recipes.ForEach(x => sb.AppendLine(x.ToString()));
                }
                else
                {
                    sb.AppendLine("No receipts");
                }
            }

            return sb.ToString();
        }
        public string ProcessEndCommand()
        {
            return $"Total customers today: ${this.recipes.Count}";
        }
    }
}
