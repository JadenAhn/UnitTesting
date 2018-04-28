/* TriangleSolver.cs
 * Revision History
 *      Jaden Ahn, 2018-02-05: Created
 *      Jaden Ahn, 2018-02-06: Changed variable names from ~side to ~dimension
 *                             Added P4 header comments
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public static class TriangleSolver
    {
        public static string Analyze(int firstDimension, int secondDimension, int thirdDimension)
        {
            string result = "";

            if (firstDimension + secondDimension > thirdDimension &&
                firstDimension + thirdDimension > secondDimension &&
                secondDimension + thirdDimension > firstDimension)
            {
                if (firstDimension == secondDimension && secondDimension == thirdDimension)
                {
                    result = "Equilateral triangle";
                }
                else if (firstDimension == secondDimension ||
                        secondDimension == thirdDimension ||
                        firstDimension == thirdDimension)
                {
                    result = "Isosceles triangle";
                }
                else
                {
                    result = "Scalene triangle";
                }
            }
            else
            {
                result = "Do not form a triangle";
            }

            return result;
        }
    }
}
