
namespace ConsoleApp1.src.SOLID.I
{
    public class Circle : IShape3D
    {
        public double Radius { get; set; }
        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double Volume()
        {
            throw new InvalidOperationException("Volume not applicable to 2D Shape");
        }
    }
}