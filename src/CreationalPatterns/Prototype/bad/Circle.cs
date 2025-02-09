namespace ConsoleApp1.src.CreationalPatterns.Prototype.bad
{
    public class Circle : Shape
    {
        public int Radius { get; set; } = 5;

        public void Draw()
        {
            System.Console.WriteLine("Drawing circle");
        }
    }
}