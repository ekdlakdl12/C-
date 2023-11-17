using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A098_StackImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();
            Random r = new Random();

            for(int i = 0; i < 10; i++) 
            {
                int val = r.Next(100);
                stack.Push(val);
                Console.WriteLine("Push(" + val + ")");
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
                Console.WriteLine("Pop() = " + stack.Pop() + ",");
        }
    }
}
