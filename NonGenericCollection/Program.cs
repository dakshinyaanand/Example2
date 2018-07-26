﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace NonGenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            a1.Add(12);
            a1.Add("hello world");
            a1.Add("c");
            Console.WriteLine("after add:");
            foreach (object t in a1) 
                Console.WriteLine(t);
            a1.Insert(0, "New Data");
            a1.Insert(2, "another data");
            Console.WriteLine("after insert:");
            foreach (object t in a1)
                Console.WriteLine(t);
            a1.Remove(12);
            a1.RemoveAt(2);
            Console.WriteLine("after remove:");
            foreach (object t in a1)
                Console.WriteLine(t);
            Console.Write("Specific data:" + a1[1]);

            Hashtable ht = new Hashtable();
            ht.Add("IN", "India");
            ht.Add("US", "America");
            ht.Add("UK", "United Kingdom");
            // ht.Add("IN", "bharath"); it throws runtime exception AS key has to be unique data
           IDictionaryEnumerator
                ide= ht.GetEnumerator();
            while (ide.MoveNext())
            {
                Console.WriteLine(ide.Key + ", " + ide.Value);
            }
            List<string> cities = new List<string>();
            cities.Add("Coimbatore");
            cities.Add("chennai");
            cities.Add("bengaluru");
            cities.Add("Mumbai");
            cities.Add("Kerala");
            foreach (string t in cities)
            {
                Console.WriteLine(t);
            }
            Dictionary<string, string> country = new Dictionary<string, string>();
            country.Add("IN", "India");
            country.Add("US", "America");
            country.Add("UK", "United Kingdom");
            foreach(KeyValuePair<string,string>kvp in country)
            {
                Console.WriteLine(kvp.Key + ", " + kvp.Value);
            }



        }
        
    }
}
