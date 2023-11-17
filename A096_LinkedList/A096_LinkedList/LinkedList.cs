using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace A096_LinkedList
{
    class Node
    {
        internal int data;

        //리스트 다음에 연결되는 노드
        internal Node next;
        
        //Node 클래스의 생성자 data를 저장하는 Node를 생성함
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }

    class LinkedList
    {
        Node head;

        internal void InsertFront(int data) 
        {
            Node node = new Node(data);
            node.next = head;
            head = node;
        }
        //리스트의 맨뒤에 data를 추가함
        internal void InsertLast(int data) 
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                return;
            }
            Node lastNode = GetLastNode();
            lastNode.next = node;
        }
        //리스트의 맨 뒤 노드의 레퍼런스를 리턴함
        internal Node GetLastNode()
        {
            Node temp = head;
            while(temp.next != null) 
            {
                temp = temp.next;
            }
            return temp;
        }

        //prev 뒤에 data를 갖는 노드 삽입하기 // prev가 저장된 노드 뒤에  data를 추가함
        internal void InsertAfter(int prev, int data) 
        {
            Node PrevNode = null;

            //find prev
            for(Node temp = head; temp != null; temp = temp.next) 
                if (temp.data == prev)
                    PrevNode = temp;
            
            if (PrevNode == null)
                {
                    Console.WriteLine("{0} data is not in the list");
                    return;
                }
                Node node = new Node(data);
                node.next = PrevNode.next;
                PrevNode.next = node;
        }

        //key값을 저장하고 있는 노드 삭제하기
        internal void DeleteNode(int key) 
        {
            Node temp = head;
            Node prev = null;
            if(temp != null && temp.data == key) //head가 찿는값이면
            {
                head = temp.next;
                return;
            }
            while(temp != null && temp.data != key) 
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null) //끝까지 찿는값이 없으면
            {
                return;
            }
            prev.next = temp.next;
        }
        //리스트의 노드 순서를 거꾸로만듬
        internal void Reverse()
        {
            Node prev = null;
            Node current = head;
            Node temp = null;
            while(current != null) 
            {
                temp = current.next;
                current.next = prev;

                prev = current;
                current = temp;
            }
            head = prev;
        }
        //리스트의 노드를 순서대로 출력함
        internal void Print() 
        {
            for (Node node = head; node != null; node = node.next)
                Console.WriteLine(node.data + " -> ");
            Console.WriteLine();
            
        }

    }
}
