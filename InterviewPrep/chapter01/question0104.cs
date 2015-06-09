// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Question0104.cs" company="">
//   
// </copyright>
// <summary>
//   The question 0104.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
/**

Write a method to replace all spaces in a string with'%20'. You may assume that
the string has sufficient space at the end of the string to hold the additional
characters, and that you are given the "true" length of the string. in place.)

EXAMPLE
Input: "Mr John Smith
Output: "Mr%20Dohn%20Smith"

**/
namespace InterviewPrep.Chapter01
{
    using System;
    using System.Diagnostics.Contracts;

    /// <summary> The question 0104. </summary>
    public class Question0104
    {
        /// <summary> The replace space. </summary>
        /// <param name="s"> The s. </param>
        /// <returns> The <see cref="string"/>. </returns>
        public static string ReplaceSpace(string s)
        {
            Contract.Requires(s != null);
            if (CornerCase(s))
            {
                return string.Empty;
            }

            return string.Empty;
        }

        /// <summary> The replace space.  </summary>
        /// <param name="s"> The s.  </param>
        public static void ReplaceSpace(ref string s)
        {
            Contract.Requires(s != null);
            if (CornerCase(s))
            {
                s = string.Empty;
            }
        }


        /// <summary> The corner case. </summary>
        /// <param name="s"> The s. </param> <returns>
        /// The <see cref="bool"/>. </returns> <exception cref="ArgumentException">
        /// </exception>
        private static bool CornerCase(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                throw new ArgumentException(s);
            }

            return s.Length == 1;
        }
    }
}
