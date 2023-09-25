using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace A033_ConstAndReadonly
{
    class ConstEx
    {
        public const int number = 3;
    }

    class ReadonlyEx
    {
        public readonly int number = 10;
        public ReadonlyEx()
        {
            number = 20;
        }
        public ReadonlyEx(int n)
        {
            number = n;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConstEx.number); //Const사용 / 값 변경 불가능

            ReadonlyEx inst1 = new ReadonlyEx(); //Readonly 사용 / 처음입력되잇던값 20출력 
            Console.WriteLine(inst1.number);

            ReadonlyEx inst2 = new ReadonlyEx(100); //Readonly 사용 /변경 200출력
            Console.WriteLine(inst2.number);
        }
    }
}
