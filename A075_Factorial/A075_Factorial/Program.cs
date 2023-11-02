using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A075_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i<=10; i++) 
            {
                sum += Factorial(i); // Factorial 함수에서 계산된 값이 합계에 들어가고 출력됨
                Console.WriteLine("{0}! : {1,10:N0}",i,Factorial(i)); // N0 <-- 콤마 표시 숫자는 몇칸마다 콤마로 자를지 설정
            }
            Console.WriteLine("1!~10!의 합= {0,8:N0}", sum);
        }

        private static int Factorial(int n)
        {
            int fact = 1;

            for (int i = 1; i<= n; i++)  
                fact *= i;
            return fact;
        }
    }
}
