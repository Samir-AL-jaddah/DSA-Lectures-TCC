using System;

namespace Linked_List_Homework
{
    public class LinkedList
    {
        public Node First { get; set; }

        public void Print()
        {
            Node move = First;
            while (move != null)
            {
                Console.Write(move.Data+"\t");
                move = move.Next;
            }
            Console.WriteLine();
        }

        // methods
        public bool IsEmpty()
        {
            return First == null;
        }
        public void Add(int val)
        {
            if (IsEmpty()) 
            {
                Node newNode = new Node(val);
                newNode.Next = First;
                First = newNode;
            }
            Node newNode1 = new Node(val);
            Node Move = First;
            while (Move.Next != null) Move = Move.Next;
            Move.Next = newNode1 ;
        }
        public void RemoveKey(int key)
        {
            Node current = First;
            Node previous = null;
            while (current != null)
            {
                if (IsEmpty()) return;
                if (First.Data == key) { First = First.Next; return; }
                if (current.Data == key)
                {
                    if (previous == null)
                    {
                        First = current.Next;
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }
                    return;
                }

                previous = current;
                current = current.Next;
            }
        }
        public void Merge(LinkedList other_list)
        {
            Node current = First;
            while (current != null)
            {
                this.Add(current.Data);
                current = current.Next;
            }

            current = other_list.First;
            while (current != null)
            {
                this.Add(current.Data);
                current = current.Next;
            }
        }
        public void Reverse()
        {
            Node previous = null;
            Node current = First;
            Node next = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            First = previous;
        }
    }
}
