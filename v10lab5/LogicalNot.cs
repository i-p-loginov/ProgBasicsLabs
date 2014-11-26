using System;

namespace v10lab5
{
    public sealed class LogicalNot : UnaryElement
    {
        public LogicalNot(LogicalElement input)
            : base(input)
        {
            throw new NotImplementedException("");
        }

        public LogicalNot(bool inputValue)
            : base(inputValue)
        {
            throw new NotImplementedException("");
        }

        public override bool OutputValue
        {
            get { throw new NotImplementedException(); }
        }
    }
}
