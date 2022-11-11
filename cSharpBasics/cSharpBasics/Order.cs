using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBasics
{
    internal class Order
    {
        private int OrderId { get; set; }

        private int CustomerId { get; set; }

        private string Status { get; set; }

        private Tea[] Teas { get; set; }


        public void GetStatus()
        {

        }
    }
}
