using MindboxTest.Interfaces;

namespace MindboxTest.Service;

public class Handler : IHandler
{
    // About compile time
    private IFigure _figure;

    public Handler(IFigure figure)
    {
        _figure = figure is not null
            ? figure
            : throw new ArgumentNullException($"{nameof(_figure)} is invalid, figure can't be null");
    }

    public void SetFigure(IFigure figure)
    {
        _figure = figure ?? throw new ArgumentNullException($"{nameof(figure)} is invalid, figure to set can't be null");
    }
    public double Handle()
    {
        return _figure.GetArea();
    }
}