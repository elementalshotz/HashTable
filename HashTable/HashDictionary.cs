using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class HashDictionary<K, V> : IDictionary<K, V>
    {
        private HashDictionary<K, V> hashDictionary;

        public HashDictionary() {
            hashDictionary = new HashDictionary<K, V>();
        }

        public IEnumerator<KeyValuePair<K, V>> GetEnumerator() => hashDictionary.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) hashDictionary.GetEnumerator();
        }

        public void Add(KeyValuePair<K, V> item) => hashDictionary.Add(item);

        public void Clear() => hashDictionary.Clear();

        public bool Contains(KeyValuePair<K, V> item) => hashDictionary.Contains(item);

        public void CopyTo(KeyValuePair<K, V>[] array, int arrayIndex)
        {
            foreach (var item in hashDictionary)
            {
                array[arrayIndex] = item;
                arrayIndex++;
            }

        }

        public bool Remove(KeyValuePair<K, V> item) => hashDictionary.Remove(item);

        public int Count { get { return hashDictionary.Count; } }
        public bool IsReadOnly { get { return hashDictionary.IsReadOnly; } }

        public bool ContainsKey(K key) => hashDictionary.ContainsKey(key);

        public void Add(K key, V value) => hashDictionary.Add(key,value);

        public bool Remove(K key) => hashDictionary.Remove(key);

        public bool TryGetValue(K key, out V value) => hashDictionary.TryGetValue(key, out value);

        public V this[K key]
        {
            get => hashDictionary[key];
            set => hashDictionary[key] = value;
        }

        public ICollection<K> Keys { get; }
        public ICollection<V> Values { get; }
    }
}
