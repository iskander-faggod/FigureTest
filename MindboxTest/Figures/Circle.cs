using MindboxTest.Interfaces;

namespace MindboxTest.Figures;

public class Circle : IFigure
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius > 0
            ? radius
            : throw new ArgumentException($"{nameof(_radius)} is invalid, radius must be more then 0");
        ;
    }

    public double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}