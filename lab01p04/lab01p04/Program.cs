using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01p04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] tab = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> lista = new List<int>(tab);*/

            List<int> lista = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }
        }
    }
}
