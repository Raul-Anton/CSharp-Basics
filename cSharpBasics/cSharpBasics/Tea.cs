using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBasics
{
    internal abstract class Tea
    {
        private int _teaId;
        private string _teaName;
        private float _price;
        private static int _quantity;

        public int TeaId
        {
            get
            {
                return _teaId;
            }
            set
            {
                _teaId = value;
            }
        }

        public string TeaName
        {
            get
            {
                return _teaName;
            }
            set
            {
                _teaName = value;
            }
        }

        public float Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public static int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }

        public virtual void CheckStock()
        {
            Console.WriteLine("We have {0} tea products in store",_quantity);
        }

        public virtual void CheckStock(int number)
        {
            if (_quantity < number)
            {
                Console.WriteLine("Not enough products available!");
            }
            else
            {
                Console.WriteLine("Enough products available!");
            }
        }
    }
}
