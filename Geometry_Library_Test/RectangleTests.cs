using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class RectangleTests
{
    [TestMethod]
    public void TestRectangleArea()
    {
        // Arrange
        var rectangle = new Rectangle(4, 6);

        // Act
        var result = rectangle.CalculateArea();

        // Assert
        Assert.AreEqual(24, result);
    }

    [TestMethod]
    public void TestRectanglePerimeter()
    {
        // Arrange
        var rectangle = new Rectangle(4, 6);

        // Act
        var result = rectangle.CalculatePerimeter();

        // Assert
        Assert.AreEqual(20, result);
    }
}
