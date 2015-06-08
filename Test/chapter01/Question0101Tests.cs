// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Question0101Tests.cs" company="">
//   
// </copyright>
// <summary>//   The question 0101 tests.// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InterviewPrep.Chapter01.Tests
{
    using System;

    using FluentAssertions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary> The question 0101 tests. </summary>
    [TestClass()]
    public class Question0101Tests
    {
        /// <summary> The has unique characters test. </summary>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        [TestMethod()]
        public void HasNoCharactersTest()
        {
    
            var empty = string.Empty;
            Action act = () => Question0101.HasUniqueCharacters(empty).Equals(true);
            act.ShouldThrow<ArgumentNullException>();
        }

        /// <summary> The has unique characters test. </summary>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        [TestMethod()]
        public void IsNullTest()
        {
            Action act = () => Question0101.HasUniqueCharacters(null);
            act.ShouldThrow<ArgumentNullException>();
        }

        /// <summary> The has unique characters test. </summary>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        [TestMethod()]
        public void HasUniqueSingleCharacterTest()
        {
            const string Unique = @"A";

            Action act = () => Question0101.HasUniqueCharacters(Unique);
        }

        /// <summary> The has unique characters test. </summary>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        [TestMethod()]
        public void HasUniqueCharactersTest()
        {
            const string Unique = @"ABCDEFGHI";

            Action act = () => Question0101.HasUniqueCharacters(Unique);
        }

        /// <summary> The has unique characters test. </summary>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        [TestMethod()]
        public void HasDuplicateCharacterTest()
        {
            var duplicates = @"ABCDEFBGHI";
            Action act = () => Question0101.HasUniqueCharacters(duplicates).Equals(false);
        }

        /// <summary> The has unique characters test. </summary>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        [TestMethod()]
        public void HasUniqueSingleCharacterSpaceEfficientTest()
        {
            const string Unique = @"A";

            Action act = () => Question0101.HasUniqueCharactersSpaceEfficient(Unique);
        }

        /// <summary> The has unique characters test. </summary>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        [TestMethod()]
        public void HasUniqueCharactersSpaceEfficientTest()
        {
            const string Unique = @"ABCDEFGHI";

            Action act = () => Question0101.HasUniqueCharactersSpaceEfficient(Unique);
        }

        /// <summary> The has unique characters test. </summary>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        [TestMethod()]
        public void HasDuplicateCharacterSpaceEfficientTest()
        {
            var duplicates = @"ABCDEFBGHI";
            Action act = () => Question0101.HasUniqueCharactersSpaceEfficient(duplicates).Equals(false);
        }
    }
}