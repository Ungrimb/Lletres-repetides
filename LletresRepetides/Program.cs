using System;

namespace LletresRepetides
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Ismael Anaya Marquez";
            char[] chars = Name.ToCharArray();
            Console.WriteLine("Original string: {0}", Name);
            Console.WriteLine("Character array:");
            for (int ctr = 0; ctr < chars.Length; ctr++)
            {
                Console.WriteLine("   {0}: {1}", ctr, chars[ctr]);
            }
        }
    }
}
