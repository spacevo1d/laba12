using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb12
{
    public class MyStack<T>
    {
        protected T[] items;
        protected int count=0;
        protected int n = 10;
        public MyStack()
        {
            this.items = new T[n];
        }
        public MyStack(int N)
        {
            n=N;
            this.items = new T[N];
        }
        public bool Voidless()
        {
            if (count == 0 ) return true;
            return false;
        }
        public bool Full()
        {
            if ( count == n ) return true;
            return false;
        }
        public void Print()
        {
            for(int i = count-1; i >=0 ; i--)
            {
                Console.WriteLine(items[i]);
            }
        }
        public virtual T Pop()
        {
            if (!Voidless())
            {
                T temp = items[count - 1];
                T[] arr = new T[items.Length - 1];
                Array.Copy(items, arr, arr.Length);
                items = new T[arr.Length + 1];
                Array.Copy(arr, items, arr.Length);count--;
                return temp;
            }
            else
            {
                throw new Exception("Пустой стек!");
            }
        }
        public T Peek()
        {
            if (!Voidless ())
            {
                return items[count - 1];
            }
            else
            {
                throw new Exception("Пустой стек!");
            }
        }
        public virtual void Push(T item)
        {
            if (Full())
            {
                throw new Exception("Нельзя добавить элемент в полный стек!!!");
            }
            else
            {
                items[count] = item;
                count++;
            }
        }
    }
}
