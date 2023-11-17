﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A100,A101 연계
//Queue는 (선입선출 Fast-in --> First-out) 먼저들어온놈이 먼저나간다

namespace A100_QueueImplemetation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            MyQueue<float> que = new MyQueue<float>();

            for(int i = 0; i< 5; i++) 
                que.EnQueue(new Node<float>(r.Next(100) / 100.0F));
            que.Print();

            for (int i = 0; i < 3; i++)
                Console.WriteLine("Dequeue: {0}",que.DeQueue());
            que.Print();
        }
    }
}
