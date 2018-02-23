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
        LinkedList<T> list;

        public HashTable()
        {
            list = new LinkedList<T>();
        }

        public int Count => list.Count;

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            list.AddFirst(item);
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(T item)
        {
            return list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public bool Remove(T item)
        {
            if (Contains(item) == true)
            {
                list.Remove(item);
                return true;
            }
            return false;

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
