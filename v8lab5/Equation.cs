using System;
using System.Collections.Generic;

namespace v8lab5
{
    /// <summary>
    /// Описывает уравнение
    /// </summary>
    public class Equation
    {
        public Equation(params EquationMember[] members)
        {
            throw new NotImplementedException("");
        }

        /// <summary>
        /// Получает коллекцию элементов полинома.
        /// </summary>
        public IEnumerable<EquationMember> Members
        {
            get
            {
                throw new NotImplementedException("");
            }
        }

        /// <summary>
        /// Получает решения уравнения.
        /// </summary>
        public Solution Result
        {
            get;
            private set;
        }

        /// <summary>
        /// Выполняет решение уравнения.
        /// </summary>
        public void Solve()
        {
            throw new NotImplementedException("");
        }
    }
}
