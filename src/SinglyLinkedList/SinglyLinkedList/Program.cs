using System;
using System.Collections;
using System.Collections.Generic;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new SinglyLinkedList<string>("first");
            linkedList.AddToEnd("second");
            linkedList.AddToEnd("third");
            linkedList.Push("zero");

            foreach(var data in linkedList)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine("Count - " + linkedList.Count);

            linkedList = new SinglyLinkedList<string>();
            linkedList.Push("third");
            linkedList.Push("second");
            linkedList.InsertAfter("second", "second at half");
            linkedList.Push("first");
            linkedList.AddToEnd("fourth");

            foreach (var data in linkedList)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine("Count - " + linkedList.Count);

            Console.ReadLine();
        }
    }

    class SinglyLinkedList<T> : IEnumerable<T>
    {
        public SinglyLinkedList() { }

        public SinglyLinkedList(T data)
        {
            AddToEnd(data);
        }

        private LinkedNode<T> Head { get; set; }

        private LinkedNode<T> Tail { get; set; }

        public int Count { get; private set; }

        public bool InsertAfter(T prevNode, T newData)
        {
            var current = Head;
            while(current != null)
            {
                if (current.Data.Equals(prevNode))
                {
                    var aftetCurrentNode = current.Next;
                    current.Next = new LinkedNode<T>(newData);
                    current.Next.Next = aftetCurrentNode;
                    Count++;
                    return true;
                }
            }

            return false;
        }

        public void Push(T data)
        {
            if (Head == null)
            {
                Head = new LinkedNode<T>(data);
                Tail = Head;
            }
            else
            {
                var previousHead = Head;
                Head = new LinkedNode<T>(data);
                Head.Next = previousHead;
            }
            Count++;
        }

        public void AddToEnd(T data) 
        {
            if (Head == null)
            {
                Head = new LinkedNode<T>(data);
                Tail = Head;
            }
            else
            {
                var newNode = new LinkedNode<T>(data);
                Tail.Next = newNode;
                Tail = newNode;
            }
            Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = Head;
            while (node != null)
            {
                yield return node.Data;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    class LinkedNode<T>
    {
        public T Data { get; set; }

        public LinkedNode<T> Next { get; set; }

        public LinkedNode(T data, LinkedNode<T> next)
        {
            Data = data;
            Next = next;
        }

        public LinkedNode(T data) : this(data, null) { }
    }
}
