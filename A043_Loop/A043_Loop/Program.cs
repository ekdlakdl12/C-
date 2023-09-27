using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A043_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 ~ 100 까지 합
            int sum = 0;
            
            for(int i = 1; i <= 100; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("1~100까지의 합은 {0}이다",sum);

            //1에서 100까지 홀수의 합을 구하는 로직
            int sum2 = 0;

            for (int x = 1; x <= 100; x++) 
            {
                if (x % 2 != 0)
                    sum2 = sum2 + x;
            }
            Console.WriteLine("1~100중에 홀수의 합은? {0}",sum2);

            // 1+1 2+1 3+....1/ 100을 구하는 프로그램 _역수의합

            double sum3 = 0;
            for (int x = 1; x<=100; x++)
            {
                sum3 = sum3 + 1.0 / x;
            }
            Console.WriteLine("1에서 100까지 역수의 합은 {0}",sum3);
            
        }
    }
}
