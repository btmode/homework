using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class Tasks
    {
        public static void Start() 
        {
            var s = "abcabcabcabcabcabcabcabcabcabc"; // 30
            string[] names = ["alex", "mike", "kate", "john", "bob", "jane"];
            // name:name length
            // { "alex": 4, "mike": 4, ... }
            var dictionary = new Dictionary<string, int>();

            int count = 0;
            foreach (var name in names)
            {
                Console.WriteLine($"name = {name}, length = {name.Length}");
                dictionary[name] = name.Length;
            }

            var input = Console.ReadLine();
            Console.Write(dictionary[input]);

        }
    }
}
