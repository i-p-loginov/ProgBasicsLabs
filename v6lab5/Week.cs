using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace v6lab5
{
    public class Week
    {
        public Week(Month month, int weekNumber)
        {
            throw new NotImplementedException("");
        }

        /// <summary>
        /// Порядковый номер недели.
        /// </summary>
        public int WeekNumber { get; private set; }

        /// <summary>
        /// Месяц, к которому относится неделя
        /// </summary>
        public Month Month
        {
            get;
            private set;
        }

        /// <summary>
        /// Множество дней недели.
        /// </summary>
        public IEnumerable<Day> Days
        {
            get
            {
                throw new NotImplementedException("");
            }
        }
    }
}
