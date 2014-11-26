
namespace v1lab6
{
    public abstract class BinaryOperation : Operation
    {
        protected BinaryOperation(double arg1, double arg2)
        {
            this.Arg1 = arg1;
            this.Arg2 = arg2;
        }

        public double Arg1 { get; private set; }

        public double Arg2 { get; private set; }
    }
}
