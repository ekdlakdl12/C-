﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A060_ArraySorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Mouse", "Cow", "Tiger", "Rabiit", "Dragon", "Snake", "Horse" };

            PrintArray ("Brfore Sort: ",name); //PrintArray는 밑에 따로 메소드를 만들어야함

            Array.Reverse (name);
            PrintArray("After Reverse: ", name);

            Array.Sort (name);
            PrintArray("After Sort", name);

            Array.Reverse (name);
            PrintArray("After Reverse:", name);

        }
        private static void PrintArray(string s,  string[] name)
        {
            Console.WriteLine(s);
            foreach(var n in name)
                Console.WriteLine("{0}",n);
            Console.WriteLine();
        }

    }
}
