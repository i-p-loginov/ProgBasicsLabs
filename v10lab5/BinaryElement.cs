using System;

namespace v10lab5
{
    public abstract class BinaryElement : LogicalElement
    {
        public BinaryElement(LogicalElement input1, LogicalElement input2)
        {
            throw new NotImplementedException("");
        }

        public BinaryElement(bool input1, bool input2)
        {
            throw new NotImplementedException("");
        }

        public LogicalElement FirstInput { get; private set; }

        public LogicalElement SecondInput { get; private set; }
    }
}
