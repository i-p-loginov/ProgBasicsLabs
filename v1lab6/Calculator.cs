using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace v1lab6
{
    public sealed class Calculator
    {
        private readonly List<Operation> _operations = new List<Operation>();

        public Operation this[int index]
        {
            get
            {
                throw new NotImplementedException("");
            }
        }

        /// <summary>
        /// Получает коллекцию операций.
        /// </summary>
        public IEnumerable<Operation> Operations
        {
            get
            {
                return new ReadOnlyCollection<Operation>(_operations.ToArray());
            }
        }

        /// <summary>
        /// Осуществляет операцию, сохраняя её в лог.
        /// </summary>
        /// <param name="operation"></param>
        public void Calculate(Operation operation)
        {
            throw new NotImplementedException("");
        }

    }
}
