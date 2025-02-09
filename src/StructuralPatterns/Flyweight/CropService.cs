namespace ConsoleApp1.src.StructuralPatterns.Flyweight
{
    public class CropService
    {
        private CropIconFactory _iconFactory;

        public CropService(CropIconFactory iconFactory)
        {
            _iconFactory = iconFactory;
        }

        public List<Crop> GetCrops() {
            List<Crop> cropList = new();

            // fetch from database
            var carrot = new Crop(1, 4, _iconFactory.GetCropIcon(CropType.Carrot));
            var carrot2 = new Crop(2, 3, _iconFactory.GetCropIcon(CropType.Carrot));
            var carrot3 = new Crop(2, 2, _iconFactory.GetCropIcon(CropType.Carrot));

            cropList.Add(carrot);
            cropList.Add(carrot2);
            cropList.Add(carrot3);

            return cropList;
        }
    }
}