using System;

namespace projekt_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zadania 02 Podstawy 

            //1 Napisz program sprawdzający, czy podana liczba jest parzysta czy nie.


            /* int x; 
             Console.WriteLine("Podaj liczbę :");
             x = int.Parse(Console.ReadLine());
             if ( x % 2 == 0 )
             {
                 Console.WriteLine("Twoja liczba jest parzysta");

             }
             else
             {
                 Console.WriteLine("Twoja liczba jest nie parzysta");
             }
             */

            //2 

            int a, b;
            float wynik;
            Console.WriteLine(" Program oblicza wartość wyrażenia ab/ a + b ");
            Console.WriteLine(" Podaj liczbę a :");
            a = int.Parse((Console.ReadLine()));
            Console.WriteLine("Podaj liczbę b: ");
            b = int.Parse(Console.ReadLine());
            wynik = (a * b) /( a + b);
            Console.WriteLine("Wynik działania to : {0}" , wynik);







            
            Console.ReadKey();
                    
                    

        }

        
    }
}
