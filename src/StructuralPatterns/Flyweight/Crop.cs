namespace ConsoleApp1.src.StructuralPatterns.Flyweight
{
    public class Crop
    {
        private int _x, _y;
        private CropIcon _cropIcon;

        public Crop(int x, int y, CropIcon cropIcon)
        {
            _x = x;
            _y = y;
            _cropIcon = cropIcon;
        }

        public void Render() {
            System.Console.WriteLine($"Drawing {_cropIcon.GetType()} at position {_x}' {_y}'");
        }
    }
}