using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HashTable
{
    class HashDictionary<K, V> : IDictionary<K, V>
    {
        LinkedList<KeyValuePair<K, V>>[] hashDictionary;
        int Size;

        public HashDictionary(int size)
        {
            hashDictionary = new LinkedList<KeyValuePair<K, V>>[size];
            Size = size;
        }

        IEnumerator IEnumerable.GetEnumerator() {
            KeyValuePair<K,V>[] items = new KeyValuePair<K,V>[Size];
            CopyTo(items, 0);

            return (IEnumerator) new HashDictionaryEnumerator(items);
        }

        public void Add(KeyValuePair<K, V> item)
        {
            int index = HashIndex(item.Key.GetHashCode());

            hashDictionary[index].AddLast(new LinkedListNode<KeyValuePair<K, V>>(item));
        }

        public void Clear()
        {
            foreach (var linkedList in hashDictionary)
            {
                linkedList.Clear();
            }
        }

        public bool Contains(KeyValuePair<K, V> item)
        {
            foreach (var linkedList in hashDictionary)
            {
                foreach (var listItem in linkedList)
                {
                    if (listItem.Key.Equals(item.Key))
                        return true;
                }
            }

            return false;
        }

        public void CopyTo(KeyValuePair<K, V>[] array, int arrayIndex)
        {
            foreach (var linkedList in hashDictionary)
            {
                foreach (var item in linkedList)
                {
                    array[arrayIndex] = item;
                    arrayIndex++;
                }
            }
        }

        public bool Remove(System.Collections.Generic.KeyValuePair<K, V> item)
        {
            if (Contains(item))
            {
                int index = HashIndex(item.Key.GetHashCode());
                hashDictionary[index].Remove(new LinkedListNode<KeyValuePair<K, V>>(item));
                return true;
            }

            return false;
        }

        public int Count { get { return hashDictionary.Length; } }
        public bool IsReadOnly { get; }

        public bool ContainsKey(K key)
        {
            foreach (var linkedList in hashDictionary)
            {
                foreach (var item in linkedList)
                {
                    if (item.Key.Equals(key))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public void Add(K key, V value) => hashDictionary[HashIndex(key.GetHashCode())].AddLast(new LinkedListNode<KeyValuePair<K,V>>(new KeyValuePair<K, V>(key, value)));

        public bool Remove(K key)
        {
            bool exists = ContainsKey(key);

            if (exists)
            {
                foreach (var linkedList in hashDictionary)
                {
                    foreach (var item in linkedList)
                    {
                        if (item.Key.Equals(key))
                        {
                            hashDictionary[HashIndex(key.GetHashCode())].Remove(new LinkedListNode<KeyValuePair<K, V>>(item));
                        }
                    }
                }

                return true;
            }

            return false;
        }

        public bool TryGetValue(K key, out V value)
        {
            foreach (var linkedList in hashDictionary)
            {
                foreach (var item in linkedList)
                {
                    if (item.Key.Equals(key))
                    {
                        value = item.Value;
                        return true;
                    }
                }
            }

            throw new A
        }

        public IEnumerator<System.Collections.Generic.KeyValuePair<K, V>> GetEnumerator() => hashDictionary.GetEnumerator();

        public V this[K key]
        {
            get => hashDictionary[key];
            set => hashDictionary[key] = value;
        }

        public ICollection<K> Keys { get; }
        public ICollection<V> Values { get; }

        public int HashIndex(int hash) => hash % hashDictionary.Length;
    }
}
