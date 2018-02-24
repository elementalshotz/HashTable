using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class HashTable<V> : ICollection<V>, IEnumerable<V>
    {
        LinkedList<V> list;

        public HashTable()
        {
            list = new LinkedList<V>();
        }

        public int Count => list.Count;

        public bool IsReadOnly => FIsReadOnly(list.ToArray());

        bool FIsReadOnly(V[] checkList)
        {
            return checkList.IsReadOnly;
        }

        public void Add(V item)
        {
            list.AddFirst(item);
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(V item)
        {
            return list.Contains(item);
        }

        public void CopyTo(V[] array, int arrayIndex)
        {
            foreach (var item in list)
            {
                array[arrayIndex] = item;
                arrayIndex++;
            }
        }

        public IEnumerator<V> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public bool Remove(V item)
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
            return (IEnumerator) list.GetEnumerator();
        }
    }
}
