using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace PArray
{
    public interface IPArray<T> : IEnumerable<T>
    {

        // Take entity from the start
        T Shift();

        
        // Add entity to the top
        void Unshift(T entity);
        

        // Add entity to the end
        void Push(T entity);


        // Remove entity from the end
        T Pop();

        int Count { get; }
    }

    /// <summary>
    /// .NET Implementation of Perl's excellent Array
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PArray<T> : IPArray<T>
    {
        private readonly IList<T> referenceList;

        public PArray(IEnumerable<T> enumerable)
        {
            if (enumerable == null || !enumerable.Any())
            {
                throw new ArgumentException("Unable to initialize object with empty list");
            }
            this.referenceList = new List<T>(enumerable);
        }

        /// <summary>
        /// Remove entity from the start 
        /// </summary>
        /// <returns>Entity of type T</returns>
        public T Shift()
        {
            if (this.referenceList.Count == 0) return default;
            T retval = referenceList[0];
            referenceList.RemoveAt(0);
            return retval;
        }

        /// <summary>
        /// Add entity to the top
        /// </summary>
        /// <param name="entity">Entity of type T</param>
        public void Unshift(T entity)
        {
            referenceList.Insert(0, entity);
        }

        /// <summary>
        /// Add entity to the end 
        /// </summary>
        /// <param name="entity">Entity of type T</param>
        public void Push(T entity)
        {
            referenceList.Add(entity);
        }

        /// <summary>
        /// Add entity to the end
        /// </summary>
        /// <returns>Entity of type T</returns>
        public T Pop()
        {
            if (this.referenceList.Count == 0) return default;
            T retval = referenceList[referenceList.Count - 1];
            referenceList.RemoveAt(referenceList.Count-1);
            return retval;
        }

        /// <summary>
        /// Returns count of entities in list
        /// </summary>
        /// <returns>Integer</returns>
        public int Count => this.referenceList.Count;

        public IEnumerator<T> GetEnumerator()
        {
            return referenceList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
