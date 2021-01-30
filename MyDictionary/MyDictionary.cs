using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<tKey, tValue>
    {
        tKey[] keys;
        tValue[] values;

        //constructor
        public MyDictionary()
        {
            keys = new tKey[0];
            values = new tValue[0];
        }

        public void Add(tKey key, tValue value)
        {
            tKey[] tempKey = keys;
            tValue[] tempValue = values;

            keys = new tKey[keys.Length + 1];
            values = new tValue[values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
            }

            for (int i = 0; i < tempValue.Length; i++)
            {
                values[i] = tempValue[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }

        public tKey[] Keys
        {
            get { return keys; }
        }

        public tValue[] Values
        {
            get { return values; }
        }

    }

}

