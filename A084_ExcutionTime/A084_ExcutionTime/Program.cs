using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//재귀메소드 vs 반복문 속도차이
//예시 피보나치 수열

namespace A084_ExcutionTime
{
    class Program
    {
        static int[] f = new int[50]; //계산한 피보나치 수열을 저장하는 배열
    
        static void Main(string[] args)
        {

            Console.WriteLine("피보나치 수열을 n항까지 출력합니다.");
            Console.Write("n을 입력하세요: ");

            int n  = int.Parse(Console.ReadLine());
            
            var watch = System.Diagnostics.Stopwatch.StartNew();   //시간측정 시작

            f[1] = f[2] = 1;

            for (int i = 3; i <= n; i++)
                f[i] = f[i - 1] + f[i - 2]; // f(3) = f(1) + f(2)
                                            
            for (int i = 1;  i <= n; i++)
                Console.WriteLine("{0}", f[i]);

            watch.Stop(); // 측정 끝
            var elapsedMs = watch.ElapsedMilliseconds; //측정된 시간값 elapseMs변수에 저장

            Console.WriteLine("실행시간은 {0}ms\n",elapsedMs);
           
         //----------------------------------------------------------------------------------------
            watch = System.Diagnostics.Stopwatch.StartNew(); // for문 측정시작

            for (int i = 1; i <= n; i++)
                Console.WriteLine("{0}", FiboRecursive(i));
            Console.WriteLine();

            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("실행시간은 {0}ms", elapsedMs);

        }
        
        private static int FiboRecursive(int n) 
        {
            if (n == 0 || n == 2)
                return 1;
            else
                return FiboRecursive(n - 1) +FiboRecursive(n - 2);
        }

    }
}
