﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A008_ConsoleWriteMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10이하의 소수: {0},{1},{2},{3}", 2, 3, 5, 7); // 확인해보니 순서바꾸기 가능함 

            string primes;
            primes = String.Format("10이하의 소수: {0},{1},{2},{3}", 2, 3, 5, 7);
            Console.WriteLine(primes);


        }
    }
}
