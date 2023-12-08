using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A118_Predicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //람다식
            Predicate<int> isEven = n => n% 2 == 0;
            Console.WriteLine(isEven(6));

            //Equals  == 와 같은뜻
            Predicate<string> isLowerCase = s => s.Equals(s.ToLower());
            Console.WriteLine(isLowerCase("This is Test"));
        }
    }
}
