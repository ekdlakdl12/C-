﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A078_AreaOfCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# 상수선언 - const double Pi = 3.141592;
            for(double r = 1; r<=10; r++) 
            {
                Console.Write("Area of circle with radius {0,2} = {1,7:F2}",r,AreaOfCircle(r));
            }
        }

        private static double AreaOfCircle(double r)
        {
            return Math.PI * r * r;
        }
    }
}