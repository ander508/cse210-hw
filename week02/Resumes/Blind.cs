public class Blind
{
    public double _height;
    public double _width;
    public string _color;
    
    public Blind(double height, double width, string color)
    {
        _height = height;
        _width = width;
        _color = color;
    }
    
    public double GetArea()
    {
        return _height * _width;
    }
    
    public void ShowInfo()
    {
        Console.WriteLine($"Blind Color: {_color}, Height: {_height}, Width: {_width}");
    }
}

