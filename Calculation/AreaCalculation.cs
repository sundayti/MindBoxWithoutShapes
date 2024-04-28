namespace Calculation;
public static class AreaCalculation
{
    public static double GetArea(double radius)
    {
        if (radius <= 0)
        {
            return -1;
        }

        return Math.PI * radius * radius;
    }

    public static double GetArea(double firstSide, double secondSide, double thirdSide)
    {
        if (!IsTriangleExist(firstSide, secondSide, thirdSide))
        {
            return -1;
        }

        if (IsTriangleRight(firstSide, secondSide, thirdSide))
        {
            double[] sides = { firstSide, secondSide, thirdSide };
            Array.Sort(sides);
            return sides[0] * sides[1] / 2;
        }

        double p = (firstSide + secondSide + thirdSide) / 2;
        return Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
    }

    private static bool IsTriangleExist(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            return false;
        }

        return a + b > c && a + c > b && b + c > a;
    }


    public static bool IsTriangleRight(double a, double b, double c)
    {
        double[] sides = { a, b, c };
        Array.Sort(sides);

        return Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) <
               Double.Epsilon;
    }
}
