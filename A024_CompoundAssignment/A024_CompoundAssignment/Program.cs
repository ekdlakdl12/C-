using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A024_CompoundAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine()); // x값을 인트값으로 받기

            Console.WriteLine(x += 2);
            Console.WriteLine(x -= 2);
            Console.WriteLine(x *= 2);
            Console.WriteLine(x /= 2);
            Console.WriteLine(x++);
            Console.WriteLine(--x);
        }

    }
}
