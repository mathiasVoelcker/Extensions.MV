using System;

namespace Extensions.MV
{
    public static class TimeSpanExtension
    {
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