namespace ConsoleApp1.src.CreationalPatterns.Prototype.good
{
    public class Circle : Shape
    {
        public int Radius { get; set; } = 5;

        public void Draw()
        {
            System.Console.WriteLine("Drawing circle");
        }

        public Shape Duplicate()
        {
            var newCircle = new Circle();
            newCircle.Radius = Radius;
            return newCircle;
        }
    }
}