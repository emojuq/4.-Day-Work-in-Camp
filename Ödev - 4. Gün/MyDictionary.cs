using System;
using System.Collections.Generic;
using System.Text;

namespace Ödev___4._Gün
{
    class MyDictionary<TKey,TValue >
    {
        TKey[] _key;
        TValue[] _value;
        public MyDictionary()
        {
            _key = new TKey[0];

            _value = new TValue[0];
        }

        public void Add( TKey key , TValue value)
        {
            TKey[] keyler = _key;
            TValue[] valueler = _value;

            _key = new TKey[_key.Length + 1];
            _value = new TValue[_value.Length + 1];

            for (int i = 0; i <keyler.Length; i++)
            {
                _value[i] = valueler[i];
                _key[i] = keyler[i];
            }

            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;

        }

        public int Count
        {
            get { return _key.Length; }
        }

        public TKey[] key
        {
            get { return _key; }
        }

        public TValue[] value
        {
            get { return _value; }
        }
      
            

    }
}
