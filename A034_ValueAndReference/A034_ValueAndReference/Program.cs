using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A034_ValueAndReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "before passing";
            Console.WriteLine(s); //전처리

            Test(s);
            Console.WriteLine(s); //그냥 출력 전처리

            Test(ref s);
            Console.WriteLine(s); //Ref로 인한 후처리
        }

        public static void Test(String s)
        {
            s = "after passing";
        }

        public static void Test(ref String s)
        {
            s = "after passing";
        }
    }
}
