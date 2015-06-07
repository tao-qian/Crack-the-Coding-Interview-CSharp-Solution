/**
   Implement an algorithm to determine if a string has all unique characters.
**/
namespace InterviewPrep.Chapter01
{
    using System;
    using System.Collections.Concurrent;
    using System.Diagnostics.Contracts;
    using System.Threading.Tasks;

    /// <summary> Question 0101: Does the string have unique characters? </summary>
    public class Question0101
    {
        /// <summary> Does the string have unique characters.   </summary>
        /// <param name="s"> The s.  </param>
        /// <exception cref="AggregateException"> The exception that contains all the individual exceptions thrown on all threads. </exception>
        /// <exception cref="OverflowException"> The dictionary already contains the maximum number of elements, <see cref="F:System.Int32.MaxValue"/>. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is a null reference (Nothing in Visual Basic). </exception>
        /// <returns> The <see cref="bool"/>. </returns>
        public static bool HasUniqueCharacters(string s)
        {
            // Contract.Requires(s != null);
            if (CornerCase(s))
            {
                return true;
            }

            var cd = new ConcurrentDictionary<char, bool>();
            var unique = true;
            Parallel.ForEach(s, c =>
                {
                    if (cd.ContainsKey(c))
                    {
                        unique = false;

                        // TODO: Optimization: Add Cancellation token handling
                    }

                    cd.GetOrAdd(c, true);
                });
            return unique;
        }

        /// <summary> Does the string have unique characters 
        ///            What if you cannot use additional data structures?
        /// </summary>
        /// <param name="s"> The s. </param>
        /// <returns> The <see cref="bool"/>. </returns>
        public static bool HasUniqueCharactersSpaceEfficient(string s)
        {
            // Contract.Requires(s != null);
            if (CornerCase(s))
            {
                return true;
            }

            for (var i = 0; i < s.Length; i++)
            {
                for (var j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        return false;
                    }
                }
            }

            return true;
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