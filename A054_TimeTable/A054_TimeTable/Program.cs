using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A054_TimeTable
{
    internal class Program
    {
        static void Main(string[] args) //gugudan
        {
            for(int y = 1; y <= 9;  y++) // 1,2,3,4,5,6,7,8,9
            {
                Console.WriteLine();
                for (int x = 2; x <= 9; x++) //2.3.4.5.6.7.8.9
                    Console.WriteLine("{0} x {1} = {2,2}", y, x, y * x); // 2 * 1
                Console.WriteLine();
            }   
        }
    }
}
