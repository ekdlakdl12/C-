using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A048_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n!을 계산합니다"); 
            Console.WriteLine("정수 n을 입력하세요"); 

            int n = int.Parse(Console.ReadLine()); //n값 몇팩토리얼인지

            int fact = 1;

            for (int i = 2; i <= n; i++) //i가 입력한 n과 같거나 낮을때까지 
                fact *= i; //fact변수에 곱해서 집어넣고
            
           

            
            Console.WriteLine("{0}! = {1}",n,fact); //출력


        }
    }
}
