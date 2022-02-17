using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStuctures
{
    public class LinkedList_1027<T> : IEnumerable<T>
    {
        Node start = null;
        Node end = null;


        public void AddFirst(T value) //O(1) 
        {
            Node n = new Node(value);
            n.next = start;
            start = n;
            if (start.next == null) end = n;
        }

        public void AddLast(T value)//O(1)
        {
            if(start == null)
            {
                AddFirst(value);
                return;
            }

            end.next = new Node(value);
            end = end.next;
        }

        public bool RemoveLast(out T removedValue)//O(n)
        {
            removedValue = default;
            if (start == null) return false; //empty list

            if(start.next == null) // remove single item
            {
                return RemoveFirst(out removedValue);
            }

            removedValue = end.data;
            Node beforeLast = start;
            while(beforeLast.next != end)
            {
                beforeLast = beforeLast.next;
            }
            beforeLast.next = null;
            end = beforeLast;
            return true;
        }

        public bool RemoveFirst(out T removedValue) // O(1)
        {
            removedValue = default;
            if (start == null) return false;

            removedValue = start.data;
            start = start.next;

            if (start == null) end = null;
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Node tmp = start;

            while (tmp != null)
            {
                sb.Append($"{tmp.data} ");
                tmp = tmp.next;
            }
            return sb.ToString();
        }

        public bool GetAt(int index, out T foundValue) // O(n)
        {
            Node tmp = start;

            foundValue = default;
            for (int i = 0; tmp != null && i < index; i++)
            {
                tmp = tmp.next;
            }
            if (tmp == null) return false;

            foundValue = tmp.data;
            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            ListEnumerator enumerator = new ListEnumerator(start);
            return enumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        class Node
        {
            public T data;
            public Node next;

            public Node(T data)
            {
                this.data = data;
                next = null;
            }
        }

        class ListEnumerator : IEnumerator<T>
        {
            Node current;

            public ListEnumerator(Node start)
            {
                current = start;
            }

            public T Current
            {
                get { return current.data; }
            }

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
               
            }

            public bool MoveNext()
            {
                if(current.next != null)
                {
                    current = current.next;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
               
            }
        }
    }
}
