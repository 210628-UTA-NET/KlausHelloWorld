using System;
using System.Collections.Generic;

namespace HelloWord
{
    public class Collections
    {
        static List<string> strings = new List<string>();
       // static ArrayList<> arrays = new ArrayList<>();

        public static void CollectionMain()
        {
            Console.WriteLine("-- Collection Demo --");
            strings.Add("first element");
            strings.Add("second element");
            strings.Add("third element");

            //A way to go throungh a list
            foreach(string item in strings)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-- ArrayList Demo --");
        }
    }
}