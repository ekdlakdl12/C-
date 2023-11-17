using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A097_UsingLinkedList

namespace A096_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //만들어둔 LinkedList
            LinkedList list = new LinkedList();
            Random r = new Random();

            //1~100 사이의 숫자 5개 Random값으로 저장
            for (int i = 0 ; i < 5; i++)
                list.InsertLast(r.Next(100));

            Console.WriteLine("랜덤한 5개의 값이 리스트입니다");
            list.Print();

            //Front/Last Insert
            Console.WriteLine("\n맨 앞에 10, 맨뒤에 90삽입. <enter> 입력하세요");
            Console.ReadLine();
            list.InsertFront(10);
            list.InsertLast(90);
            list.Print();

            //맨뒤에 data 집어넣기
            Console.WriteLine("\n 노드뒤에 y값을 저장하려고 합니다");
            
            Console.Write(" x값을 입력하세요 ");
            int x = int.Parse(Console.ReadLine());
            Console.Write(" y값을 입력하세요 ");
            int y = int.Parse(Console.ReadLine());

            list.InsertAfter(x, y);
            list.Print();

            //삭제
            Console.Write("\n 삭제할 노드값을 입력하세요:");
            int z = int.Parse(Console.ReadLine());
            list.DeleteNode(z);
            list.Print();

            //리스트를 뒤집어서 출력
            Console.WriteLine("\n 리스트를 뒤집어 출력. <enter> 입력하세요");
            Console.ReadLine();
            list.Reverse();
            list.Print();

        }
    }
}
