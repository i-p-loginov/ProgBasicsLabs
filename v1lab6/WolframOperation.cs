using System;

namespace v1lab6
{
    public sealed class WolframOperation
    {
        private WolframOperation()
        {
            throw new NotImplementedException("");
        }

        public WolframOperation(Operation operation)
        {
            throw new NotImplementedException("");
        }

        public Operation Operation { get; private set; }

        public override string ToString()
        {
            return base.ToString();
        }

        public static WolframOperation Parse(string str)
        {
            throw new NotImplementedException("");
        }
    }
}
