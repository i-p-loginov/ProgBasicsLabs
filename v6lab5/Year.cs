using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace v6lab5
{
    public class Year
    {
        public Year(int year)
        {
            throw new NotImplementedException("");
        }

        /// <summary>
        /// Год.
        /// </summary>
        public int YearNumber
        {
            get;
            private set;
        }

        /// <summary>
        /// Возвращает коллекцию месяцев этого года.
        /// </summary>
        public IEnumerable<Month> Months
        {
            get
            {
                throw new NotImplementedException("");
            }
        }

        /// <summary>
        /// Показывает, является ли год високосным.
        /// </summary>
        public bool IsLeap
        {
            get
            {
                throw new NotImplementedException("");
            }
        }

        /// <summary>
        /// Вычисляет интервал до определённой даты.
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public DateTime TimeFrom(DateTime time)
        {
            throw new NotImplementedException("");
        }
    }
}
