using System;

namespace v10lab5
{
    public class LogicalXor : BinaryElement
    {
        public LogicalXor(LogicalElement input1, LogicalElement input2)
            : base(input1, input2)
        {
            throw new NotImplementedException("");
        }

        public LogicalXor(bool inputValue1, bool inputValue2)
            : base(inputValue1, inputValue2)
        {
            throw new NotImplementedException("");
        }

        public override bool OutputValue
        {
            get { throw new NotImplementedException(); }
        }
    }
}
