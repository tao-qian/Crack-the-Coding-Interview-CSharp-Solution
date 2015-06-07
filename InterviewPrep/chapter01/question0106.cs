using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
Given an image represented by an NxN matrix, where each pixel in the image is
4 bytes, write a method to rotate the image by 90 degrees. Can you do this in
place?
**/
namespace InterviewPrep.Chapter01
{
    class Question0106
    {
        static int[][] RotateImage(int[][] image)
        {
            System.Diagnostics.Contracts.Contract.Requires(image.Any());
            System.Diagnostics.Contracts.Contract.Requires(image != null);

            // stub
            return new[] { new[] { 2, 4, 6 }, new[] { 1, 3, 5, 7, 9 } };
        }
    }
}
