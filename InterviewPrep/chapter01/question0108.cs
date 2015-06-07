// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Question0108.cs" company="">
//   
// </copyright>
// <summary>
//   The question 0108.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

/**
Assume you have a method isSubstring which checks if one word is a
substring of another. Given two strings, si and s2, write code to check if s2 is
a rotation of si using only one call to isSubstring (e.g.,"waterbottle"is a rotation
of "erbottlewat").
**/
namespace InterviewPrep.Chapter01
{
    /// <summary> The question 0108. </summary>
    public class Question0108
    {
        /// <summary> The is rotation. </summary>
        /// <param name="s1"> The s 1. </param>
        /// <param name="s2"> The s 2. </param>
        /// <returns> The <see cref="bool"/>. </returns>
        public static bool IsRotation(string s1, string s2)
        {
            return s2 == s1;
        }
    }
}
