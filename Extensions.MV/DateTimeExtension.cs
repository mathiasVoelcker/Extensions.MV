using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions.MV
{
    ///<summary>
    ///Group of extension methods for DateTime
    ///</summary>
    public static class DateTimeExtension
    {

        ///<summary>
        ///Return the month as a string
        ///</summary>
        public static string GetMonth(this DateTime date)
        {
            return date.ToString("MMMM").Capitalize();
        }

        ///<summary>
        ///Return the month as a short string
        ///</summary>
        public static string GetMonthShort(this DateTime date)
        {
            return date.ToString("MMM").Capitalize();
        }

        ///<summary>
        ///Return a DateTime equivalent to the last day of the month of the given Date
        ///</summary>
        public static DateTime GetLastDayOfMonth(this DateTime date) {
            date = new DateTime(date.Year, date.Month, 1);
            date = date.AddMonths(1);
            date = date.AddDays(-1);
            return date;
        }
    }
}
