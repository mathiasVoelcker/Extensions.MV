using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions.MV
{
    public static class IntExtension
    {
        public static string ToMonth(this int month)
        {
            var data = new DateTime(1, month, 1);
            return data.GetMonth();
        }

        public static string ToMonthShort(this int month)
        {
            var data = new DateTime(1, month, 1);
            return data.GetMonthShort();
        }
    }
}
