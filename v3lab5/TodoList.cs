﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace v3lab5
{
    public class TodoList
    {
        public IEnumerable<Task> Tasks
        {
            get
            {
                throw new NotImplementedException("");
            }
        }

        public IEnumerable<Task> CompletedTasks
        {
            get
            {
                throw new NotImplementedException("");
            }
        }

        public IEnumerable<Task> UncompletedTasks
        {
            get
            {
                throw new NotImplementedException("");
            }
        }

        public void Add(Task task)
        {
            throw new NotImplementedException("");
        }

        public void Remove(Task task)
        {
            throw new NotImplementedException("");
        }

        public IEnumerable<Task> Search(params string[] tags)
        {
            throw new NotImplementedException("");
        }
    }
}
