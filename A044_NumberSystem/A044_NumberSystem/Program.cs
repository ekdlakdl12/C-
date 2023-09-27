using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A044_NumberSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {   //이쁘게 출력하기 위해 위치배정한것      
            Console.WriteLine("{0,5} {1,8} {2,3} {3,4}", "10진수","2진수","8진수","16진수");
        
            for(int i = 0; i <=128; i++)
            {                    //위치 배정
                Console.WriteLine("{0,7} {1,10} {2,5} {3,6}",i,
                    Convert.ToString(i,2).PadLeft(8,'0'),//PadLeft 왼쪽 8칸을 0으로채운다
                    Convert.ToString(i, 8), //진수로 변환후 출력하는 convert to string
                    Convert.ToString(i, 16));
            }
        }
    }
}
