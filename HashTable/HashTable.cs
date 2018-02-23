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
        LinkedList<T>[] list;
        int Size;

        public HashTable(int size)
        {
            Size = size;
            list = new LinkedList<T>[Size];
        }

        public int Count => list.Length;

        public bool IsReadOnly => list.IsReadOnly;

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            foreach (var item in list)
            {
                Remove(item);
            }
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
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
            return this.GetEnumerator();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
