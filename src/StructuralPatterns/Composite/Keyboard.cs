namespace ConsoleApp1.src.StructuralPatterns.Composite
{
    public class Keyboard : IItem
    {
        private float _price = 40f;
        
        public float getPrice()
        {
            return _price;
        }
    }
}