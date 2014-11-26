using System;

namespace v9lab6
{
    public sealed class PenStateChangingInfo : TurtleActionInfo
    {
        public PenStateChangingInfo(PenState newState)
        {
            throw new NotImplementedException("");
        }

        public PenState PenState
        {
            get;
            private set;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
