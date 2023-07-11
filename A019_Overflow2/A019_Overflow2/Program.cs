using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A019_Overflow2
{
    class Program
    {
        static void Main(string[] args)
        {
            //y = int.MaxValue + 10; // 이문장은 컴파일 할때 에러가 나옵니다
            int x = int.MaxValue;
            int y = 0;

            checked // int의 한계값에 + 10을 더해 버그가남 try문을 통해 확인하지않았으면 그냥 실행되고 버그남
            {
                try
                {
                    y = x + 10;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("int.MaxValue + 10 = {0}",y);
            }


        }
    }
}
