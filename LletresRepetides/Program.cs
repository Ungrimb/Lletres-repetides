using System;
using System.Collections.Generic;
using System.Linq;

namespace LletresRepetides
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Ismael Anaya Marquez";
            Name = Name.ToUpper();
            char[] chars = Name.ToCharArray();

            Dictionary<char, int> charName = new Dictionary<char, int>();
            Console.WriteLine("Original string: {0}", Name);
            Console.WriteLine("Add to Dictionary:");
            for (int ctr = 0; ctr < chars.Length; ctr++)
            {
                int n = (from c in Name where c == chars[ctr] select c).Count();
                //Console.WriteLine(n);
                try
                {
                    charName.Add(chars[ctr], n);
                }
                catch (ArgumentException) { }
            }
            foreach (var pair in charName)
            {
                Console.WriteLine("FOREACH VAR: {0}, {1}", pair.Key, pair.Value);
            }
        }
    }
}
