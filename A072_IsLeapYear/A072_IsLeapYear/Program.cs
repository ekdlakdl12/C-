using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace A072_IsLeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //2001~2100년 사이의 윤년을 찿는 알고리즘
         for (int year = 2001; year < 2100; year++) 
            {
               if (IsLeapYear(year)) 
                {
                    Console.WriteLine("{0}", year);
                Console.WriteLine();
                }
            }
        }

        //여기서 처리되서 위 for문의 if문으로 return됨
        private static bool IsLeapYear(int year) //자주 응용하는 연습하기
        {
            return year %4 == 0 && (year%100 != 0 || year % 400 == 0);
        }

    }
}
