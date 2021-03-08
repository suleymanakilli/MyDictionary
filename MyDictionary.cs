using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key,TValue value)
        {
            TKey[] tmpKeys = keys;
            TValue[] tmpValues = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tmpKeys.Length; i++)
            {
                keys[i] = tmpKeys[i];
                values[i] = tmpValues[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public TValue FindValue(TKey key)
        {
            int index = 0;
            for(int i = 0; i < keys.Length; i++)
            {
                if (keys[i].Equals(key))
                {
                    index = i;
                    break;
                }
            }
            return values[index];
        }
    }
}
