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
    using System.Diagnostics.Contracts;

    /// <summary>
    /// The question 0103.
    /// </summary>
    public class Question0103
    {
        /// <summary> The is permutation. </summary>
        /// <param name="s1"> The s 1. </param>
        /// <param name="s2"> The s 2. </param>
        /// <returns> The <see cref="bool"/>. </returns>
        public static bool IsPermutation(string s1, string s2)
        {
            Contract.Requires(s1 != null);
            Contract.Requires(s2 != null);
            if (CornerCase(s1, s2))
            {
                return true;
            }

            return false;
        }

        /// <summary> The corner case. </summary>
        /// <param name="s1"> The s 1. </param>
        /// <param name="s2"> The s 2. </param>
        /// <returns> The <see cref="bool"/>. </returns>
        /// <exception cref="ArgumentException">
        /// </exception>
        private static bool CornerCase(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1))
            {
                throw new ArgumentException(s1);
            }

            if (string.IsNullOrEmpty(s2))
            {
                throw new ArgumentException(s2);
            }

            if (s1.Length == 1)
            {
                return true;
            }

            return false;
        }
    }

}
