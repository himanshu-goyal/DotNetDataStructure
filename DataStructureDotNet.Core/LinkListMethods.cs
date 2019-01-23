using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureDotNet.Core
{
    public class LinkListMethods
    {
        public void PrintList(Node node)
        {
            while(node!=null)
            {
                Console.WriteLine(node.value);
                node = node.next;
            }
        }
    }
}
