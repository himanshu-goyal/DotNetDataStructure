using DataStructureDotNet.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDotNet
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Press any of the following number for data structure operations\n");
            Console.WriteLine("1.Singly Linked List Basic Operations(Add at Start, add at end, remove at start, remove from end, adding at specific position)");
            int input = int.Parse(Console.ReadLine());
            SingleLinkedList singleLinkedList = new SingleLinkedList();
            switch (input)
            {
                case 1:
                    singleLinkedList.PrintList();
                    Console.WriteLine("\n");
                    Console.WriteLine("Adding items at last");
                    singleLinkedList.AddAtLast(new Node(12));
                    singleLinkedList.AddAtLast(new Node("Goyal"));
                    singleLinkedList.AddAtLast(new Node("Himanshu"));
                    singleLinkedList.AddAtLast(new Node(34));
                    Console.WriteLine("\n");
                    Console.WriteLine("Adding items at start\n");
                    singleLinkedList.AddAtStart(new Node(1));
                    singleLinkedList.PrintList();
                    Console.WriteLine("\n");
                    Console.WriteLine("Adding items at position 2");
                    singleLinkedList.AddSpecific(new Node("Special"), 2);
                    singleLinkedList.PrintList();
                    Console.WriteLine("\n");
                    Console.WriteLine("Removing item at start");
                    singleLinkedList.RemoveFirst();
                    singleLinkedList.PrintList();
                    Console.WriteLine("\n");
                    Console.WriteLine("Removing items at last");
                    singleLinkedList.RemoveLast();
                    Console.WriteLine("\n");
                    singleLinkedList.PrintList();
                    Console.WriteLine("\nRemove at 2nd Position\n");
                    singleLinkedList.RemoveSpecific(3);
                    singleLinkedList.PrintList();
                    Console.WriteLine("\nRemove at 3rd Position\n");
                    singleLinkedList.RemoveSpecific(2);
                    singleLinkedList.PrintList();
                    Console.WriteLine("\n");
                    break;
                case 2:
                    break;
            }
            Console.ReadKey();
        }
    }
}
