using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBasics
{
    internal class ItemArray : IEnumerable<Item>
    {
        private List<Item> _ItemArray = new List<Item>();

        public void Add(Item item)
        {
            _ItemArray.Add(item);
        }

        public IEnumerator<Item> GetEnumerator()
        {
            return _ItemArray.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Item this[int idx] => _ItemArray[idx];
        public int Count => _ItemArray.Count;
    }
}
