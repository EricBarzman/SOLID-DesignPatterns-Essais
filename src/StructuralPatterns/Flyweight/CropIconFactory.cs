namespace ConsoleApp1.src.StructuralPatterns.Flyweight
{
    public class CropIconFactory
    {
        // Cache
        private Dictionary<CropType, CropIcon> _icons = new();

        public CropIcon GetCropIcon(CropType cropType) {
            
            // If this icon does not yet exists, add it
            if (!_icons.ContainsKey(cropType)) {
                var icon = new CropIcon(cropType, null);
                _icons.Add(cropType, icon);
            }

            return _icons[cropType];
        }
    }
}