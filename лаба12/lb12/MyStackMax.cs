using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb12
{
    internal class MyStackMaxMin<T,U,U1>:MyStack<T> where U:IComparer<T> where U1:IComparer<T>
    {
        private T[] maxes;
        private T[] mines;
        public U compare;
        public U1 comparer;
        public MyStackMaxMin(U c,U1 t) : base()
        {
            this.maxes = new T[n];
            this.mines = new T[n];
            compare = c;
            comparer = t;
        }
        public override void Push(T item)
        {
            base.Push(item);
            if (count < 2)
            {
                mines[count-1] = item;
                maxes[count-1] = item;
            }
            else
            {
                mines[count - 1] = (comparer.Compare(item, mines[count - 2]) < 0 ? item : mines[count - 2]);
                maxes[count-1] = (compare.Compare(item, maxes[count-2])>0?item:maxes[count-2]);
            }
        }
        public T GetMax()
        {
            return  maxes[count-1]; 
        }
        public T GetMin()
        {
            return mines[count-1];
        }
    }
}