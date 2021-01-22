using System;

namespace GenericsDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<double, string> notes = new MyDictionary<double, string>();

            Console.WriteLine(notes.Count);

            notes.Add(9.00, "toplantı");
            notes.Add(10.05, "proje başlangıcı");

            Console.WriteLine(notes.Count);



            for (int i = 0; i < notes.Count; i++)
            {
                Console.WriteLine(i + ". key = " + notes.Keys[i]);
            }

            for (int i = 0; i < notes.Count; i++)
            {
                Console.WriteLine(i + ". value = " + notes.Values[i]);
            }


            



        }
    }

    class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeys = keys;
            TValue[] tempValues = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }


        public int Count 
        { 
            get 
            {
                return keys.Length;
            }
        }


        public TKey[] Keys { get { return keys; } }
        public TValue[] Values { get { return values; } }
    }
}
