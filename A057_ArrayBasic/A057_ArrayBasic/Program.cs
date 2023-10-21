using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A057_ArrayBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;

            //(1)
            int[] a = { 1, 2, 3 }; //디폴트
            Console.Write("a[]: ");

            foreach (var  value in a)
                Console.Write(value + " ");
                
            //(2)
            int[] b = new int[] { 1, 2, 3 }; //배열 선언
            Console.Write("b[]: ");
            for (int i = 0; i < 3; i++)
                Console.WriteLine(b[i] + " ");

            //(3)
            int[] c = new int[3] { 1, 2, 3 }; //배열 개수 제한
            Console.Write("\nc[]: ");
            for (int i = 0; i < c.Length; i++) //c 배열 길이만큼 반복
                Console.Write(c[i] + " ");

            //(4)

            int[] d = new int[3];
            for (int j = 0; j <= 2; j ++)
                str = Console.ReadLine();
                d[j] = int.Parse(str);
            
            Console.Write(d[j]);
        }
    }
}
