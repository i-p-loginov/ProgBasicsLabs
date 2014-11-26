using System;
using System.Collections.Generic;

namespace v8lab6
{
    /// <summary>
    /// Решалка уравнений
    /// </summary>
    public class EquationSolver
    {
        public EquationSolver()
        {
            throw new NotImplementedException("");
        }

        /// <summary>
        /// Получает коллекцию уравнений, с которыми работал пользователь.
        /// </summary>
        public IEnumerable<Equation> Equations
        {
            get
            {
                throw new NotImplementedException("");
            }
        }

        /// <summary>
        /// Возвращает уравнение по заданному индексу.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Equation this[int index]
        {
            get
            {
                throw new NotImplementedException("");
            }
        }

        /// <summary>
        /// Добавляет уравнение в коллекцию.
        /// </summary>
        /// <param name="equation"></param>
        public void Add(Equation equation)
        {
            throw new NotImplementedException("");
        }

        /// <summary>
        /// Удаляет уравнение из коллекции
        /// </summary>
        /// <param name="equation"></param>
        public void Remove(Equation equation)
        {
            throw new NotImplementedException("");
        }

        /// <summary>
        /// Получает уравнение по индексу
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Equation GetEquationAt(int index)
        {
            throw new NotImplementedException("");
        }
    }
}
