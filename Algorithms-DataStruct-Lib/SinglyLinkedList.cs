using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_DataStruct_Lib
{
    public class SinglyLinkedList<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }

        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            AddFirst(new Node<T>(value));
        }

        private void AddFirst(Node<T> node)
        {
            Node<T> tmp = Head;
            Head = node;

            Head.Next = tmp; // Делаем сдвиг головного узла

            Count++;

            if(Count == 1)
            {
                Tail = Head;
            }
        }

        public void AddLast(T value)
        {
            AddLast(new Node<T>(value));
        }

        public void AddLast(Node<T> node)
        {
            if(IsEmpty)
            {
                Head = node; 
            }
            else
            {
                Tail.Next = node;
            }
            
            Tail = node;

            Count++;
        }

        public void RemoveFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            Head = Head.Next; // сдвиг, узел удаляется из памяти
            
            if(Count == 1)
            {
                Tail = null;
            }

            Count--;
        }

        public void RemoveLast()
        {
            if(IsEmpty)
                throw new InvalidOperationException();

            if(Count == 1)
            {
                Head = Tail = null;
            }
            else
            {
                // найти предпоследний узел
                var current = Head;
                while(current.Next != Tail)
                    current = current.Next;

                current.Next = null;
                Tail = current;
            }

            Count--;
        }

        public bool IsEmpty => Count == 0;
    }
}
