using System;

namespace DataStructureDotNet.Core
{
    public class Node
    {
        public Node()
        {
        }

        public Node(object value)
        {
            Value = value;
        }

        public object Value { get; set; }

        public Node next { get; set; }
    }
}
