using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  double은 64비트(8바이트)크기에, 약 15~16 자리의 유효숫자를 가진다.
  decimal에 비해 연산이 빠르기에 대부분의 경우 사용됨.
 
  decimal은 128비트(16바이트)크기에 28~29 자리의 유효숫자를 가진다.
  정밀한 계산이 필요한 금융, 세금, 과학 등의 분야에서 사용됨
 */


namespace A095_GenericMethodsUsingDynamic
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 45, 32, 47, 85, 46, 93, 47, 50, 71 };
            double[] d = {0.1, 5.3, 6.7, 8.5, 4.9, 6.1};
            float[] f = { 1.2f, 5.3f, 6.1f, 3.4f, 8.8f };
            decimal[] c = { 123, 783, 456, 234, 456, 748 };

            PrintArray<int>("a[]", a);
            CalcArray<int>(a);

            PrintArray<double>("d[]", d);
            CalcArray<double>(d);

            PrintArray<float>("f[]", f);
            CalcArray<float>(f);

            PrintArray<decimal>("c[]", c);
            CalcArray<decimal>(c);
        }
        private static void CalcArray<T>(T[] a) where T: struct 
        {
            T sum = default(T);
            T avg = default(T);
            T max = default(T);
        
            foreach(dynamic item in a)
            {
                if (max < item)
                    max = item;
                sum += item;
            }

            avg = (dynamic)sum / a.Length;
            Console.WriteLine("       Sum = {0}, Average = {1}, Max = {2}", sum, avg, max);

        }

        private static void PrintArray<T>(string s, T[] a) where T: struct
        {
            Console.Write(s);
            foreach(var item in a)
            {
                Console.WriteLine(" {0}",item);
            }
            Console.WriteLine();
        }
    }
}
