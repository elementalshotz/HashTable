using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class HashTable<T> : ICollection<T>, IEnumerable<T>
    {
        T[] list;

        public int Count => list.Length;

        public bool IsReadOnly => list.IsReadOnly;

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            
        }

        public bool Contains(T item)
        {
            foreach (var t_item in list)
                if (t_item.Equals(item))
                    return true;

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
