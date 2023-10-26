using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A064_BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v = { 3,5,2,7,1 };
            PrintArray(v);

            //Bubble Sort 빅오표기법 : O(n^2)
            for (int i = 4; i > 0; i--) //배열 갯수만큼 반복
            {
                for (int j = 0; j < i; i++)  //총 반복횟수보다 j값이 작으면 반복
                {
                   if (v[j] > v[j + 1]) // v[0] = 3 > v[1] = 5 보다 크면 반복
                    {
                        int t = v[j];  //t = 3을 저장하고
                        v[j] = v[j + 1]; // v[0]에 v[1]값을 이동
                        v[j + 1] = t; //temp시켜 앞에있던값을 교환
                    }
                }
                PrintArray(v); 
            }
        }
        public static void PrintArray(int[] v) 
        {
            foreach (int i in v) 
            {
                Console.Write("{0,5}", i);
            Console.WriteLine();
            }
        
        }
    }
}
