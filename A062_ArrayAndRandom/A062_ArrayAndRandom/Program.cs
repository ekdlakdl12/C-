using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A062_ArrayAndRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] v = new int[20];

            for (int i = 0; i < v.Length; i++) //5개 랜덤한값 저장
                v[i] = r.Next(100);
            PrintArray(v);

            int max = v[0]; //최댓값
            for (int i = 1; i < v.Length; i++)
                if (v[i] > max)
                    max = v[i];
            Console.WriteLine("최댓값: {0}",max);

            int min = v[0]; //최솟값
            for(int i = 1; i < min; i++)
                if (v[i] < min)
                    min = v[i];
            Console.WriteLine("최솟값: {0}", min);

            int sum = 0; //합계
            for (int i = 0; i < v.Length; i++)
                sum = sum + v[i];
            Console.WriteLine("합계: {0} \n 평균:{1:F2}", sum, (double)sum / v.Length);

            //int percent = 0;
            //for (int i = 0; i < v.Length; i++)
            //    percent = percent + v[i];
        
        }
        private static void PrintArray(int[] v) 
        {
            for (int i = 0; i < v.Length; i++)
                Console.Write("{0,5}{1}", v[i],(i % 10 == 9) ? "\n" : ""); //3항 연산자
        }
    }
}
