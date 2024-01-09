namespace _2_OCP.InCurrect;

public class Circle
{
    public double Radius { get; set; }

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }
}
