using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace LletresRepetides
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "ismael ana8ya marquez";
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;
            List<char> chars = new List<char>(Name);
            Console.WriteLine("Original string: {0}", Name);
            Console.WriteLine("Character array:");
            foreach (char c in chars)
            {
                bool isVocal = false;
                foreach (char v in vocales)
                {
                    if (v == c) isVocal = true;
                }
                if (char.IsNumber(c)) Console.WriteLine("   {0}: {1}  Els noms de persones no contenen números!", count, c);
                if (isVocal) Console.WriteLine("   {0}: {1}  VOCAL", count, c);
                else if (!char.IsNumber(c)) Console.WriteLine("   {0}: {1}", count, c);
                count++;
            }
        }
    }
}
