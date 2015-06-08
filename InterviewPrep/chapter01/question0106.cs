// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Question0106.cs" company="">
//   
// </copyright>
// <summary>
//   The question 0106.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

 /**
Given an image represented by an NxN matrix, where each pixel in the image is
4 bytes, write a method to rotate the image by 90 degrees. Can you do this in
place?
**/

namespace InterviewPrep.Chapter01
{
    using System.Diagnostics.Contracts;
    using System.Linq;

    /// <summary>
    /// The question 0106.
    /// </summary>
    public class Question0106
    {
        /// <summary>
        /// The rotate image.
        /// </summary>
        /// <param name="image">
        /// The image.
        /// </param>
        /// <returns>
        /// The <see cref="int[][]"/>.
        /// </returns>
        public static int[][] RotateImage(int[][] image)
        {
            Contract.Requires(image.Any());
            Contract.Requires(image != null);

            // stub
            return new[] { new[] { 2, 4, 6 }, new[] { 1, 3, 5, 7, 9 } };
        }
    }
}