// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Question0103.cs" company="">
//   
// </copyright>
// <summary>
//   The question 0103.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

/**
    Given two strings, write a method to decide if one is a permutation of the other.
**/
namespace InterviewPrep.Chapter01
{
    using System;

    /// <summary>
    ///     The question 0103.
    /// </summary>
    public class Question0103
    {
        /// <summary>
        /// The is permutation. 
        /// </summary>
        /// <param name="s1">
        /// The s 1. 
        /// </param>
        /// <param name="s2">
        /// The s 2. 
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>. 
        /// </returns>
        /// <exception cref="ArgumentException">
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="array"/> is null.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// One or more elements in <paramref name="array"/> do not implement the
        ///     <see cref="T:System.IComparable`1"/> generic interface.
        /// </exception>
        public static bool IsPermutation(string s1, string s2)
        {
            if (CornerCase(s1, s2))
            {
                return true;
            }

            var x = s1.ToCharArray(); // Could be s1.ToArray   <== Linq
            Array.Sort(x);
            var y = s2.ToCharArray(); // Could be s2.ToArray   <== Linq
            Array.Sort(y);

            // Could be new string(str.OrderBy(c => c).ToArray())  <== concise but not faster
            return new string(x) == new string(y);
        }

        /// <summary>
        /// The corner case. 
        /// </summary>
        /// <param name="s1">
        /// The s 1. 
        /// </param>
        /// <param name="s2">
        /// The s 2. 
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>. 
        /// </returns>
        /// <exception cref="ArgumentException">
        /// </exception>
        private static bool CornerCase(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1))
            {
                throw new ArgumentNullException(s1);
            }

            if (string.IsNullOrEmpty(s2))
            {
                throw new ArgumentNullException(s2);
            }

            if (s1.Length != s2.Length)
            {
                throw new ArgumentException("String Lengths differ");
            }

            if (s1.Length == 1)
            {
                return true;
            }

            return false;
        }
    }
}