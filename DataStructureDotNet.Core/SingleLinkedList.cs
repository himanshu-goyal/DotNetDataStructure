using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureDotNet.Core
{
    public class SingleLinkedList
    {
        public Node head { get; private set; }
        public Node tail { get; private set; }
        public int count { get; private set; }

        public SingleLinkedList()
        {
            head = new Node();
            tail = head;
        }

        public void PrintList()
        {
            //Traverse from head
            Console.Write("Head ->");
            Node curr = head;
            while (curr != null)
            {
                Console.Write(curr.Value);
                curr = curr.next;
                Console.Write("->");
            }
            Console.Write("NULL");
        }

        public void AddAtStart(Node node)
        {
            if(count==0)
            {
                head = node;
                tail = node;
            }
            else
            {
                Node temp = head;
                head = node;
                head.next = temp;
                count++;
            }
        }

        public void AddAtLast(Node node)
        {
            if (count == 0)
            {
                head = node;
                
            }
            else
            {
                tail.next = node;
            }
            tail = node;
            count++;
        }


        public void AddSpecific(Node node,int position)
        {
            Node current = head;
            int currentPosition = 0;
            if(position<1 || position>count+1)
            {
                Console.WriteLine("Invalid Position");
            }
            else
            {
                while(currentPosition <= position)
                {
                    if(currentPosition==position)
                    {
                        Node temp = current.next;
                        current.next = node;
                        node.next = temp;
                    }
                    current = current.next;
                    currentPosition++;
                }
            }
        }

        public void RemoveSpecific(int position)
        {
            Node current = head;
            Node previous = null;
            int currentPosition = 0;
            if (position < 1 || position > count + 1)
            {
                Console.WriteLine("Invalid Position");
            }
            else
            {
                while(currentPosition <= position)
                {
                    if(position==1)
                    {
                        head = null;
                        tail = null;
                    }
                    else if(currentPosition == position -1)
                    {
                        previous = current;
                    }
                    else if(currentPosition==position)
                    {
                        previous.next = current.next;
                    }
                    current = current.next;
                    currentPosition++;
                }
            }
        }

        public void RemoveFirst()
        {
            if(count!=0)
            {
                head = head.next;
                count--;
                if(count==0)
                {
                    tail = null;
                }
            }
        }

        public void RemoveLast()
        {
            if(count!=0)
            {
                if(count==1)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    Node current = head;
                    while (current.next != tail)
                    {
                        current = current.next;
                    }
                    current.next = null;
                    tail = current;
                }
                count--;
            }
        }
    }
}
