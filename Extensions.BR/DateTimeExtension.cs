using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.BR
{
    ///<summary>
    ///Grupo de métodos de extensão para DateTime
    ///</summary>
    public static class DateTimeExtension
    {
        /// <summary>
        /// Converte DateTime para time zone de brasilia
        /// </summary>
        public static DateTime ConverterTimeZoneBrasilia(this DateTime date)
        {
            return TimeZoneInfo.ConvertTime(date, TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time"));
        }
    }
}
