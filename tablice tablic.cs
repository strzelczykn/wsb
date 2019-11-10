using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablica_tablic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] tab = new int[][]
            {
                new int [] {1,2},
                new int []{3,4},
                new int [] {6},


            };

            /* Wyświetl zawartośc tablicy za pomocą dwóch pętli for*/

            for (int i = 0; i < tab.GetLength(0); i++) 
            {
                for (int j = 0; j < tab[i].Length; j++) 
                {
                    Console.Write("{0}", tab[i][j]);

                }
                Console.WriteLine();
            }
           
            Console.ReadLine();
        }
    }
}
