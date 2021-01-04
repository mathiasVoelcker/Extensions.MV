namespace Extensions.MV
{
    ///<summary>
    ///Group of extension methods for arrays
    ///</summary>
    public static class ArrayExtension
    {

        ///<summary>
        ///Adds a given element to the end of the array
        ///</summary>
        public static T[] Add<T>(this T[] array, T newEl)
        {
            if (array == null)
                return new T[] { newEl };
            else 
            {
                T[] temp = new T[array.Length + 1];
                for(int i = 0; i < array.Length; i++)
                    temp[i] = array[i];
                
                temp[array.Length] = newEl;
                
                return temp;
            }
        }

        ///<summary>
        ///Adds a given element to the start of the array
        ///</summary>
        public static T[] AddInStart<T>(this T[] array, T newEl)
        {
            if (array == null)
                return new T[] { newEl };
            else 
            {
                T[] temp = new T[array.Length + 1];
                for(int i = 1; i <= array.Length; i++)
                    temp[i] = array[i - 1];
                
                temp[0] = newEl;
                
                return temp;
            }
        }

        ///<summary>
        ///Adds a given element to the array at a given index
        ///</summary>
        public static T[] AddAt<T>(this T[] array, T newEl, int n)
        {
            if (array == null)
                return new T[] { newEl };
            else 
            {
                T[] temp = new T[array.Length + 1];
                for (int i = 0; i < n; i++)
                    temp[i] = array[i];
                temp[n] = newEl;
                for (int i = (n + 1); i < temp.Length; i++)
                {
                    temp[i] = array[i - 1];
                }
                return temp;
            }
        }
    }
}