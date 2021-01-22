using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        

        static void Main(string[] args)
        {

            Dictionary<double, string> times = new Dictionary<double, string>();
            Console.WriteLine(times.Count);

            

            times[1.36] = "toplanti";

            Console.WriteLine(times.Count);

            MyDictionary<string,string> cities = new MyDictionary<string,string>();
            Console.WriteLine(cities.Count);

            cities.Add("asd", "Adana");
            cities.Add("asd", "Adıyaman");
            cities["aaa"] = "www";

            Console.WriteLine(cities.Count);

            //foreach (var item in cities.Keys)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in cities.Values)
            //{
            //    Console.WriteLine(item);
            //}









        }
    }

    class MyDictionary<TKey, TValue>
    {
        List<TKey> keys;
        List<TValue> values;     

        public MyDictionary()
        {
            keys = new List<TKey>();
            values = new List<TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            keys.Add(key);
            values.Add(value);
        }

        public int Count
        {
            get
            { 
                return keys.Count;
            }
        }


        //public List<TKey> Keys
        //{
        //    get { return keys; }
        //}

        //public List<TValue> Values
        //{
        //    get { return values; }
        //}


        public List this[TKey key]
        {
            get
            {
                return this[key];

            }
            set
            {
                this[key] = value;
                
            }
        }


    }


}
