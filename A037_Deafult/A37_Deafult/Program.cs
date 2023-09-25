using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A37_Deafult
{
    internal class Program
    {
        enum E { Red, Green, Blue };

        static void Main(string[] args)
        {
            int a = default;
            string s = default;
            Console.WriteLine("a = " + a); //디폴트로 할당되서 값이 0
            Console.WriteLine("s = " + s); //디폴트로 할당되서 값이 안나옴

            Console.WriteLine("E = " + default(E)); //enum배열의 디폴트값 출력 Red
            Console.WriteLine("E = " + (E)0); // 위와같이 Red 출력

            MyList<int> iList = new MyList<int>();
            Console.WriteLine("iList : " + iList.GetLast()); //myList 제네릭클래스로 iList의 마지막 객체값을 가져옴
                                                             //이때 값이 비어있다면 data의 디폴트값인 0이 출력

            MyList<string> sList = new MyList<string>();     //myList 제네릭클래스 sList 마지막 객체값 가져오기
            Console.WriteLine("sList : " + sList.GetLast()); // 값이 비어있다면 디폴트값인 null 출력
        }
    }
    public class  MyList<T> //myList T 클래스 정의
    {
        private class Node //node 클래스 정의
        {
            public T data; //맴버
            public Node next; //맴버
        }
        private Node head = default; //초기화

        public void AddNode(T t) //data를 t로 하는 노드를 만들어 맨앞에 추가함
        {
            Node newNode = new Node(); //객체생성
            newNode.next = head; 
            newNode.data = t;
            head = newNode;

        }

        public T GetLast () //data값 리턴 메소드 
        {
            T temp = default(T);

            Node current = head;
            while (current != null)
            {
                temp = current.data;
                current = current.next;
            }
            return temp;
        }
    }
}
