using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcje
{
    class Program
    {
        static void Main(string[] args)
        {
            //tworzenie funkcji 
            Add(2,3);
            Add(1, 2, 3);
            Console.WriteLine(  "Pole wynosi : {0}", SquareArea(4));
            Console.WriteLine("Wynik dodawania wynosi: {0}", Add (1));
            Console.WriteLine("Wynik dodawania wynosi: {0}", Add (1, d:3)); // 1 przypisze się do a , a do d przypisujemy 3
            Data("Janusz");
            Data("Janusz", age: 30); 
            Console.ReadKey();
        }

        static void Add(int a, int  b)
        {
            int result = a + b;
            Console.WriteLine("Wynik dodawania: {0}", result);


        }
        static void Add (int a, int b, int c)// funkcja z więkzą ilością argumentów 
            // void jest niezwracalny
        {
            int result = a + b +c ;
            Console.WriteLine("Wynik dodawania: {0}", result);

        }
        static int SquareArea(int a)
            // int jest zwracalny 
        {
            return a * a; // zwróć wartoś wyrażenia 
        }

        static int Add ( int a, int b=3, int c=2, int d = 1)

        {
            return a + b + c + d;
        }
        static  void Data (string name, string surname= "Nowak", int age = 20)
        {
            Console.WriteLine("Imię: {0}, nazwisko {1}, wiek: {2}", name, surname, age);

        }
    }
}
