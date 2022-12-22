using System;
using System.Linq;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            int[] mala_slova = new int[26];
            int[] velika_slova = new int[26];
            while ((s = Console.ReadLine()) != null)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (char.IsLetter(s[i]))
                    {
                        if (char.IsUpper(s[i]))
                        {
                            int redni_broj_slova = s[i] - 'A';
                            velika_slova[redni_broj_slova] += 1;
                        }
                        else
                        {
                            int redni_broj_slova = s[i] - 'a';
                            mala_slova[redni_broj_slova] += 1;
                        }
                    }
                }
            }

            int maks_mala = mala_slova.Max();
            if (maks_mala > 0)
            {
                for (int i = 0; i < mala_slova.Length; i++)
                    if (mala_slova[i] == maks_mala)
                        Console.Write((char)('a' + i));
                Console.WriteLine();
            }
                        
            int maks_velika = velika_slova.Max();
            if (maks_velika > 0)
            {
                for (int i = 0; i < mala_slova.Length; i++)
                    if (velika_slova[i] == maks_velika)
                        Console.Write((char)('A' + i));

            }
        }
    }
}