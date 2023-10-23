using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A059_MultiDimensionArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2차원배열: arrA[2,3]"); //2차원배열 선언방법 1
            int[,] arrA = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < 2; i++) 
            {
                for (int j = 0; j < 3; j++)
                    Console.WriteLine("{0,5}", arrA[i, j]);
                Console.WriteLine();
            }

            
            Console.WriteLine("가변 배열: arrB[2][3]"); //2차원배열 선언방법 2
            int[][] arrB = new int[2][];
            arrB[0] = new int[] {1, 2};
            arrB[1] = new int[] {3, 4, 5};

            
            for (int i = 0; i < 2; i++) 
            {
                Console.Write("arrB[{0}] : ", i); //{1,2} {3,4,5} 
                
                for (int j = 0; j < arrB[i].Length; j++) //1회전 J = 0 {1,2} 2회전 J = 1 {3,4,5} 
                    Console.Write("{0} ", arrB[i][j]); // 0/0 ,0/1 ,0/2 ,1/0 ,1/1
                Console.WriteLine();
            
            }
        }
    }
}
