using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HashTable
{
    class HashDictionary<K, V> : IDictionary<K, V>
    {
        LinkedList<KeyValuePair<K, V>>[] hashDictionary;
        private int Size;


        public HashDictionary(int size)
        {
            hashDictionary = new LinkedList<KeyValuePair<K, V>>[size];

            Size = size;
        }

        private int HashKey(K key) => Math.Abs(key.GetHashCode()) % this.Size;

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        public V Find(K key)
        {
            var hash = this.HashKey(key);

            if (this.hashDictionary[hash] == null)
            {
                return default(V);
            }

            var collection = this.hashDictionary[hash];

            return collection.First(item => item.Key.Equals(key)).Value;
        }

        public void Add(KeyValuePair<K, V> item)
        {
            Add(item.Key, item.Value);
        }

        public void Clear()
        {
            foreach (var linkedList in hashDictionary)
            {
                if (linkedList != null)
                    linkedList.Clear();
            }
        }

        public bool Contains(KeyValuePair<K, V> item)
        {
            var hash = this.HashKey(item.Key);

            if (this.hashDictionary[hash] == null)
            {
                return false;
            }

            var collection = this.hashDictionary[hash];

            return collection.Any(pair => pair.Key.Equals(item.Key));

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

        public bool Remove(KeyValuePair<K, V> item)
        {
            var hash = this.HashKey(item.Key);

            if (this.hashDictionary[hash] == null)
            {
                return false;
            }

            var collection = this.hashDictionary[hash];

            return collection.Any(pair => pair.Key.Equals(item.Key));

        }

        public int Count { get; private set; }



        public bool IsReadOnly { get; }

        public bool ContainsKey(K key)
        {
            var hash = this.HashKey(key);

            if (this.hashDictionary[hash] == null)
            {
                return false;
            }

            var collection = this.hashDictionary[hash];

            return collection.Any(pair => pair.Key.Equals(key));
            
        }

        public void Add(K key, V value)
        {
            var hash = this.HashKey(key);

            var keyValuePair = new KeyValuePair<K, V>(key, value);

            if (this.hashDictionary[hash] == null)
            {
                this.hashDictionary[hash] = new LinkedList<KeyValuePair<K, V>>();
                this.hashDictionary[hash].AddFirst(keyValuePair);
                Count++;
                return;
            }

            this.hashDictionary[hash].AddLast(keyValuePair);
            Count++;

        }

        public bool Remove(K key)
        {
            bool exists = ContainsKey(key);

            if (exists)
            {
                foreach (var linkedList in hashDictionary)
                {
                    if (linkedList != null)
                    {
                        foreach (var item in linkedList)
                        {
                            if (item.Key.Equals(key))
                            {
                                hashDictionary[HashKey(key)].Remove(item);
                            }
                        }
                    }
                }

                return true;
            }

            return false;
        }

        public bool TryGetValue(K key, out V value)
        {
            value = Find(key); // Vet ej vad som händer om funktionen inte hittar nyckeln.
            return true;
        }

        public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
        {
            foreach (var collection in this.hashDictionary)
            {
                if (collection != null)
                {
                    foreach (var value in collection)
                    {
                        yield return value;
                    }
                }
            }
        }

        public V this[K key]
        {
            get
            {
                V v;
                TryGetValue(key, out v);
                return v;
            }
            set
            {
                V v;
                TryGetValue(key, out v);
                v = value;
            }
        }

        public ICollection<K> Keys { get; }
        public ICollection<V> Values { get; }
    }
}
