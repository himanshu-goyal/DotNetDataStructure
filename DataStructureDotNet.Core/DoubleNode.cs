using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureDotNet.Core
{
    public class DoubleNode
    {
        public DoubleNode()
        {
        }

        public DoubleNode(object value)
        {
            Value = value;
        }

        public object Value { get; set; }

        public DoubleNode next { get; set; }
        public DoubleNode previous { get; set; }
    }
}
