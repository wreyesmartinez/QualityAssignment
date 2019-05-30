using NUnit.Framework;
using QualityAssignment;

namespace Tests
{
    public class RectangleTests
    {
        [Test]
        public void GetLength_RetrivingLength_ReturnsTrue()
        {
            //Arrange
            var rectangle = new Rectangle();

            //Act
            var result = rectangle.GetLength();

            //Assert
            Assert.GreaterOrEqual(result, 1);
        }

        [Test]
        public void SetLength_LoadLength_ReturnsTrue()
        {
            //Arrange
            var rectangle = new Rectangle();

            //Act
            rectangle.SetLength(100);
            var result = rectangle.GetLength();

            //Assert
            Assert.AreEqual(result, 100);
        }

        [Test]
        public void GetWidth_RetrivingWidth_ReturnsTrue()
        {
            //Arrange
            var rectangle = new Rectangle();

            //Act
            var result = rectangle.GetWidth();

            //Assert
            Assert.GreaterOrEqual(result, 1);
        }

        [Test]
        public void SetWidth_LoadWidth_ReturnsTrue()
        {
            //Arrange
            var rectangle = new Rectangle();

            //Act
            rectangle.SetWidth(100);
            var result = rectangle.GetWidth();

            //Assert
            Assert.AreEqual(result, 100);
        }

        [Test]
        public void GetPerimeter_RetrivePerimeter_ReturnsTrue()
        {
            //Arrange
            var rectangle = new Rectangle();

            //Act
            rectangle.SetLength(43);
            rectangle.SetWidth(22);
            var result = rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(result, 130);
        }

        [Test]
        public void GetArea_RetriveArea_ReturnsTrue()
        {
            //Arrange
            var rectangle = new Rectangle();

            //Act
            rectangle.SetLength(12);
            rectangle.SetWidth(67);
            var result = rectangle.GetArea();

            //Assert
            Assert.AreEqual(result, 804);
        }

    }
}