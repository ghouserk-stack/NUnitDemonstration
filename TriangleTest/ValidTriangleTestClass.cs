
using NUnit.Framework;
using NUnit.Framework.Legacy;
using NUnitDemonstration;



namespace TriangleTest
{
    public class ValidTriangleTestClass
    {

        [Test]
        public void ValidTriangleTest()
        {
            //Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;

            string expected = ("The triangle is valid");

            //Act

            string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            //Assert

            ClassicAssert.AreEqual(expected, actual);
        }

       /* public void InValidTriangleTest()
        {
            //Arrange
            int firstAngle = 60;
            int secondAngle = 90;
            int thirdAngle = 60;

            string expected = ("The triangle is not valid");

            //Act

            string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            //Assert

            ClassicAssert.AreEqual(expected, actual);
        }*/


    }
}
