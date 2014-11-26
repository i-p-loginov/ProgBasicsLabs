using System;

namespace v9lab6
{
    public sealed class PenColorChangingInfo : TurtleActionInfo
    {
        public PenColorChangingInfo(PenColors newColor)
        {
            throw new NotImplementedException("");
        }

        public PenColors NewColor
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
