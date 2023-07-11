using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A020_RelationalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result;
            int first = 10, second = 20;

            result = (first == second);
            Console.WriteLine("{0} == {1} : {2}", first,second,result); // 0과1의 결과값을 {2} result에 저장후 출력 
            
            result = (first > second);
            Console.WriteLine("{0} > {1} : {2}", first, second, result);
            
            result = (first < second);
            Console.WriteLine("{0} < {1} : {2}", first, second, result);
            
            result = (first >= second);
            Console.WriteLine("{0} >= {1} : {2}", first, second, result);

            result = (first <= second);
            Console.WriteLine("{0} <= {1} : {2}", first, second, result);

            result = (first != second);
            Console.WriteLine("{0} != {1} : {2}", first, second, result);
        }
    }
}
