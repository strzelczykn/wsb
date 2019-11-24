using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcje_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {



            /* Napisz program, który sprawdza czy liczba podana przez użytkownika jest parzysta/ nie parzysta, napisz funkcję, 
             * która  przyjmuje jako argument liczbę całkowitą podaną przez użytkownika z klawiatury
             * */
             
            int a;
            Console.WriteLine("Podaj liczbę całkowitą : ");
            a = int.Parse(Console.ReadLine());
            Add(a);
            Console.ReadKey();
              

        }

        static void Add (int a)
        {


            
            if (a% 2 == 0)
                  Console.WriteLine("Twoja liczba jest parzysta");
                else
                    Console.WriteLine("Twoja liczba jest nie parzysta");
            
        }

        




        
    }
}
