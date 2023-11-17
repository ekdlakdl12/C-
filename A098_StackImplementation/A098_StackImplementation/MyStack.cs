using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


//Stack - Last in - First out LIFO

namespace A098_StackImplementation
{
    class MyStack<T>
    {
        const int maxSize = 10;
        private T[] arr = new T[maxSize];
        private int top = 0;

        public MyStack() 
        {
            top = 0;
        }

        //스택에 집어넣기
        public void Push(T val)
        {
            if(top < maxSize)
            {
                arr[top] = val;
                ++top;
            }
            else
            {
                Console.WriteLine("Stack Full");
                return;
            }
        }
        public T Pop()
        {
            if (top > 0)
            {
                --top;
                return arr[top];
            }
            else
            {
                Console.WriteLine("Stack Empty");
                return default(T);
            }
        }

    }
}
