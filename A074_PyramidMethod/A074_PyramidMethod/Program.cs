using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A074_PyramidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawPyramid(3);
            DrawPyramid(5);
            DrawPyramid(7);
        }

        static void DrawPyramid(int n)
        {
            for (int i = 1;  i <= n; i++)                             // i= 1부터 3까지 반복
            {                                                         // j= 1부터 3까지 반복
                for (int j = i; j < n; j++)                           // k= 1부터 2 * 1 - 1 k++    1개 3개 5개 찍힘
                    Console.Write(" ");
                for (int k = 1; k <= 2 * i - 1; k++)
                    Console.Write("*");
                Console.WriteLine();
                
            }
        }
    }
}
