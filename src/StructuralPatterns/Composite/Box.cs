namespace ConsoleApp1.src.StructuralPatterns.Composite
{
    public class Box : IItem
    {
        private List<IItem> _items = new List<IItem>();
        
        public void Add(IItem item) {
            _items.Add(item);
        }

        public float getPrice()
        {
            float total = 0f;
            foreach (IItem item in _items)
                total += item.getPrice();
            
            return total;
        }
    }
}