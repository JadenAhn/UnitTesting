/* TriangleSolverTest.cs
 * Revision History
 *      Jaden Ahn, 2018-02-05: Created
 *      Jaden Ahn, 2018-02-06: Added more test cases
 *                             Added P4 header comments
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Assignment02.Tests
{
    [TestFixture]
    public class TriangleSolverTest
    {
        
        [Test]
        //Give three different numbers with ascending order which form a triangle: 3, 4, and 5 to test Scalene triangle
        public void Analyze_Give3and4and5_ExpectScaleneTriangle()
        {
            //Arrange

            //Act
            string result = TriangleSolver.Analyze(3, 4, 5);

            //Assert
            Assert.AreEqual("Scalene triangle", result);
        }

        [Test]
        //Give three different numbers with descending order which form a triangle: 5, 4, and 3 to test Scalene triangle
        public void Analyze_Give5and4and3_ExpectScaleneTriangle()
        {
            //Arrange

            //Act
            string result = TriangleSolver.Analyze(5, 4, 3);

            //Assert
            Assert.AreEqual("Scalene triangle", result);
        }

        [Test]
        //Give two same numbers and one different number which form a triangle: 4, 4, and 5 to test Isosceles triangle
        public void Analyze_Give4and4and5_ExpectIsoscelesTriangle()
        {
            //Arrange

            //Act
            string result = TriangleSolver.Analyze(4, 4, 5);

            //Assert
            Assert.AreEqual("Isosceles triangle", result);
        }

        [Test]
        //Give three same numbers which form a triangle: 5, 5, and 5 to test Equilateral triangle
        public void Analyze_Give5and5and5_ExpectEquilateralTriangle()
        {
            //Arrange

            //Act
            string result = TriangleSolver.Analyze(5, 5, 5);

            //Assert
            Assert.AreEqual("Equilateral triangle", result);
        }


        [Test]
        //Give three different numbers which do not form a triangle: 1, 2, and 3 to test no triangle
        public void Analyze_Give1and2and3_ExpectNoTriagle()
        {
            //Arrange

            //Act
            string result = TriangleSolver.Analyze(1, 2, 3);

            //Assert
            Assert.AreEqual("Do not form a triangle", result);
        }


        [Test]
        //Give two same numbers and one different negative number, which do not form a triangle: 4, 4, and -5 to test no triangle
        public void Analyze_Give4and4andNegative5_ExpectNoTriagle()
        {
            //Arrange

            //Act
            string result = TriangleSolver.Analyze(4, 4, -5);

            //Assert
            Assert.AreEqual("Do not form a triangle", result);
        }

        [Test]
        //Give two same numbers and one different number including 0, which do not form a triangle: 4, 4, and 0 to test no triangle
        public void Analyze_Give4and4and0_ExpectNoTriagle()
        {
            //Arrange

            //Act
            string result = TriangleSolver.Analyze(4, 4, 0);

            //Assert
            Assert.AreEqual("Do not form a triangle", result);
        }

        [Test]
        //Give three same negative numbers, which do not form a triangle: -5, -5, and -5 to test no triangle
        public void Analyze_GiveNegative5andNegative5andNegative5_ExpectNoTriagle()
        {
            //Arrange

            //Act
            string result = TriangleSolver.Analyze(-5, -5, -5);

            //Assert
            Assert.AreEqual("Do not form a triangle", result);
        }
    }
}
