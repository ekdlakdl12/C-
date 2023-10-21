using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A056_LoopPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(1)
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                  Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}
