using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBasics
{
    internal class BlackTea : Item
    {
        public override void Bitterness()
        {
            Console.WriteLine("This is quite bitter");
        }

        public override void CheckStock()
        {
            Console.WriteLine("We have {0} {1} in store", Quantity,"black teas");
        }

        public override void CheckStock(int number)
        {
            if (Quantity < number)
            {
                Console.WriteLine("Not enough black teas available!");
            }
            else
            {
                Console.WriteLine("Enough black teas available!");
            }
        }
    }
}
