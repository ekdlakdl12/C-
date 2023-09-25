using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A039_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i; //i값을 박싱하여 o로 복사함
            i = i + 10; //i값을 바꿉니다 이미 박싱해둔 o값은 변하지 않음
            int j = (int)o; // o값을 언박싱하여 j에 복사

            Console.WriteLine("The value - type value i = {0}", i);
            Console.WriteLine("The object - type value o =  {0}", o);
            Console.WriteLine("The value - type value j = {0}", j);

            object p = o;// p에 박싱
            o = 100;
            Console.WriteLine("The object - type value o = {0}", o);
            Console.WriteLine("The object - type value p = {0}", p);

        }
    }
}
