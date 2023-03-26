using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem
{
    public class ServiceProduct : Product
    {
        private double time;

        public double Time
        {
            get { return time; }
            set {
                if (time < 0)
                {
                    throw new ArgumentException("Time should be greater than 0!");
                }
                time = value;
            }
        }


        public ServiceProduct(string name, double price, double time) : base(name, price)
        {
            this.Time = time;
        }

        public override string ToString()
        {
            return base.ToString();
            //TODO: create ToString function
        }
    }
}
