using System;

namespace v1lab5
{
    public sealed class Addition : BinaryOperation
    {
        public Addition(double a, double b)
            : base(a, b)
        {

        }

        public override string OperationCharacter
        {
            get
            {
                return "+";
            }
        }

        public override void Execute()
        {
            throw new NotImplementedException("");
        }
    }
}
