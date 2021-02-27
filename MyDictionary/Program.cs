using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary = new MyDictionary<string>();
            myDictionary.Add("Melek");
            myDictionary.Add("Ayşe");
            myDictionary.Add("Emine");
            myDictionary.Add("Fatma");
            myDictionary.Add("Ali");
            myDictionary.Add("Cın");
            myDictionary.Add("Biti");


            foreach (var item in myDictionary.Items)
            {
                Console.WriteLine(item);
            }

        }
    }
}


