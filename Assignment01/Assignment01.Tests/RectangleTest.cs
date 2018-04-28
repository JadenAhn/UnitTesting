/* RectangleTest.cs
 * Revision History
 *      Jaden Ahn, 2018-01-30: Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Assignment01.Tests
{
    [TestFixture]
    
    public class RectangleTest
    {

        [Test]
        public void GetLength_Expect1()
        {
            //Arrange
            Rectangle r = new Rectangle(1, 1);

            //Act
            int result = r.GetLength();

            //Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void SetLength_GiveLength4_Expect4()
        {
            //Arrange
            Rectangle r = new Rectangle(2, 3);

            //Act
            int result = r.SetLength(4);

            //Assert
            Assert.AreEqual(4, result);
        }

        [Test]
        public void GetWidgth_Expect2()
        {
            //Arrange
            Rectangle r = new Rectangle(3, 2);

            //Act
            int result = r.GetWidth();

            //Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void SetWidth_GiveWidth2_Expect2()
        {
            //Arrange
            Rectangle r = new Rectangle(7, 3);

            //Act
            int result = r.SetWidth(2);

            //Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void GetPerimeter_GiveLength2Width3_Expect10()
        {
            //Arrange
            Rectangle r = new Rectangle(2, 3);

            //Act
            int result = r.GetPerimeter();

            //Assert
            Assert.AreEqual(10, result);
        }

        [Test]
        public void GetArea_GiveLength4Width5_Expect20()
        {
            //Arrange
            Rectangle r = new Rectangle(4, 5);

            //Act
            int result = r.GetArea();

            //Assert
            Assert.AreEqual(20, result);
        }

    }
}
