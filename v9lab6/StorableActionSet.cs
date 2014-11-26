using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace v9lab6
{
    public class StorableActionSet
    {
        public StorableActionSet()
        {
            this.Actions = new ReadOnlyCollection<StorableActionInfo>(new StorableActionInfo[] { });
        }

        public IEnumerable<StorableActionInfo> Actions
        {
            get;
            private set;
        }

        public IEnumerable<TurtleActionInfo> TurtleActions
        {
            get
            {
                return this.Actions.Select(a => a.ActionInfo).ToArray();
            }
        }

        public void Load(string path)
        {
            throw new NotImplementedException("");
        }

        public void Save(string path)
        {
            throw new NotImplementedException("");
        }
    }
}
