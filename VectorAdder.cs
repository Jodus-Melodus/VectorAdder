
public class VectorAdder(List<Vector> vectors)
{

    public List<Vector> Vectors { get; set; } = vectors;

    public static Vector VectorFromComponents(double XComponent, double YComponent)
    {
        double resultantMagnitude = Math.Sqrt(Math.Pow(XComponent, 2) + Math.Pow(YComponent, 2));
        double resultantDirection = ToDeg(Math.Atan2(YComponent, XComponent));

        return new Vector(resultantMagnitude, resultantDirection);
    }

    static double ToDeg(double Radians)
    {
        return Radians * 180.0 / Math.PI;
    }

    public Vector Add()
    {
        double totalXComponents = 0;
        double totalYComponents = 0;

        foreach (Vector vector in Vectors)
        {
            totalXComponents += vector.XComponent();
            totalYComponents += vector.YComponent();
        }

        return VectorFromComponents(totalXComponents, totalYComponents);
    }
}