namespace ConsoleApp1.src.SOLID.L
{
    public abstract class Square : Shape
    {
        public double SideLength { get; set; }
        public override double Area => SideLength * SideLength;
    }
}