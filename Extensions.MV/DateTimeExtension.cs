using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions.MV
{
    public static class DateTimeExtension
    {
        public static string GetMonth(this DateTime date)
        {
            return date.ToString("MMMM").Capitalize();
        }

        public static string GetMonthShort(this DateTime date)
        {
            return date.ToString("MMM").Capitalize();
        }

        public static DateTime GetLastDayOfMonth(this DateTime date) {
            date = new DateTime(date.Year, date.Month, 1);
            date = date.AddMonths(1);
            date = date.AddDays(-1);
            return date;
        }
    }
}
