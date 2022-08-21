using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryStructure
{
    class MyDictionary<Key,Value>
    {
        Key[] keys;
        Value[] values;
        public MyDictionary()
        {
            keys = new Key[0];
            values = new Value[0];
        }
        public void Add(Key key,Value value)
        {
            Key[] tempKeyArray = keys;
            keys = new Key[keys.Length+1];
            Value[] tempValueArray = values;
            values = new Value[values.Length + 1];
            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                keys[i] = tempKeyArray[i];
                values[i] = tempValueArray[i];

            }
            keys[keys.Length-1] = key;
            values[values.Length-1] = value;

        }
        public int Length
        {
            get { return keys.Length; }
        }
    }
}
