using System;

namespace Extensions.BR
{
    public static class TimeSpanExtension
    {
        public static string TextoCurto(this TimeSpan time, string textoRecente = null) {
            var days = time.Days;
            if (days < 1) {
                var hours = time.Hours;
                if (hours < 1)
                    return textoRecente ?? "Recente";
                return string.Format("{0}h", hours);
            }
            if (days >= 7)
                return string.Format("{0} Sem", days / 7);
            return string.Format("{0} D", days);
        }
    }
}