using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A090_params
{
    internal class Program
    {
        public static void PrintIntParams(params int[] arr) //<--- params는 메소드가 여러개 필요할때 사용함
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public static void PrintObjectParams(params object[] arr) //object는 데이터 종류에 상관없이 배열에 들어감
        {
        
            for (int i = 0;i < arr.Length;i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            PrintIntParams(1, 2, 3, 4);
            PrintObjectParams(1, 1.234, 'a', "test");
            PrintIntParams();

            int[] myIntArray = { 5, 6, 7, 8, 9 };
            PrintIntParams(myIntArray);

            object[] myObjectArray = { 2, 2.345, 'b', "test", "again" };
            PrintObjectParams(myObjectArray);

            PrintObjectParams(myIntArray);

        }
    }
}
