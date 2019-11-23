using System;

namespace wyznaczanie_liczb_pierwszych
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, dzielnik = 0, Liczba = 0;
            string we, koniec;
            do
            {   
            
             while (true)
                { 



                Console.WriteLine("Podaj liczbę");
                we = Console.ReadLine();
                try
                {

                    Liczba = int.Parse(we);
                    break;
                }

                catch (FormatException)
                {
                    Console.WriteLine("Wprowadzono liczbę w złym formacie");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem");
                }
                catch (ArgumentNullException) // ^Z
                {
                    Console.WriteLine("Napotkano koniec strumienia");
                }
                Console.WriteLine("Spróbuj jeszcze raz");
                }
            //koniec wprowadzania liczby

            // deklaracja tablicy 
            bool[] sito = new bool[Liczba + 1];
            for (int i = 0; i <= Liczba; i++)
                sito[i] = true;
            // sito eratostenesa
            for (int i = 2; i <= Liczba; i++)
            {
                if (sito[i])
                {
                    x = i;
                    x = x + i;
                    while (x <= Liczba)
                    {
                        sito[x] = false;
                        if (x == Liczba)
                            dzielnik = i; // ustawienie dzielnika
                        x = x + i;
                    }
                    if (dzielnik > 1) break;


                }


            }
            if (sito[Liczba]) Console.WriteLine("Liczba{0} to liczba pierwsza", Liczba);
            else Console.WriteLine("Liczba {0} to liczba złożoną podzielną przez {1}", Liczba, dzielnik);
            Console.Write("Czy zakończyć t/n?");
            koniec = Console.ReadLine();
        } while (koniec =="n");
        
            
            //wyświetlenie liczb pierwszych
            /* for (int i = 1; i <= Liczba; i++)
                 if (sito[i]) Console.Write(i + " ");
                 */



            

        }
    }
}
