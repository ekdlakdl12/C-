using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//두숫자 사이의 합을 출력

namespace A076_Add
{
    class Program //class 안에있으면 private 밖에다가 만들거면 public  밖에다만들고 private 선언할꺼면 getter setter 이용하기
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1~100까지의 합 : {0,8}", Add(1,100));
            Console.WriteLine("101~200까지의 합 : {0,8}", Add(101, 200));
        }

        private static int Add(int v1, int v2)
        {
            int sum = 0;
            for (int i = v1; i <= v2; i++)
                sum += i;
                return sum;
        }
    }
}
