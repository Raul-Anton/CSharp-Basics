using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBasics
{
    internal class TeaArray : IEnumerable<Tea>
    {
        private List<Tea> TeaArr = new List<Tea>();

        public void Add(Tea tea)
        {
            TeaArr.Add(tea);
        }

        public IEnumerator<Tea> GetEnumerator()
        {
            return TeaArr.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Tea this[int idx] => TeaArr[idx];
        public int Count => TeaArr.Count;
    }
}
