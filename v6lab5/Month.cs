using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace v6lab5
{
    public class Month
    {
        public Month(Year year, int month)
        {
            throw new NotImplementedException("");
        }

        /// <summary>
        /// Год, которому принадлежит этот месяц.
        /// </summary>
        public Year Year { get; private set; }

        /// <summary>
        /// Название месяца.
        /// </summary>
        public MonthNames MonthName { get; private set; }

        /// <summary>
        /// Недели месяца.
        /// </summary>
        public IEnumerable<Week> Weeks
        {
            get
            {
                throw new NotImplementedException("");
            }
        }
    }
}
