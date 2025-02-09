namespace ConsoleApp1.src.StructuralPatterns.Composite
{
    public class Microphone : IItem
    {
        private float _price = 30f;
        
        public float getPrice()
        {
            return _price;
        }
    }
}