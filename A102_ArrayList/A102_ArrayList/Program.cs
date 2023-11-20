﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A102_ArrayList // <--- List<T>컬렉션 쓰는게 효율이 좋음
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            Random r = new Random();

            PrintValues(a);

            for (int i = 0; i<10; i++)
                a.Add(r.Next(100));

            PrintValues(a);
            a.Sort();
            PrintValues(a);

            a.RemoveAt(3);
            PrintValues(a);

        }


        private static void PrintValues(ArrayList a)
        {
            Console.WriteLine("Print Values in ArrayList");
            Console.WriteLine("Count ={0}",a.Count);
            Console.WriteLine(" Capacity = {0}", a.Capacity); //적용 될수있는 요소의 수

            foreach (var i in a)
                Console.WriteLine(" {0}", i);
            Console.WriteLine();
        }

    }
}