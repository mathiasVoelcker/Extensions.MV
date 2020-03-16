using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions.MV
{
    ///<summary>
    ///Group of extension methods for Intergers
    ///</summary>
    public static class IntExtension
    {
        ///<summary>
        ///Return the full month name for a given integer. 
        ///<para/> January is 1, not 0
        ///</summary>
        public static string ToMonth(this int month)
        {
            var data = new DateTime(1, month, 1);
            return data.GetMonth();
        }

        ///<summary>
        ///Return the short name of the month for a given integer. 
        ///<para/> January is 1, not 0
        ///</summary>
        public static string ToMonthShort(this int month)
        {
            var data = new DateTime(1, month, 1);
            return data.GetMonthShort();
        }
    }
}
