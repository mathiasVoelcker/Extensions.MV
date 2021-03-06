    This package aims to promote extensions to C# string, enums and exceptions

```xml
<?xml version="1.0"?>
<doc>
    <assembly>
        <name>Extensions.MV</name>
    </assembly>
    <members>
        <member name="T:Extensions.MV.DateTimeExtension">
            <summary>
            Group of extension methods for DateTime
            </summary>
        </member>
        <member name="M:Extensions.MV.DateTimeExtension.GetMonth(System.DateTime)">
            <summary>
            Return the month as a string
            </summary>
        </member>
        <member name="M:Extensions.MV.DateTimeExtension.GetMonthShort(System.DateTime)">
            <summary>
            Return the month as a short string
            </summary>
        </member>
        <member name="M:Extensions.MV.DateTimeExtension.GetLastDayOfMonth(System.DateTime)">
            <summary>
            Return a DateTime equivalent to the last day of the month of the given Date
            </summary>
        </member>
        <member name="T:Extensions.MV.EnumExtension">
            <summary>
            Group of extension methods for Enums
            </summary>
        </member>
        <member name="M:Extensions.MV.EnumExtension.GetEnumDescription(System.Enum)">
            <summary>
            Returns the Description of the Enum
            <para/>
            If the enum doesn't have a Description, returns the toString of the Enum
            </summary>
            <param name="value"></param>
            <returns></returns>
        </member>
        <member name="M:Extensions.MV.EnumExtension.GetValueByDescription(System.Type,System.String)">
            <summary>
            Returns the EnumValue of the given description.
            <para/>
            How to use: var response = typeof(MyEnum).GetValueByDescription("MyDescription");
            <line/>
            var value = (MyEnum)response;
            </summary>
        </member>
        <member name="M:Extensions.MV.EnumExtension.Contains(System.Enum,System.Enum)">
            <summary>
            Check if a certain enum value contains the enum input. 
            This can be usefull if the enum contains more than one value
            <para/>
            Example: 
            <code> 
            (TestEnum.Value1 | TestEnum.Value2).Contains(TestEnum.Value1) == true
            </code>
            <para/>
            If the inputs contains values that this enum does not, it returns true.
            <code> 
            (TestEnum.Value1 | TestEnum.Value2).Contains(TestEnum.Value1 | TestEnum.Value4) == true
            </code>
            </summary>
            <param name="value"></param>
            <param name="input"></param>
            <returns></returns>
        </member>
        <member name="M:Extensions.MV.EnumExtension.ContainsAll(System.Enum,System.Enum)">
            <summary>
            Check if a certain enum value contains the enum input. 
            This can be usefull if the enum contains more than one value
            <para/>
            Example: 
            <code> 
            (TestEnum.Value1 | TestEnum.Value2).Contains(TestEnum.Value1) == true
            </code>
            <para/>
            If the inputs contains values that this enum does not, it returns false.
            <code> 
            (TestEnum.Value1 | TestEnum.Value2).Contains(TestEnum.Value1 | TestEnum.Value4) == false
            </code>
            </summary>
            <param name="value"></param>
            <param name="input"></param>
            <returns></returns>
        </member>
        <member name="T:Extensions.MV.ExceptionExtension">
            <summary>
            Group of extension methods for Exceptions
            </summary>
        </member>
        <member name="M:Extensions.MV.ExceptionExtension.FullExceptionLog(System.Exception)">
            <summary>
            Create a string with the exception message and stacktrace and it's Inner Exceptions
            </summary>
            <param name="ex"></param>
            <returns></returns>
        </member>
        <member name="M:Extensions.MV.ExceptionExtension.FormatExceptionMessage(System.Exception)">
            <summary>
            Create a string for a specific Exception on the format 
            <para/>
            Message: [message]
            <para/>
            StackTrace: [message]
            </summary>
            <param name="ex"></param>
            <returns></returns>
        </member>
        <member name="T:Extensions.MV.IntExtension">
            <summary>
            Group of extension methods for Intergers
            </summary>
        </member>
        <member name="M:Extensions.MV.IntExtension.ToMonth(System.Int32)">
            <summary>
            Return the full month name for a given integer. 
            <para/> January is 1, not 0
            </summary>
        </member>
        <member name="M:Extensions.MV.IntExtension.ToMonthShort(System.Int32)">
            <summary>
            Return the short name of the month for a given integer. 
            <para/> January is 1, not 0
            </summary>
        </member>
        <member name="T:Extensions.MV.ListExtension">
            <summary>
            Group of extension methods for Lists
            </summary>
        </member>
        <member name="M:Extensions.MV.ListExtension.AnyEqualElement``1(System.Collections.Generic.List{``0},System.Collections.Generic.List{``0})">
            <summary>
            Checks whether two lists have at least one element in common.
            <para/>
            The method Object.Equals is used to compare both elements.
            </summary>
        </member>
        <member name="M:Extensions.MV.ListExtension.AnyEqualElement``1(System.Collections.Generic.List{``0},System.Collections.Generic.List{``0},System.Func{``0,``0,System.Boolean})">
            <summary>
            Checks whether two lists have at least one element in common.
            <para/>
            The <code>areEqualFunc</code> parameter is a function used to compare both elements.
            </summary>
        </member>
        <member name="T:Extensions.MV.StringExtension">
            <summary>
            Group of extension methods for strings
            </summary>
        </member>
        <member name="M:Extensions.MV.StringExtension.IsDigitOnly(System.String)">
            <summary>
            Checks if a given string contains only number. If any char is not numeric, the return is false.
            </summary>
        </member>
        <member name="M:Extensions.MV.StringExtension.IsNullOrEmpty(System.String)">
            <summary>
            A simpler way to check if a string is null or empty
            </summary>
        </member>
        <member name="M:Extensions.MV.StringExtension.IsNullOrWhiteSpace(System.String)">
            <summary>
            A simpler way to check if a string is null or whiteSpace
            </summary>
        </member>
        <member name="M:Extensions.MV.StringExtension.AddNewLine(System.String,System.String)">
            <summary>
            Skip a line, then add a given string 
            </summary>
        </member>
        <member name="M:Extensions.MV.StringExtension.SurroundWith(System.String,System.String)">
            <sumary>
            Adds a given text to the start and the end of the string
            </sumary>
        </member>
        <member name="M:Extensions.MV.StringExtension.ToDateTime(System.String,System.String)">
            <sumary>
            Transform string into dateTime. Returns null if parse is not successful
            </sumary>
        </member>
        <member name="M:Extensions.MV.StringExtension.CapitalizeSentence(System.String,System.String[],System.String[])">
            <summary>
            Capitalize every word on a given string.
            <para/> If param <c>wordsLowerCase</c> is used, every word on array <c>wordsLowerCase</c> won't be Capitalized, but as lower case
            <para/> If param <c>wordsUpperCase</c> is used, every word on array <c>wordsUpperCase</c> won't be Capitalized, but as upper case
            </summary>
        </member>
        <member name="M:Extensions.MV.StringExtension.Capitalize(System.String)">
            <summary>
            Converts the first char of a string to UpperCase
            </summary>
        </member>
        <member name="M:Extensions.MV.StringExtension.ContainsCaseIgnored(System.String[],System.String)">
            <summary>
            Check if the list of strings contains a given string. It is not case-sensitive
            </summary>
        </member>
        <member name="M:Extensions.MV.StringExtension.ContainsCaseIgnored(System.String,System.String)">
            <summary>
            Check if the string contains a given string. It is not case-sensitive
            </summary>
        </member>
        <member name="M:Extensions.MV.StringExtension.Split(System.String,System.String)">
            <summary>
            Split the string in every occurrence of a given string
            </summary>
        </member>
        <member name="M:Extensions.MV.StringExtension.RemoveNonAlfanumeric(System.String)">
            <summary>
            Remove all chars that are not letters or numbers
            </summary>
        </member>
        <member name="M:Extensions.MV.StringExtension.ToDecimal(System.String)">
            <summary>
            Returns a decimal number. Returns 0 if the string is not a valid number.
            </summary>
        </member>
        <member name="M:Extensions.MV.StringExtension.ToInt(System.String)">
            <summary>
            Returns a integer number. Returns 0 if the string is not a valid number.
            </summary>
        </member>
        <member name="T:Extensions.MV.TimeSpanExtension">
            <summary>
            Group of extension methods for strings
            </summary>
        </member>
        <member name="M:Extensions.MV.TimeSpanExtension.ToStringShort(System.TimeSpan,System.String)">
            <summary>
            Returns a period of time in short text format
            <para/>
            If it is less than an hour, return 'Recent' or text passed by parameter
            <para/>
            If it is less than a day, return number of hours as 'X H', where X is the number of hours
            <para/>
            If it is more than a day, return number of days as 'X D', where X is the number of days
            <para/>
            If it is more than 7 days, return number of weeks as 'X W', where X is the number of weeks
            </summary>
        </member>
    </members>
</doc>
```
