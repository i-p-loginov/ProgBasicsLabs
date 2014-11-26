using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace v6lab5
{
    public class Day
    {
        public Day(Week week, int number)
        {
            throw new NotImplementedException("");
        }

        /// <summary>
        /// Неделя, которой принадлежит этот день.
        /// </summary>
        public Week Week { get; private set; }

        /// <summary>
        /// День недели
        /// </summary>
        public DayOfWeek DayOfWeek { get; private set; }
    }
}
