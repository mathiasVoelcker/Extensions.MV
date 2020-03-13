using System;

namespace Extensions.MV
{
    public static class TimeSpanExtension
    {
        ///<summary>
        ///Returns a period of time in short text format
        ///<para/>
        ///If it is less than an hour, return 'Recent' or text passed by parameter
        ///<para/>
        ///If it is less than a day, return number of hours as 'X H', where X is the number of hours
        ///<para/>
        ///If it is more than a day, return number of days as 'X D', where X is the number of days
        ///<para/>
        ///If it is more than 7 days, return number of weeks as 'X W', where X is the number of weeks
        ///</summary>
        public static string ToStringShort(this TimeSpan time, string recentText = null) {
            var days = time.Days;
            if (days < 1) {
                var hours = time.Hours;
                if (hours < 1)
                    return recentText ?? "Recent";
                return string.Format("{0}h", hours);
            }
            if (days >= 7)
                return string.Format("{0} W", days / 7);
            return string.Format("{0} D", days);
        }
    }
}