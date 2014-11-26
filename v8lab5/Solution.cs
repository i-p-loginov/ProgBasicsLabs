using System;
using System.Collections.Generic;

namespace v8lab5
{
    /// <summary>
    /// Информация о решении уравнения.
    /// </summary>
    public class Solution
    {
        public Solution(Equation equation, params double[] roots)
        {
            throw new NotImplementedException("");
        }

        /// <summary>
        /// Уравнение, для которого это решение.
        /// </summary>
        public Equation Equation
        {
            get
            {
                throw new NotImplementedException("");
            }
        }

        /// <summary>
        /// Показывает, если корни у уравнения (действительные числа).
        /// </summary>
        public bool HasRoots
        {
            get
            {
                throw new NotImplementedException("");
            }
        }

        /// <summary>
        /// Коллекция действительных решений.
        /// </summary>
        public IEnumerable<double> Roots
        {
            get
            {
                throw new NotImplementedException("");
            }
        }
    }
}
