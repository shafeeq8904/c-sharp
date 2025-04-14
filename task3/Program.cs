using System;
using System.Collections.Generic;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("shafeeq");
            names.Add("karthik");
            names.Add("srinivas");;

            Console.WriteLine("names in the list: and convert to upper case");
            foreach (string name in names)
            {
                Console.WriteLine(name.ToUpper());
            }

            Console.WriteLine("names in the list: and convert to lower case");
            foreach (string name in names)
            {
                Console.WriteLine(name.ToLower());
            }

            names.Remove("srinivas");

            Console.WriteLine("remove the name from the  list:");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}