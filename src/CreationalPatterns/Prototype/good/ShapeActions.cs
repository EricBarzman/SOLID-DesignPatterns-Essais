namespace ConsoleApp1.src.CreationalPatterns.Prototype.good
{
    public class ShapeActions
    {
        public Shape Duplicate(Shape shape)
        {
            System.Console.WriteLine("Duplicating shape");
            return shape.Duplicate();
        }
    }
}