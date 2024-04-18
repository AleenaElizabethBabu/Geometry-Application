using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void TestTriangleArea()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);

        // Act
        var result = triangle.CalculateArea();

        // Assert
        Assert.AreEqual(6, result);
    }

    [TestMethod]
    public void TestTrianglePerimeter()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);

        // Act
        var result = triangle.CalculatePerimeter();

        // Assert
        Assert.AreEqual(12, result);
    }
}
