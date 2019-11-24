using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funkcja_2_modulo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Napisz funkcję ktora wyświetli symę cyfr w liczbie.
            
            Console.WriteLine("Suma cyfr to: {0} " , Result(123));
            Console.ReadKey();


            

        }

        static int Result ( int x)
        {
            int result = 0;

           
            do
            {
                result = result + x % 10;
                x /= 10;
            }
            while (x !=0);
            
             
         
            return result;
        }
    }


}
