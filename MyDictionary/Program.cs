using System;
using System.Collections;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string, string> keyValuePairs = new MyDictionary<string, string>();
            keyValuePairs.Add("laptop", "msi");
            keyValuePairs.Add("buzdolabı", "arçelik");
            keyValuePairs.Add("su ısıtıcısı", "kiwi");

            int i = 0;
            foreach (var key in keyValuePairs.Keys)
            {
                Console.WriteLine("{0}. key is: {1}", i + 1, key);
                i++;
            }

            Console.WriteLine();

            int j = 0;
            foreach (var value in keyValuePairs.Values)
            {
                Console.WriteLine("{0}. value is: {1}", j + 1, value);
                j++;
            }


            //MyList<string> sehirler2 = new MyList<string>();

            //sehirler2.Add("Ankara");
            //sehirler2.Add("İstabul");



        }


    }


}