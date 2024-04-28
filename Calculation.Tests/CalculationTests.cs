namespace Calculation.Tests;
public class CalculationTests
{
    [Fact]
    public void GetArea_from_incorrect_triangle()
    {
        // Arrange
        double firstSide = 1;
        double secondSide = 2;
        double thirdSide = 3;
        double expectedArea = -1;

        // Act
        double actualArea = AreaCalculation.GetArea(firstSide, secondSide, thirdSide);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void GetArea_from_incorrect_circle()
    {
        // Arrange
        double radius = 0;
        double expectedArea = -1;

        // Act
        double actualArea = AreaCalculation.GetArea(radius);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void IsRightTriangle_ShouldReturnTrue()
    {
        // Arrange
        double firstSide = 3;
        double secondSide = 4;
        double thirdSide = 5;

        // Act
        bool isRightTriangle = AreaCalculation.IsTriangleRight(firstSide, secondSide, thirdSide);

        // Assert
        Assert.True(isRightTriangle);
    }

    [Fact]
    public void IsRightTriangle_ShouldReturnFalse()
    {
        // Arrange
        double firstSide = 3;
        double secondSide = 4;
        double thirdSide = 6;

        // Act
        bool isRightTriangle = AreaCalculation.IsTriangleRight(firstSide, secondSide, thirdSide);

        // Assert
        Assert.False(isRightTriangle);
    }

    [Fact]
    public void GetAreaByTriangle_ShouldReturnCorrectArea()
    {
        // Arrange
        double firstSide = 3;
        double secondSide = 4;
        double thirdSide = 6;
        double expectedArea = 5.332682251925386;

        // Act
        double actualArea = AreaCalculation.GetArea(firstSide,secondSide, thirdSide);

        // Assert
        Assert.Equal(expectedArea, actualArea, 10);
    }

    [Fact]
    public void GetAreaByCircle_ShouldReturnCorrectArea()
    {
        // Arrange
        double radius = 1;
        double expectedArea = Math.PI;

        // Act
        double actualArea = AreaCalculation.GetArea(radius);

        // Assert
        Assert.Equal(expectedArea, actualArea, 10);
    }
}