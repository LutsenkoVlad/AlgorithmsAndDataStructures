using System.Collections;
using System.Collections.Generic;

#nullable disable

namespace DataStructures
{
    public class SingleLinkedList<T> : IEnumerable<T>
    {
        public SingleLinkedList() { }

        public SingleLinkedList(T data) =>
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

        public bool Remove(T value)
        {
            if (Count == 0) return false;

            if (Count == 1)
            {
                if (_head.Value.Equals(value))
                {
                    _head = null;
                    _tail = null;
                    Count--;
                    return true;
                }

                return false;
            }

            LinkedNode<T> previous = null;
            var current = _head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    if (current == _head)
                    {
                        _head = _head.Next;
                        Count--;
                        return true;
                    }

                    if (current == _tail)
                    {
                        previous.Next = _tail = null;
                        Count--;
                        return true;
                    }

                    previous.Next = current.Next;
                    Count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }

        public bool IsEmpty() => Count == 0;

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
            Next  = next;
        }

        public LinkedNode(T value) : this(value, null) { }
    }
}
