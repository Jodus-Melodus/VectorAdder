public class Vector(double magnitude, double direction)
{
    public double Magnitude { get; set; } = magnitude;
    public double Direction { get; set; } = direction;

    public void Display()
    {
        Console.WriteLine($"{Magnitude}N {Direction}");
    }

    public double XComponent()
    {
        return Magnitude * Math.Cos(ToRad(Direction));
    }

    public double YComponent()
    {
        return Magnitude * Math.Sin(ToRad(Direction));
    }

    static double ToRad(double Degrees)
    {
        return Degrees * Math.PI / 180.0;
    }
}
