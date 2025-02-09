namespace ConsoleApp1.src.CreationalPatterns.Prototype.bad
{
    public class ShapeActions
    {
        public void Duplicate(Shape shape)
        {
            if (shape is Circle){
                var copiedShape = (Circle)shape; // this is the copied shape
                var newShape = new Circle();
                newShape.Radius = copiedShape.Radius;
                newShape.Draw();
            }
            else if (shape is Rectangle) {
                var copiedShape = (Rectangle)shape; // this is the copied shape
                var newShape = new Rectangle();
                newShape.Width = copiedShape.Width;
                newShape.Height = copiedShape.Height;
                newShape.Draw();
            }
            else {
                throw new ArgumentException("Invalid shape provided");
            }
        }
    }
}