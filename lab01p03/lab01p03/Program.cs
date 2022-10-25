using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01p03
{
    internal class Program
    {
        static List<string> teksty = new List<string>();
        static void Main(string[] args)
        {
            string s = "";
            do
            {
                Console.Write("tekst: ");
                s = Console.ReadLine();
                if (s.Equals("")) break;
                teksty.Add(s);
            } while (true);
            wypisz();
            /*teksty.Sort();*/
            teksty.RemoveAt(1);
            teksty.Insert(3, "XXXXXXXX");
            Console.WriteLine();
            wypisz();
        }

        static void wypisz()
        {
 /*           foreach (string s in teksty)
            {
                Console.WriteLine(s);
            }*/
            for (int i = 0; i < teksty.Count; i++)
            { 
                Console.WriteLine(teksty[i]);
            }

        }
    }
}
