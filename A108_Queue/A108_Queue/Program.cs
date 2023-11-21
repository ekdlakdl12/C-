using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A108_Queue
{
    public class Program
    {
        static void Main(string[] args)
        {   
            //Queue
            Queue<string> que = new Queue<string>();

            que.Enqueue("Tiger");
            que.Enqueue("Lion");
            que.Enqueue("Lion");
            que.Enqueue("Zebra");
            que.Enqueue("Rabbit");
            //입력된거 출력
            PrintQueue("que: ", que);

            Console.WriteLine("Dequeuing '{0}'", que.Dequeue()); // 제거
            Console.WriteLine("Peek: '{0}'", que.Peek()); //맨앞값을 가져오며 값이 사라지진 않음

            Queue<string> que2 = new Queue<string>();
            PrintQueue("que2: ", que2);

            //큐 개수 만큼 배열생성
            string[] array = new string[que.Count];
            que.CopyTo(array, 0); // que 값을 array에 복사함
            Queue<string> que3 = new Queue<string>();
            PrintQueue("que3: '{0}'", que3);

            Console.WriteLine("que.Contains(Lion) = {0}", que.Contains("Lion"));
            que3.Clear();
            Console.WriteLine("Count = {0}, {1}, {2}",que.Count,que2.Count,que3.Count);

        }

        private static void PrintQueue(string s, Queue<string> q) 
        {
            Console.Write("{0,-8}",s);
            foreach (var item in q)
                Console.Write("{0,-8}",item);
            Console.WriteLine();
        }
    }
}
