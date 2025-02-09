namespace ConsoleApp1.src.StructuralPatterns.Flyweight
{
    public class CropIcon
    {
        private readonly CropType _type;
        private readonly byte[] _icon;

        public CropIcon(CropType type, byte[] icon)
        {
            _type = type;
            _icon = icon;
        }

        public CropType GetType()
        {
            return _type;
        }
    }
}