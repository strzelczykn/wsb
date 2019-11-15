using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int oper;
            double a, b, wynik = 0;
            bool wybor;
            string operacja = "", stop;
            bool koniec = false;
            //Początek głównej pętli 
            do
            {

                Console.WriteLine("Program wykonuje podstawowe działania arytmetyczne na dwóch liczbach.");

                Console.WriteLine("Podaj pierwszą liczbę :");
                while (true)
                {
                    if (!double.TryParse(Console.ReadLine(), out a))
                        Console.WriteLine("Wprowadzono nie poprawną wartość");
                    else break;
                }

                Console.WriteLine("Podaj drugą liczbę:");
                while (true)
                {
                    if (!double.TryParse(Console.ReadLine(), out b))
                        Console.WriteLine("Wprowadzono nie poprawną wartość");
                    else break;
                }



                do
                {
                    while (true)
                    {
                        Console.WriteLine("1. Suma dwóch Liczb a i b ");
                        Console.WriteLine("2. Różnica dwóch Liczb a i b ");
                        Console.WriteLine("3. Iloczyn  dwóch Liczb a i b ");
                        Console.WriteLine("4. Iloraz dwóch  Liczb a i b ");
                        Console.WriteLine("5. Koniec programu");
                        Console.Write("Wybierz jedną z dozwolonych operacji <1;4> :");
                        if (!int.TryParse(Console.ReadLine(), out oper))
                            Console.WriteLine("Wprowadzono niepoprawną wartośc!");
                        else break;
                    }
                    wybor = true;
                    switch (oper)// porównanie kilku rzeczy jednej kategorii, rozbudowany if .. else 
                    {
                        case 1: wynik = a + b; operacja = "dodawania"; break;// gałęzie switch'a
                        case 2: wynik = a - b; operacja = "odejmowania"; break;
                        case 3: wynik = a * b; operacja = "mnożenia"; break;
                        case 4: wynik = a / b; operacja = "dzielenia"; break;
                        case 5: koniec = true; break;
                        default:// = dal pozostałych ... cos takiego jak else w if'ie 
                            Console.WriteLine("Wybrano niedostępną opcję!");
                            wybor = false; break;

                    }
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Wynik {0} liczb {1} i {2} to {3}. ", operacja, a, b, wynik);
                    }
                    Console.ForegroundColor = ConsoleColor.White; 
                    if (!koniec)
                    {
                        Console.WriteLine ("Czy zakończyć działanie programu tak/nie ?");
                        stop = Console.ReadLine();
                        if (stop == "tak") koniec = true;
                        else
                        {
                            koniec = false;
                            

                        }
                    }
                } while (!wybor);



            } while (!koniec); // Koniec pętli głównej= nie potrzeba console.readkey bo wszystko dziala w pętli do while 

        }
    }
}
