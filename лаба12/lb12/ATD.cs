using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb12
{
    public class Node<T>
    {
        public Node(T data) {
            this.data = data;
        }
        public Node()
        {
            data = default(T);
        }
        public T data;
        public Node<T> next;

        public bool IsNull => throw new NotImplementedException();
    }
    public class ATD<T>
    {
        public Node<T> head;
        public Node<T> tail;
        public int count;
        public ATD(Node<T> head, Node<T> tail, int count)
        {
            this.head = head;
            this.tail = tail;
            this.count = count;
        }
        public ATD(T a)
        {
            head= new Node<T>(a);
            tail= new Node<T>(a);
            count = 1;
        }
        public ATD()
        {
            count = 0;
        }
        public void Add(T data)
        {
            if (count == 0)
            {
                head = new Node<T>(data);
                tail = new Node<T>(data);
                head.next = tail;
            }
            else if (count == 1)
            {
                var temp = new Node<T>(data);
                head.next = temp;
                tail.next = temp;
                tail = tail.next;
            }
            else
            {
                var temp = new Node<T>(data);
                tail.next = temp;
                tail = tail.next;
            }
            count++;
        }

        public void Peek()
        {
            Console.WriteLine(head.data);
        }
        public void PeekLast()
        {
            Console.WriteLine(tail.data);
        }
        public T Pop()
        {
            if (!Voidless())
            {
                if (count != 1)
                {
                    var temp = head;
                    head = head.next;
                    count--;
                    return temp.data;
                }
                else
                {
                    var temp = head;
                    head = new Node<T>();
                    tail=new Node<T>();
                    count = 0;
                    return temp.data;
                }
            }
            else
            {
                throw new Exception("Пустой стек!");
            }
        }
        public bool Voidless()
        {
            if (count == 0) return true;
            return false;
        }
    }
}
