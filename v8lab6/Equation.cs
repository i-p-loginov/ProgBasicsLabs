using System;
using System.Collections.Generic;

namespace v8lab6
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
        /// Показывает, решено ли уравнение.
        /// </summary>
        public bool Solved
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

        /// <summary>
        /// Получает экземпляр Equation из EquationFileModel
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static Equation LoadFrom(EquationFileModel model)
        {
            throw new NotImplementedException("");
        }
    }
}
