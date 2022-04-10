using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class ListaGen<T>
    {
        private Nod start;
        private Nod end;
        public ListaGen()
        {
            start = null; end = null;

        }
        private class Nod
        {
            private T data;
            private Nod next;

            public Nod(T data)
            {
                this.data = data;
                
            }

            public T Data { get => data; set => data = value; }
            public Nod Next { get => next; set => next = value; }
        }
        public void insertToFront(T t)
        {
            Nod n = new Nod(t);
            n.Next = start;
            start = n;
            if (end == null) end = n;
        }
        public void insertToEnd(T t)
        {
            Nod n = new Nod(t);
            if (start == null) start = n;
            if (end != null) end.Next = n;
            end = n;
        }
        public void delete(T t)
        {
            Nod current = start;
            while (current != null && current.Data.Equals(t))
            {
                start = start.Next;
                current = start;
            }
            if (current == null) return;
            while (current.Next != null)
            {
                if (current.Next.Data.Equals(t))
                {
                    if (end == current.Next)
                    {
                        end = current;
                        end.Next = null;
                    }
                    else
                    {
                        Nod delNod = current.Next;
                        current.Next = current.Next.Next;
                        delNod.Next = null;
                    }
                }
                else current = current.Next;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            Nod current = start;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }





    }
}
