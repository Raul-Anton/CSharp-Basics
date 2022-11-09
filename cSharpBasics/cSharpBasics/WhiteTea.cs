using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBasics
{
    internal class WhiteTea : Item, ICloneable
    {
        public WhiteTea()
        {

        }

        private WhiteTea whiteTea;

        public WhiteTea(WhiteTea whiteTea)
        {
            this.whiteTea = whiteTea;
        }

        public object Clone()
        {
            return new WhiteTea(this);
        }
    }
}
