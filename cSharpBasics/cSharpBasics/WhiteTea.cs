using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBasics
{
    internal class WhiteTea : Tea, ICloneable
    {
        public WhiteTea()
        {
            WhiteTea.Quantity++;
        }

        private WhiteTea whiteTea;

        public WhiteTea(WhiteTea whiteTea)
        {
            this.whiteTea = whiteTea;
            WhiteTea.Quantity++;
        }

        public object Clone()
        {
            return new WhiteTea(this);
        }
    }
}
