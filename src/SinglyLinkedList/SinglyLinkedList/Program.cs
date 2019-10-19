using LinkedList;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main()
        {
            var intLinkedList = new SingleLinkedList<int>(123);
            intLinkedList.Push(1231);
            intLinkedList.Push(1231123);
            intLinkedList.Push(4231);
            intLinkedList.Push(535331);
            intLinkedList.Remove(535331);

            foreach (var value in intLinkedList)
                Console.WriteLine(value);

            Console.WriteLine("Count - " + intLinkedList.Count);

            var linkedList = new SingleLinkedList<string>("first");
            linkedList.Append("second");
            linkedList.Append("third");
            linkedList.Push("zero");

            linkedList.Remove("zero");

            foreach (var value in linkedList)
                Console.WriteLine(value);

            Console.WriteLine("Count - " + linkedList.Count);

            linkedList = new SingleLinkedList<string>();
            linkedList.Push("third");
            linkedList.Push("second");
            linkedList.InsertAfter("second", "second at half");
            linkedList.Push("first");
            linkedList.Append("fourth");

            linkedList.Remove("second");
            linkedList.Remove("fourth");

            foreach (var value in linkedList)
                Console.WriteLine(value);

            Console.WriteLine("Count - " + linkedList.Count);

            Console.ReadLine();
        }
    }
}
