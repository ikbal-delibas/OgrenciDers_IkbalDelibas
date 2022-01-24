using System;
using System.Collections.Generic;

namespace OgrenciDers_IkbalDelibas
{
    public class SinglyLinkedList<T>
    {
        private Node First = null;

        private int size = 0;

        public int Count => size;

        public SinglyLinkedList() { }

        public SinglyLinkedList(T data) => Add(data);

        public void Add(T data) => Insert(data, size);

        public void Insert(T data, int position)
        {
            if (size < position)
                throw new ArgumentOutOfRangeException("Insert");

            Node node = new Node(data);
            FindPosition(position, out Node previousNode, out Node traveler);

            if (First != traveler)
            {
                if (traveler != null) // Araya ekleme işlemi.
                {
                    previousNode.next = node;
                    node.next = traveler;
                }
                else // Sona ekleme
                    previousNode.next = node;
            }
            else // Başa ekleme
            {
                node.next = First;
                First = node;
            }

            ++size;
        }

        public void Remove(int position)
        {
            if (size <= position)
                throw new ArgumentOutOfRangeException("Remove");

            FindPosition(position, out Node previousNode, out Node traveler);

            if (First != traveler) 
                previousNode.next = traveler.next;
            else
                First = First.next;
            traveler.next = null;
            --size;
        }

        public int Find(T data)
        {
            int position = -1;
            bool isOK = false;
            for (Node traveler = First; traveler != null; traveler = traveler.next)
            {
                ++position;
                if (traveler.data.Equals(data))
                {
                    isOK = true;
                    break;
                }
            }
            return (isOK) ? position : -1;
        }

        public IEnumerable<T> GetEnumerator()
        {
            for (Node traveler = First; traveler != null; traveler = traveler.next)
                yield return traveler.data;
        }

        private void FindPosition(int position, out Node previousNode, out Node traveler)
        {
            traveler = First;
            previousNode = null;

            for (int i = 0; i < position; ++i, traveler = traveler.next)
                previousNode = traveler;
        }

        private class Node
        {
            public T data;
            public Node next = null;

            public Node(T data) => this.data = data;
        }
    }
}