using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.MV
{
    ///<summary>
    ///Group of extension methods for Exceptions
    ///</summary>
    public static class ExceptionExtension
    {
        /// <summary>
        /// Create a string with the exception message and stacktrace and it's Inner Exceptions
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        public static string FullExceptionLog(this Exception ex)
        {
            var error = ex.FormatExceptionMessage();

            ex = ex.InnerException;
            for (int i = 0; i < 10 && ex != null; i++)
            {
                var errorMessage = "Inner Exception: " + ex.FormatExceptionMessage();
                error = error.AddNewLine(errorMessage);
                ex = ex.InnerException;
            }
            error = error.AddNewLine(new string('*', 150));
            return error;
        }

        /// <summary>
        /// Create a string for a specific Exception on the format 
        /// <para/>
        /// Message: [message]
        /// <para/>
        /// StackTrace: [message]
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        public static string FormatExceptionMessage(this Exception ex)
        {
            if (ex.StackTrace.IsNullOrEmpty()){
                return string.Format("Message: {0}", ex.Message);
            }
            return string.Format("Message: {0} \t StackTrace: {1}", ex.Message, ex.StackTrace);
        }
    }
}
