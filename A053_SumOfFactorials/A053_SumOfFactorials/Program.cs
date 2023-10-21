using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A053_SumOfFactorials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++) //n까지 반복
            {
                int fact = 1;
                for (int j = 2; j <= i; j++) // 팩토리얼 구하는곳
                {
                    fact *= j;
                }
                sum += fact;
                Console.WriteLine("{0,2}! = {1,10:#,#}", i, fact);
            }
                Console.WriteLine("1! + 2! + ... + {0}! = {1:N0}\n", n , sum);
        }
    }
}
