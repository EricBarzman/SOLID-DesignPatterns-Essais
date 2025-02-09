namespace ConsoleApp1.src.StructuralPatterns.Facade
{
    public class OrderFullfillment
    {
        private Inventory _inventory;

        public OrderFullfillment(Inventory inventory)
        {
            _inventory = inventory;
        }

        public void Fullfill(string name, string address, string[] items)
        {
            System.Console.WriteLine("Inserting order into database");
            foreach (var item in items)
                _inventory.ReduceInventory(item, 1);
        }
    }
}