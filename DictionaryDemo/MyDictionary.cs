using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
    class MyDictionary<Tvalue, Tkey>
    {
        Tkey[] keys;
        Tvalue[] values;
        public MyDictionary()
        {
            values = new Tvalue[0];
            keys = new Tkey[0];
        }

        public void Add(Tkey sıralamaItem, Tvalue burcItem)
        {

            Tkey[] tempKeys = keys;    // keys'in önceki değerlerini sakladık
            Tvalue[] tempValues = values;

            keys = new Tkey[keys.Length + 1];    // yeni keys oluşturduk

            values = new Tvalue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = sıralamaItem;  // son index'i parametre olarak verdiğimiz değere eşitledik.
            values[values.Length - 1] = burcItem;
        }

        public int Length
        {
            get { return keys.Length; }
        }

        public Tkey[] Keys
        {
            get { return keys; }
        }

        public Tvalue[] Values
        {
            get { return values; }
        }

    }
}
