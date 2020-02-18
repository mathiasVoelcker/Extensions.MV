using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Extensions.MV
{
    public static class StringExtension
    {
        public static bool IsDigitOnly(this string text)
        {
            foreach (char c in text)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        public static bool IsNullOrEmpty(this string text)
        {
            return string.IsNullOrEmpty(text);
        }

        public static bool IsNullOrWhiteSpace(this string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }

        public static string AddNewLine(this string text, string newLine)
        {
            text = text + Environment.NewLine + newLine;
            return text;
        }

        public static string SurroundWith(this string text, string value)
        {
            if (text.IsNullOrEmpty()) return null;
            return string.Concat(value, text.ToUpper(), value);
        }

        ///<sumary>
        ///Transform string into dateTime. Returns null if parse is not successful
        ///</sumary>
        public static DateTime? ToDateTime(this string text, string format = "dd/MM/yyyy")
        {
            try
            {
                var dateTime = DateTime.ParseExact(text, format, CultureInfo.InvariantCulture);
                return dateTime;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string CapitalizeSentence(this string text, string[] wordsLowerCase = null, string[] wordsUpperCase = null)
        {
            if (text.IsNullOrEmpty()) return text;
            var sentence = "";
            var words = text.Split(' ');
            foreach (var word in words)
            {
                if (wordsUpperCase != null && wordsUpperCase.ContainsCaseIgnored(word))
                    sentence += word.ToUpper() + " ";
                else if (wordsLowerCase != null && wordsLowerCase.ContainsCaseIgnored(word))
                    sentence += word.ToLower() + " ";
                else sentence += word.Capitalize() + " ";
            }
            return sentence.TrimEnd();
        }

        public static string Capitalize(this string text)
        {
            if (text.IsNullOrEmpty()) return "";
            if (text.Length == 1) return text.ToUpper();
            var fisrtLetter = text[0].ToString().ToUpper();
            var otherLetters = text.Substring(1).ToLower();
            return fisrtLetter + otherLetters;
        }

        public static bool ContainsCaseIgnored(this string[] textList, string value)
        {
            return textList.Any(x => x.ToUpper() == value.ToUpper());
        }

        public static bool ContainsCaseIgnored(this string text, string value) {
            return text.ToUpper().Contains(value.ToUpper());
        }

        public static string[] Split(this string text, string value)
        {
            try
            {
                return text.Split(new string[] { value }, StringSplitOptions.None);
            } catch (Exception)
            {
                return new string[] { text };
            }
        }

        public static string RemoveNonAlfanumeric(this string text) 
        {
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            return rgx.Replace(text, ""); 
        }

        public static decimal ToDecimal(this string text)
        {
            try
            {
                return decimal.Parse(text.Replace('.', ','));
            } catch (Exception)
            {
                return 0;
            }
        }

        public static int ToInt(this string text)
        {
            int number = 0;
            int.TryParse(text, out number);
            return number;
        }
    }
}
