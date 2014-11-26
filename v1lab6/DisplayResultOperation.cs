using System;

namespace v1lab6
{
    public sealed class DisplayResultOperation : UnaryOperation
    {
        public DisplayResultOperation(int number)
        {

        }

        public override string OperationCharacter
        {
            get
            {
                return "#";
            }
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return OperationCharacter + base.Argument;
        }
    }
}
