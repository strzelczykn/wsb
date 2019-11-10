using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablice 
{
    class Program
    {
        static void Main(string[] args)
        {
        int[] tab = new int[5]/* jeśli nie podamy liczb w nawiasach klamrowych bedzie wyświetlała zera*/ { 10, 20, 30, 40, 50 };
        Console.WriteLine(tab[1]);// wyświetli tablicę 
        Console.WriteLine("Rozmiar tablicy, {0}", tab.Length);

        int elem = 0;// inicjacja zmiennej element 

        for (int i = 0; i < 5; i++) 
        {
            elem = i + 1;
            Console.WriteLine("element {1}: {0}", tab[i], elem);

        }
            Console.Clear();// czyszczenie poprzedniego
            /*foreach (var item in collection)// foreach +tab
            {

            }*/
            elem = 1;
            foreach (int item in tab)
            {
                Console.WriteLine("element {1}: {0}", item, elem);
                elem++;
            }


            Console.Clear();

            /* Użytkownik podaje z klawiatury swoje 3 ulubione kolory 
             * przypisz je do tablicy o nazwie colors a następnie wyświetli na ekranie 
             * w formacie 
             * Kolor 1...
             * Kolor 2 ...
             * Kolor 3...
             * Do przypisania kolorów do tablicy wykorzystaj petle for
             * Do wyświetlenia kolorów użyj pętlę while 
             */

            string[] colors = new string[3];
            string color;
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine("Podaj kolor:");
                color = Console.ReadLine();
                colors[i] = color;
            }
            Console.WriteLine();

            uint index = 0, count ;
            while (index < colors.Length) 
            {
                
                count = index + 1;

                Console.WriteLine(colors[index]);
                Console.WriteLine("Kolor{1}: {0}", colors[index], count);
                index++;
                
              
            }







            /*

            string Kolor;
             for (string)

            
            Console.WriteLine("Podaj trzy ulubione kolory: ");
            Console.ReadLine();
           
                if (double.TryParse(Console.ReadLine(), ) ;*/


               









                    Console.ReadKey();

        }
    }
}
