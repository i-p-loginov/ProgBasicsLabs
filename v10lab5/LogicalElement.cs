
namespace v10lab5
{
    public abstract class LogicalElement
    {
        public readonly static LogicalElement True = new LogicalTrue();
        public readonly static LogicalElement False = new LogicalFalse();

        public abstract bool OutputValue { get; }

        public LogicalElement OutputElement { get; private set; }

        public void Connect(LogicalElement connectable)
        {
            this.OutputElement = connectable;
        }


    }
}
