using System.Collections.Generic;

namespace _20180315_Task1
{
    /// <summary>
    /// The generic class that searches for values in the list.
    /// </summary>
    /// <typeparam name="T">The type parameter.</typeparam>
    internal class GenericClass<T>
    {
        private readonly List<T> list;

        /// <summary>
        /// The constructor of GenericClass class.
        /// </summary>
        /// <param name="list">List of parameters.</param>
        public GenericClass(List<T> list)
        {
            this.list = list;
        }

        /// <summary>
        /// The method Search() that searches for values in the list.
        /// </summary>
        /// <param name="value">The search value.</param>
        /// <returns>The result of the value search. True - if the value is found and the False - if the value is not found.</returns>
        public bool Search(T value)
        {
            return list.Contains(value);
        }
    }
}