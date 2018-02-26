using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class HashDictionaryEnumerator<K,V> : IEnumerator<KeyValuePair<K,V>>
    {
        private KeyValuePair<K, V>[] listOfValuePairs;

        private int position = -1;

        public HashDictionaryEnumerator(KeyValuePair<K, V>[] list)
        {
            listOfValuePairs = list;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            position++;
            return (position < listOfValuePairs.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        public KeyValuePair<K,V> Current
        {
            get
            {
                try
                {
                    return listOfValuePairs[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
        

        object IEnumerator.Current => Current;
    }
}
