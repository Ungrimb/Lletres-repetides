using System;

namespace LletresRepetides
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Ismael";
            string SurName = "Anaya";
            char[] charName = Name.ToCharArray();
            char[] charSurName = SurName.ToCharArray();

            string FullName = Name + " " + SurName;
            char[] charFullName = FullName.ToCharArray();

            for (int ctr = 0; ctr < charFullName.Length; ctr++)
            {
                Console.WriteLine("   {0}: {1}", ctr, charFullName[ctr]);
            }
        }
    }
}
