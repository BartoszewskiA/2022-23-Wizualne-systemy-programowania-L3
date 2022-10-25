using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01p02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[20];

            Random r = new Random();
            
            for (int i=0; i<20; i++)
            {
                tab[i] = r.Next(-100,100);
            }

            foreach(int i in tab)
            {
                Console.Write(i +" ");
            }
            Console.WriteLine("max=" + tab.Max());
            Array.Sort(tab);
            Console.WriteLine();
            foreach (int i in tab)
            {
                Console.Write(i + " ");
            }
        }
    }
}
