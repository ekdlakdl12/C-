using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A063_BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] v = new int[30]; //배열 30칸

            for (int i = 0; i < v.Length; i++) // i < 30 
            
                v[i] = r.Next(1000); //1~1000 사이의 숫자로 랜덤하게 배열에 값이들어감
            PrintArray("정렬전", v);
            
            //(1) 정렬
            Array.Sort(v);
            PrintArray("정렬후", v);

            Console.Write("===> 검색할 숫자를 입력하세요"); //랜덤으로 출력된 값중에 하나를 입력해야 실행됨
            int key = int.Parse(Console.ReadLine());
            int count = 0; //비교횟수
        
            //(2) 선형탐색 <== 처음부터 끝까지 비교하며 값을 찿으며 정렬되어있지않아도 상관없음
            for (int i = 0; i < v.Length -1; i++)
            {
                count++;
                if (v[i] == key)  //끝까지 key 값 비교
                {
                    Console.WriteLine("v[{0}] = {1}", i , key);
                    Console.WriteLine("선형탐색의 비교횟수는 {0}회입니다",count);
                    break;
                }
            }

            //(3)이진탐색 <== 데이터갯수가 N개일때 N/2를 이용하여 데이터를 찿음 데이터가 정렬되어있지않으면 사용 불가능
            count = 0;
            int low = 0;
            int high = v.Length - 1; // 1부터시작하기 때문에 -1 함

            while (low <= high) //찿을때까지 반복하기위해 while사용
            {
                count++;
                int mid = (low + high) / 2; //<== 핵심
                if (key == v[mid])
                {
                    Console.WriteLine("v[{0}] = {1}", mid, key);
                    Console.WriteLine("이진탐색의 비교횟수는 {0}회입니다.", count);
                    break;
                }
                else if (key > v[mid])
                    low = mid + 1; //mid값이 key값보다 작으면 key값이 mid값보다 위에 있음으로 mid값에 + 1 을 하여 반복문을 다시 수행함
                else
                    high = mid - 1; // mid값이 key값보다 크면 key값이 mid값보다 아래에 있음으로 mid값에 -1을 하여 반복문을 다시 수행함
            }
        }
    
        private static void PrintArray(string s, int[] v) 
        {
            Console.WriteLine(s);
            for(int i  = 0; i < v.Length;   i++)
                Console.Write("{0,5}{1}", v[i],(i % 10 == 9) ? "\n" : ""); // 1차원 배열을 출력하기 위한 메소드 (i % 10 == 9) 일씨 줄바꿈시키는것 10칸이 안넘어가면 "" <==
        }
    }
}
