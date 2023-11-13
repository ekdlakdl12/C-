using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//일반화 메소드 데이터 유형에 관계없이 사용가능
namespace A093_GenericMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            double[] d = { 0.1, 0.2, 0.3 };
            string[] s = { "tiger", "lion", "zebra" };

            PrintArray<int>(a);
            PrintArray<double>(d);
            PrintArray<string>(s);
        }

        private static void PrintArray<T>(T[] a) //T(Type) 제네릭 
        {
            foreach(var item in a)
                Console.WriteLine("{0,8}",item);
            Console.WriteLine();
        }

    }
}
