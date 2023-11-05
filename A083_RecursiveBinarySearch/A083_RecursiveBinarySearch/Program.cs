using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace A083_RecursiveBinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //예시값 랜덤으로 넣기
            Random r = new Random();
            int[] v = new int[30];

            for (int i = 0; i < 30; i++)
                v[i] = r.Next(1000);
                printArray("정렬전", v);
            

            Array.Sort(v); // 정렬 이진탐색은 정렬이 무조건 되어있어야함
            printArray("정렬후", v);

            Console.WriteLine("=> 검색할 숫자를 입력하세요: ");

            int key = int.Parse(Console.ReadLine());

            int index = RecursiveBinarySearch(v, 0, v.Length - 1, key);
            if (index == -1)
                Console.WriteLine("찿는배열값이 없습니다");
            else
                Console.WriteLine("v[{0}] = {1}", index, key);
        }

        //재귀메소드 / 이진탐색
        private static int RecursiveBinarySearch(int[] v, int low, int high, int key)
        {
            if(low <= high)
            {
                int mid = (low + high) / 2;

                if (key == v[mid])
                    return mid;

                else if(key > v[mid])
                
                    return RecursiveBinarySearch(v,mid +1,high, key);
                else
                    
                    return RecursiveBinarySearch(v,low,mid-1,key);
            }
            return -1;
        }


        //3항연산자 사용하여 10개씩 줄바꿈 하면서 출력
        private static void printArray(string s, int[] v) 
        {
            Console.WriteLine(s);
            for (int i = 0; i < v.Length; i++)
                Console.WriteLine("{0,5}{1}", v[i], (i % 10 == 9) ? "\n" : "");
        }


    }
}