namespace ConsoleApp1.src.StructuralPatterns.Composite
{
    public class Mouse : IItem
    {
        private float _price = 10f;
        
        public float getPrice()
        {
            return _price;
        }
    }
}