
namespace v1lab5
{
    public abstract class Operation
    {
        
        public double Result { get; protected set; }

        public bool Calculated { get; protected set; }

        public abstract string OperationCharacter { get; }

        public abstract void Execute();
    }
}
