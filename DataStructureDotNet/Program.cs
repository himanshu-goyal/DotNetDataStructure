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
            Console.WriteLine("Choose any of the following");
            Node first = new Node { value = 3 };
            Node second = new Node { value = 4 };
            Node third = new Node { value = 5 };
            Node last = new Node { value = 10 };
            first.next = second;
            second.next = third;
            third.next = last;
            LinkListMethods linkListMethods = new LinkListMethods();
            linkListMethods.PrintList(first);
            Console.ReadKey();
        }
    }
}
