using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
   
    class MyDictionary<T1, T>
    {
        T1[] keys;
        T[] items;
        public MyDictionary()
        {
            keys = new T1[0];
            items = new T[0];
        }
        public void Add(T1 key, T item)
        {
            T1[] tempKeys = keys;
            T[] tempArray = items;

            items = new T[items.Length + 1];
            keys= new T1[keys.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
                keys[i] =  tempKeys[i];
            }
            items[items.Length - 1] = item;
            keys[keys.Length - 1] = key;
        }
    }
}
 