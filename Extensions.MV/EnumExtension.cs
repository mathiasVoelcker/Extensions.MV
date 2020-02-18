using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.MV
{
    public static class EnumExtension
    {

        /// <summary>
        /// Returns de Description of the Enum
        /// <para/>
        /// If the enum doesn't have a Description, returns the toString of the Enum
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetEnumDescription(this Enum value)
        {

            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }


        /// <summary>
        /// Check if a certain enum value contains the enum input. 
        /// This can be usefull if the enum contains more than one value
        /// <para/>
        /// Example: 
        /// <code> 
        /// (TestEnum.Value1 | TestEnum.Value2).Contains(TestEnum.Value1) == true
        /// </code>
        /// <para/>
        /// If the inputs contains values that this enum does not, it returns true.
        /// <code> 
        /// (TestEnum.Value1 | TestEnum.Value2).Contains(TestEnum.Value1 | TestEnum.Value4) == true
        /// </code>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool Contains(this Enum value, Enum input) {
            var valueInt = Convert.ToInt32(value);
            var inputInt = Convert.ToInt32(input);

            return (valueInt & inputInt) != 0;
        }

        /// <summary>
        /// Check if a certain enum value contains the enum input. 
        /// This can be usefull if the enum contains more than one value
        /// <para/>
        /// Example: 
        /// <code> 
        /// (TestEnum.Value1 | TestEnum.Value2).Contains(TestEnum.Value1) == true
        /// </code>
        /// <para/>
        /// If the inputs contains values that this enum does not, it returns false.
        /// <code> 
        /// (TestEnum.Value1 | TestEnum.Value2).Contains(TestEnum.Value1 | TestEnum.Value4) == false
        /// </code>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool ContainsAll(this Enum value, Enum input) {
            var valueCombined = Convert.ToInt32(value) & Convert.ToInt32(input);
            return valueCombined == Convert.ToInt32(input);
        }
    }
}
