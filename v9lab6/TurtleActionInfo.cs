﻿
namespace v9lab6
{
    public abstract class TurtleActionInfo
    {
        public string Name
        {
            get
            {
                var typename = this.GetType().Name;

                return typename.Substring(0, typename.IndexOf("Info"));
            }
        }
    }
}
