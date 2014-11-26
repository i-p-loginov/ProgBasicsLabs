using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace v3lab5
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
