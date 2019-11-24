using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funkcja_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            Console.WriteLine("Wartość zmiennej x przed wywołaniem funkcji Increment :{0}", x);
            Increment(ref x);
            Increment(ref x);






        }

        static void  Increment(ref int x)
        {
            x += 10;
            Console.WriteLine("Zmienna x wewnątrz funkcji: {0}", x);

        }
    }
}
