using System;
using System.Collections.Generic;
using System.Linq;

namespace Extensions.MV
{
    ///<summary>
    ///Group of extension methods for Lists
    ///</summary>
    public static class ListExtension
    {
        ///<summary>
        ///Checks whether two lists have at least one element in common.
        ///<para/>
        ///The method Object.Equals is used to compare both elements.
        ///</summary>
        public static bool AnyEqualElement<T>(this List<T> thisList, List<T> listToCompare)
        {
            foreach (var elementA in thisList)
            {
                foreach (var elementB in listToCompare)
                {
                    if (elementA.Equals(elementB)) return true;
                }
            }
            return false;
        }

        ///<summary>
        ///Checks whether two lists have at least one element in common.
        ///<para/>
        ///The <code>areEqualFunc</code> parameter is a function used to compare both elements.
        ///<para/>
        ///Example of usage: <code>list1.AnyEqualElement(list2, (x, y) => x.Id == y.Id)</code>
        ///</summary>
        public static bool AnyEqualElement<T>(this List<T> thisList, List<T> listToCompare, Func<T,T, bool> areEqualFunc)
        {
            foreach(var elementA in thisList)
            {
                foreach(var elementB in listToCompare)
                {
                    if (areEqualFunc(elementA, elementB)) return true;
                }
            }
            return false;
        }

        ///<summary>
        ///Remove every element of the list that exists in a given list.
        ///<para/>
        ///The <code>areEqualFunc</code> parameter is a function used to compare both elements.
        ///<para/>
        ///Example of usage: <code>list1.RemoveEqualElements(list2, (x, y) => x.Id == y.Id)</code>
        ///</summary>
        public static List<T> RemoveEqualElements<T>(this List<T> thisList, List<T> listToCompare, Func<T,T, bool> areEqualFunc)
        {
            var removedElements = new List<T>();
            var i = 0;
            while(i < thisList.Count)
            {
                var elementA = thisList[i];
                if (listToCompare.Any(x => areEqualFunc(elementA, x)))
                {
                    thisList.RemoveAt(i);
                    removedElements.Add(elementA);
                }
                else 
                {
                    i++;
                }
            }

            return removedElements;
        }

        ///<summary>
        ///Remove every element of the list that exists in a given list.
        ///<para/>
        ///The method Object.Equals is used to compare both elements.
        ///</summary>
        public static List<T> RemoveEqualElements<T>(this List<T> thisList, List<T> listToCompare)
        {
            var removedElements = new List<T>();
            var i = 0;
            while(i < thisList.Count)
            {
                var elementA = thisList[i];
                if (listToCompare.Any(x => elementA.Equals(x)))
                {
                    thisList.RemoveAt(i);
                    removedElements.Add(elementA);
                }
                else 
                {
                    i++;
                }
            }

            return removedElements;
        }
    }
}