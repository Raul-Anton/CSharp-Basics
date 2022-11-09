using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBasics
{
    internal abstract class Item
    {
        private int itemId;
        private string itemName;
        private float price;
        private static int quantity;

        public int ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
            }
        }

        public string ItemName
        {
            get
            {
                return itemName;
            }
            set
            {
                itemName = value;
            }
        }

        public float Price
        {
            get
            {
                return Price;
            }
            set
            {
                Price = value;
            }
        }

        public static int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public virtual void CheckStock()
        {
            Console.WriteLine("We have {0} products in store",quantity);
        }

        public virtual void CheckStock(int number)
        {
            if (quantity < number)
            {
                Console.WriteLine("Not enough products available!");
            }
            else
            {
                Console.WriteLine("Enough products available!");
            }    
        }

        public virtual void Bitterness()
        {
            Console.WriteLine("Which kind of tea are we talking about again?");
        }
    }
}
