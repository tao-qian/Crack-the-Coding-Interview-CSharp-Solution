// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Question0103Tests.cs" company="">
//   
// </copyright>
// <summary>
//   The question 0103 tests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace InterviewPrep.Chapter01.Tests
{
    using System;

    using FluentAssertions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    ///     The question 0103 tests.
    /// </summary>
    [TestClass]
    public class Question0103Tests
    {
        /// <summary> The has unique characters test. </summary>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        /// <exception cref="ArgumentNullException"> array is null. </exception>
        /// <exception cref="InvalidOperationException">
        ///     One or more elements in array do not implement the
        ///     <see cref="T:System.IComparable`1" /> generic interface.
        /// </exception>
        /// <exception cref="ArgumentException"> </exception>
        [TestMethod]
        public void HasNoCharactersTest()
        {
            Action act = () => Question0103.IsPermutation(string.Empty, string.Empty);
            act.ShouldThrow<ArgumentNullException>();
        }

        /// <summary> The has unique characters test. </summary>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        /// <exception cref="ArgumentNullException"> array is null. </exception>
        /// <exception cref="InvalidOperationException">
        ///     One or more elements in array do not implement the
        ///     <see cref="T:System.IComparable`1" /> generic interface.
        /// </exception>
        /// <exception cref="ArgumentException"> </exception>
        [TestMethod]
        public void HasNoCharactersOrNullTest()
        {
            Action act = () => Question0103.IsPermutation(string.Empty, null);
            act.ShouldThrow<ArgumentNullException>();
        }

        /// <summary> The has unique characters test. </summary>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        /// <exception cref="ArgumentException"> </exception>
        /// <exception cref="ArgumentNullException"><paramref name="array" /> is null.</exception>
        /// <exception cref="InvalidOperationException">
        ///     One or more elements in <paramref name="array" /> do not implement the
        ///     <see cref="T:System.IComparable`1" /> generic interface.
        /// </exception>
        [TestMethod]
        public void HasNoCharactersOrNull2Test()
        {
            Action act = () => Question0103.IsPermutation(null, string.Empty);
            act.ShouldThrow<ArgumentNullException>();
        }

        /// <summary> The has unique characters test. </summary>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        /// <exception cref="ArgumentException"> </exception>
        /// <exception cref="ArgumentNullException"><paramref name="array" /> is null.</exception>
        /// <exception cref="InvalidOperationException">
        ///     One or more elements in <paramref name="array" /> do not implement the
        ///     <see cref="T:System.IComparable`1" /> generic interface.
        /// </exception>
        [TestMethod]
        public void IsNullTest()
        {
            Action act = () => Question0103.IsPermutation(null, null);
            act.ShouldThrow<ArgumentNullException>();
        }

        /// <summary>
        ///     The is permutation test.
        /// </summary>
        /// <exception cref="ArgumentException"> </exception>
        /// <exception cref="ArgumentNullException"><paramref name="array" /> is null.</exception>
        /// <exception cref="InvalidOperationException">
        ///     One or more elements in <paramref name="array" /> do not implement the
        ///     <see cref="T:System.IComparable`1" /> generic interface.
        /// </exception>
        [TestMethod]
        public void IsPermutationIdenticalTest()
        {
            var oneString = "asd;lfkj;aslkdjf";

            Action act = () => Question0103.IsPermutation(oneString, oneString);
        }

        /// <summary>
        ///     The is permutation test.
        /// </summary>
        /// <exception cref="ArgumentException"> </exception>
        /// <exception cref="ArgumentNullException"><paramref name="array" /> is null.</exception>
        /// <exception cref="InvalidOperationException">
        ///     One or more elements in <paramref name="array" /> do not implement the
        ///     <see cref="T:System.IComparable`1" /> generic interface.
        /// </exception>
        [TestMethod]
        public void IsPermutationTest()
        {
            var oneString = "asd;lfkj;aslkdjf";

            var twoString = "dsa;lfkj;alksfjd";

            Action act = () => Question0103.IsPermutation(oneString, twoString);
        }
    }
}