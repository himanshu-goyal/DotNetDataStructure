using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureDotNet.Core
{
    public class DoublyLinkedList
    {
        public DoubleNode head { get; private set; }
        public DoubleNode tail { get; private set; }
        public int count { get; private set; }

        public DoublyLinkedList()
        {
            head = new DoubleNode();
            tail = head;
        }

        public void PrintList()
        {
            //Traverse from head
            Console.Write("Head ->");
            DoubleNode curr = head;
            while (curr != null)
            {
                Console.Write(curr.Value);
                curr = curr.next;
                Console.Write("->");
            }
            Console.Write("NULL");
        }

        public void AddAtStart(DoubleNode doubleNode)
        {
            if (count == 0)
            {
                head = doubleNode;
                tail = doubleNode;
            }
            else
            {
                DoubleNode temp = head;
                head = doubleNode;
                head.next = temp;
                temp.previous = head;
                count++;
            }
        }

        public void AddAtLast(DoubleNode doubleNode)
        {
            if (count == 0)
            {
                head = doubleNode;

            }
            else
            {
                tail.next = doubleNode;
                doubleNode.previous = tail;
            }
            tail = doubleNode;
            count++;
        }


        public void AddSpecific(DoubleNode node, int position)
        {
            DoubleNode current = head;
            int currentPosition = 0;
            if (position < 1 || position > count + 1)
            {
                Console.WriteLine("Invalid Position");
            }
            else
            {
                while (currentPosition <= position)
                {
                    if (currentPosition == position)
                    {
                        DoubleNode temp = current.next;
                        current.next = node;
                        node.previous = current;
                        node.next = temp;
                        temp.previous = node;
                    }
                    current = current.next;
                    currentPosition++;
                }
            }
        }

        public void RemoveSpecific(int position)
        {
            DoubleNode current = head;
            DoubleNode prev = null;
            int currentPosition = 0;
            if (position < 1 || position > count + 1)
            {
                Console.WriteLine("Invalid Position");
            }
            else
            {
                while (currentPosition <= position)
                {
                    if (position == 1)
                    {
                        head = null;
                        tail = null;
                    }
                    else if (currentPosition == position - 1)
                    {
                        prev = current;
                    }
                    else if (currentPosition == position)
                    {
                        prev.next = current.next;
                        current.next.previous = prev;
                    }
                    current = current.next;
                    currentPosition++;
                }
            }
        }

        public void RemoveFirst()
        {
            if (count != 0)
            {
                head = head.next;
                count--;
                if (count == 0)
                {
                    tail = null;
                }
                else
                {
                    head.previous = null;
                }
            }
        }

        public void RemoveLast()
        {
            if (count != 0)
            {
                if (count == 1)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    tail.previous.next = null;
                    tail = tail.previous;
                }
                count--;
            }
        }
    }
}
