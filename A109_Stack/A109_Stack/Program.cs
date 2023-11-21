using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A109_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("계산할 수시을 Polish 표기법으로 입력하세요");
            string[] token = Console.ReadLine().Split();

            foreach (var i in token)
                Console.Write("{0}", i);
            Console.WriteLine(" = ");

            //스택생성
            Stack<double> nStack = new Stack<double>();

            foreach (var s in token) 
            {
                if (isOperator(s)) 
                {
                    switch (s)
                    {
                        case "+":
                            nStack.Push(nStack.Pop() + nStack.Pop()); break;
                        case "-":
                            nStack.Push(nStack.Pop() - nStack.Pop()); break;
                        case "*":
                            nStack.Push(nStack.Pop() * nStack.Pop()); break;
                        case "/":
                            nStack.Push(nStack.Pop() / nStack.Pop()); break;
                    }
                }
                else 
                {
                    nStack.Push(double.Parse(s));
                }
            }
            Console.WriteLine();
        }

        private static bool isOperator(string s) 
        {
            if (s == "+" || s == "-" || s == "*" || s == "/")

                return true;
            else
                return false;
        }

    }
}
