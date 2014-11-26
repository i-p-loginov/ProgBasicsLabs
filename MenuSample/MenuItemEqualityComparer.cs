using System;
using System.Collections.Generic;

namespace MenuSample
{
    internal class MenuItemEqualityComparer : IEqualityComparer<MenuItem>
    {
        public bool Equals(MenuItem x, MenuItem y)
        {
            if (x == null && y == null)
            {
                return true;
            }

            if (x == null || y == null)
            {
                return false;
            }

            return string.Equals(x.Text, y.Text, StringComparison.CurrentCultureIgnoreCase);
        }

        public int GetHashCode(MenuItem obj)
        {
            return obj.Text.GetHashCode() * 12 + obj.Command.GetHashCode() * 65;
        }
    }
}
