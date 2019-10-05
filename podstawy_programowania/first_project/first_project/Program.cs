using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("imie: ");// wyświetli imię
            Console.WriteLine("Janusz");
            /* komentarz
             * w
             * wielu liniach
             *
             */


            /*
             * #
             * ##
             * ###
             */
            Console.WriteLine("*");
            Console.WriteLine("**");
            Console.WriteLine("***");

            string name;
            name = "anna";
            Console.WriteLine(name);
            Console.WriteLine(name);
            Console.WriteLine("Masz na imię:" + name);
            Console.WriteLine("masz na imię:{0}",name);
            int age = 20;
            Console.WriteLine("Masz na imię: {0}, wiek: {1}", name, age);
            sbyte age1 = 20;



            Console.ReadKey();
        }
    }
}
