using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBasics
{
    internal class GreenTea : Tea
    {
        public GreenTea()
        {
            GreenTea.Quantity++;
        }

        public override void CheckStock()
        {
            Console.WriteLine("We have {0} {1} in store", Quantity, "green teas");
        }

        public override void CheckStock(int number)
        {
            if (Quantity < number)
            {
                Console.WriteLine("Not enough green teas available!");
            }
            else
            {
                Console.WriteLine("Enough green teas available!");
            }
        }
    }
}
