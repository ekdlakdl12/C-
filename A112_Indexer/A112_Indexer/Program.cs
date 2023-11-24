using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A112_Indexer
{
    public class Program
    {   
        class MyCollection<T>
        {
            private T[] array = new T[100];

            public T this[int i] //인덱서정의 
            {
                get { return array[i]; }
                set { array[i] = value; }
            }
        }

        static void Main(string[] args)
        {
            var myString = new MyCollection<string>();

            myString[0] = "Hello string";
            myString[1] = "Hello, C#";
            myString[2] = "Hello, Indexxer!";

            for (int i =0; i<3; i++)
                Console.WriteLine(myString[i]);
                
            

        }
    }
}
