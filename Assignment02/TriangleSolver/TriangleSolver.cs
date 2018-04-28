using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSolver
{
    public static class TriangleSolver
    {
        public static string Analyze(int firstSide, int secondSide, int thirdSide)
        {
            string result = "Hello";

            if (firstSide + secondSide > thirdSide &&
                firstSide + thirdSide > secondSide &&
                secondSide + thirdSide > firstSide)
            {
                result = "Form a triangle";
                if (firstSide == secondSide && secondSide == thirdSide)
                {
                    result += ": equilateral";
                }
                else if (firstSide == secondSide || secondSide == thirdSide || firstSide == thirdSide)
                {
                    result += ": isosceles";
                }
                else
                {
                    result += ": scalene";
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
