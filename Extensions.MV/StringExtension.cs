﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Extensions.MV
{

    ///<summary>
    ///Group of extension methods for strings
    ///</summary>
    public static class StringExtension
    {
        ///<summary>
        ///Checks if a given string contains only number. If any char is not numeric, the return is false.
        ///</summary>
        public static bool IsDigitOnly(this string text)
        {
            foreach (char c in text)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        ///<summary>
        ///A simpler way to check if a string is null or empty
        ///</summary>
        public static bool IsNullOrEmpty(this string text)
        {
            return string.IsNullOrEmpty(text);
        }

        ///<summary>
        ///A simpler way to check if a string is null or whiteSpace
        ///</summary>
        public static bool IsNullOrWhiteSpace(this string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }

        ///<summary>
        ///Skip a line, then add a given string 
        ///</summary>
        public static string AddNewLine(this string text, string newLine)
        {
            text = text + Environment.NewLine + newLine;
            return text;
        }

        ///<sumary>
        ///Adds a given text to the start and the end of the string
        ///</sumary>
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

        ///<summary>
        ///Capitalize every word on a given string.
        ///<para/> If param <c>wordsLowerCase</c> is used, every word on array <c>wordsLowerCase</c> won't be Capitalized, but as lower case
        ///<para/> If param <c>wordsUpperCase</c> is used, every word on array <c>wordsUpperCase</c> won't be Capitalized, but as upper case
        ///</summary>
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

        ///<summary>
        ///Converts the first char of a string to UpperCase
        ///</summary>
        public static string Capitalize(this string text)
        {
            if (text.IsNullOrEmpty()) return "";
            if (text.Length == 1) return text.ToUpper();
            var fisrtLetter = text[0].ToString().ToUpper();
            var otherLetters = text.Substring(1).ToLower();
            return fisrtLetter + otherLetters;
        }

        ///<summary>
        ///Check if the list of strings contains a given string. It is not case-sensitive
        ///</summary>
        public static bool ContainsCaseIgnored(this string[] textList, string value)
        {
            return textList.Any(x => x.ToUpper() == value.ToUpper());
        }

        ///<summary>
        ///Check if the string contains a given string. It is not case-sensitive
        ///</summary>
        public static bool ContainsCaseIgnored(this string text, string value) {
            return text.ToUpper().Contains(value.ToUpper());
        }

        ///<summary>
        ///Split the string in every occurrence of a given string
        ///</summary>
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

        ///<summary>
        ///Remove all chars that are not letters or numbers
        ///</summary>
        public static string RemoveNonAlfanumeric(this string text) 
        {
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            return rgx.Replace(text, ""); 
        }

        ///<summary>
        ///Returns a decimal number. Returns 0 if the string is not a valid number.
        ///</summary>
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

        ///<summary>
        ///Returns a integer number. Returns 0 if the string is not a valid number.
        ///</summary>
        public static int ToInt(this string text)
        {
            int number = 0;
            int.TryParse(text, out number);
            return number;
        }

        ///<summary>
        ///Check if a string is a valid email
        ///</summary>
        public static bool IsValidEmail(this string text)
        {
            try {
                var addr = new System.Net.Mail.MailAddress(text);
                return addr.Address == text;
            }
            catch {
                return false;
            }
        }

        ///<summary>
        ///Shorten string to a given length, adding '...' at the end
        ///</summary>
        public static string ShortenText(this string text, int maxLenght)
        {
            if (maxLenght <= 3)
                throw new LengthToShortException();

            if (text.Length > maxLenght)
            {
                text = text.Substring(0, maxLenght - 3);
                text += "...";
            }

            return text;
        }
    }

    public class LengthToShortException : Exception
    {
        private const string MESSAGE = "Max length should be greater than 3";
        public LengthToShortException() : base(MESSAGE) { }
    }
}
