namespace ConsoleApp1.src.CreationalPatterns.Prototype.bad
{
    public class Rectangle : Shape
    {
        public int Width { get; set; } = 10;
        public int Height { get; set; } = 5;

        public void Draw()
        {
            System.Console.WriteLine("Drawing rectangle");
        }
    }
}