using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//빅오표기법 O(1)
//키 중복 X
//순차적인 숫자 인덱스 사용 x

namespace A110_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> colorTable = new Dictionary<string, string>();

            colorTable.Add("Red", "빨간색");
            colorTable.Add("Green","초록색");
            colorTable.Add("Blue", "파란색");

            foreach (var v in colorTable)
                Console.WriteLine("colorTable[{0}] = {1}",v.Key, v.Value);

            try
            {
                colorTable.Add("Red", "빨강");
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }

            try 
            {
                Console.WriteLine("Yellow => {0}", colorTable["Yellow"]);
            }
            catch (KeyNotFoundException e) 
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\n "+ colorTable["Red"]);
            Console.WriteLine("\n " + colorTable["Green"]);
            Console.WriteLine("\n " + colorTable["Blue"]);

        }
    }
}
