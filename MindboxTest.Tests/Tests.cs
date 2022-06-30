using MindboxTest.Figures;
using MindboxTest.Service;
using NUnit.Framework;

namespace MindboxTest.Tests;

public class Tests
{
    [Test]
    public void IsTriangle()
    {
        var triangle = new Triangle(24,10,26);
        Assert.AreEqual(true, triangle.IsTriangle());
    }
    
    [Test]
    public void IsNotTriangle()
    {
        Assert.Catch<ArgumentException>(() =>
        {
            var triangle = new Triangle(1, 10, 26);
            var triangle2 = new Triangle(-1, -10, -26);
        });
    }
    
    [Test]
    public void IsNotCircle()
    {
        Assert.Catch<ArgumentException>(() =>
        {
            var circle = new Circle(-1);
        });
    }
    
    [Test]
    public void IsRightTriangle()
    {
        var triangle = new Triangle(24,10,26);
        Assert.AreEqual(true, triangle.IsRightTriangle());
    }

    [Test]
    public void CorrectCircleAreaAndTriangleArea()
    {
        var circle = new Circle(2);
        var triangle = new Triangle(24,10,26);
        var handler = new Handler(circle);
        Assert.AreEqual(handler.Handle(), 12.566370614359172);
        handler.SetFigure(triangle);
        Assert.AreEqual(handler.Handle(), 120);
    }
}