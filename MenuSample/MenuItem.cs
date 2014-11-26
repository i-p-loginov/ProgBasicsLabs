using System;

namespace MenuSample
{
    public class MenuItem
    {
        private readonly Action itemHandler = null;

        public MenuItem(string text, string command, Action selectionHandler)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException("text");
            }
            
            this.Text = text;
            this.Command = command;
            this.itemHandler = selectionHandler;
        }

        public string Text { get; private set; }

        public string Command { get; private set; }

        public bool ClearScreen { get; set; }

        public void ExecuteAction()
        {
            if (this.itemHandler != null)
            {
                this.itemHandler();
            }            
        }

        public override string ToString()
        {
            string formatString = "{0} " + (string.IsNullOrWhiteSpace(this.Command) ? "{1}" : "({1})");
            return string.Format(formatString, this.Text, this.Command);
        }
    }
}
