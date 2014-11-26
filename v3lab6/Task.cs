using System;
using System.Collections.Generic;

namespace v3lab6
{
    public class Task
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Deadline { get; set; }

        public IEnumerable<string> Tags
        {
            get
            {
                throw new NotImplementedException("");
            }
        }

        public void AddTag(string tag)
        {
            throw new NotImplementedException("");
        }

        public void RemoveTag(string tag)
        {
            throw new NotImplementedException("");
        }

        public bool HasTag(string tag)
        {
            throw new NotImplementedException("");
        }
    }
}
