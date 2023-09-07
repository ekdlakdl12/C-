using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A028_StringContains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "mouse, cow, tiger, rabbit, dragon";
            string s2 = "Cow"; //s2 = "Cow";  대소문자가 달리 구별되나 확인용
            bool b = s1.Contains(s2);
            Console.WriteLine("'{0}' is in the string '{1}':{2}", s2, s1, b);

            if (b) //b가 True면
            {
                int index = s1.IndexOf(s2); //값이 있으면 0부터
                if (index >= 0)
                    Console.WriteLine("'{0}' begins at index {1}", s2, index);
            }    
                //indexof 를 사용하면 몇번 위치에 있는지 확인 가능함
                if (s1.IndexOf(s2, StringComparison.CurrentCultureIgnoreCase) >= 0) // CurrenCultureIgnoreCase 대소문자 구별 x
                {
                    Console.WriteLine("'{0}' is in the String '{1}'", s2, s1); //0보다 크면 s2에 s1이 포함되어있다는것 
                }
            
        }
    }
}
