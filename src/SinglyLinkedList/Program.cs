using System;
using System.Collections;
using System.Collections.Generic;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main()
        {
            var linkedList = new SinglyLinkedList<string>("first");
            linkedList.Append("second");
            linkedList.Append("third");
            linkedList.Push("zero");

            foreach (var value in linkedList)
                Console.WriteLine(value);

            Console.WriteLine("Count - " + linkedList.Count);

            linkedList = new SinglyLinkedList<string>();
            linkedList.Push("third");
            linkedList.Push("second");
            linkedList.InsertAfter("second", "second at half");
            linkedList.Push("first");
            linkedList.Append("fourth");

            foreach (var value in linkedList)
                Console.WriteLine(value);

            Console.WriteLine("Count - " + linkedList.Count);

            Console.ReadLine();
        }
    }

    class SinglyLinkedList<T> : IEnumerable<T>
    {
        public SinglyLinkedList() { }

        public SinglyLinkedList(T data) =>
            Append(data);

        private LinkedNode<T> _head;
        private LinkedNode<T> _tail;

        public int Count { get; private set; }

        public bool InsertAfter(T previousValue, T value)
        {
            var current = _head;
            while (current != null)
            {
                if (current.Value.Equals(previousValue))
                {
                    var aftetCurrentNode = current.Next;
                    current.Next = new LinkedNode<T>(value);
                    current.Next.Next = aftetCurrentNode;
                    Count++;
                    return true;
                }
            }

            return false;
        }

        public void Push(T value)
        {
            if (_head == null)
            {
                _head = new LinkedNode<T>(value);
                _tail = _head;
            }
            else
            {
                var previousHead = _head;
                _head = new LinkedNode<T>(value);
                _head.Next = previousHead;
            }
            Count++;
        }

        public void Append(T value)
        {
            if (_head == null)
            {
                _head = new LinkedNode<T>(value);
                _tail = _head;
            }
            else
            {
                var newNode = new LinkedNode<T>(value);
                _tail.Next = newNode;
                _tail = newNode;
            }

            Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = _head;
            while (node != null)
            {
                yield return node.Value;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => 
            GetEnumerator();
    }

    class LinkedNode<T>
    {
        public T Value { get; private set; }

        public LinkedNode<T> Next { get; set; }

        public LinkedNode(T value, LinkedNode<T> next)
        {
            Value = value;
            Next = next;
        }

        public LinkedNode(T value) : this(value, null) { }
    }
}
