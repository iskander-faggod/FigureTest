using MindboxTest.Interfaces;

namespace MindboxTest.Figures;

public class Triangle : IFigure
{
    private readonly double _firstEdge;
    private readonly double _secondEdge;
    private readonly double _thirdEdge;

    public Triangle(double firstEdge, double secondEdge, double thirdEdge)
    {
        _firstEdge = firstEdge > 0
            ? firstEdge
            : throw new ArgumentException($"{nameof(_firstEdge)} is invalid, edge must be more then 0");
        _secondEdge = secondEdge > 0
            ? secondEdge
            : throw new ArgumentException($"{nameof(_secondEdge)} is invalid, edge must be more then 0");
        _thirdEdge = thirdEdge > 0
            ? thirdEdge
            : throw new ArgumentException($"{nameof(_thirdEdge)} is invalid, edge must be more then 0");
        if (!IsTriangle())
        {
            throw new ArgumentException($"{nameof(Triangle)} is invalid, the figure is not triangle");
        }

        if (IsRightTriangle())
        {
            Console.WriteLine("Congratulations, you have a right triangle");
        }
    }

    public double GetArea()
    {
        // I can use one-line solution, but i think this code is more obvious 
        var halfPerimeter = GetHalfOfPerimeter();
        var a = halfPerimeter - _firstEdge;
        var b = halfPerimeter - _secondEdge;
        var c = halfPerimeter - _thirdEdge;
        var geronSquareWithoutSqrt = halfPerimeter * a * b * c;
        return Math.Pow(geronSquareWithoutSqrt, 0.5);
    }

    private double GetHalfOfPerimeter()
    {
        return (_firstEdge + _secondEdge + _thirdEdge) / 2;
    }

    public bool IsTriangle()
    {
        return _firstEdge + _secondEdge > _thirdEdge
               && _secondEdge + _thirdEdge > _firstEdge
               && _thirdEdge + _firstEdge > _secondEdge;
    }

    public bool IsRightTriangle()
    {
        return (Math.Abs(_firstEdge - Math.Sqrt(Math.Pow(_secondEdge, 2) + Math.Pow(_thirdEdge, 2))) < 0.01
                || Math.Abs(_secondEdge - Math.Sqrt(Math.Pow(_firstEdge, 2) + Math.Pow(_thirdEdge, 2))) < 0.01
                || Math.Abs(_thirdEdge - Math.Sqrt(Math.Pow(_firstEdge, 2) + Math.Pow(_secondEdge, 2))) < 0.01);
    }
}