namespace ConsoleApp1.src.StructuralPatterns.Facade
{
    public class Inventory
    {
        public bool CheckInventory(string itemId)
        {
            return true;
        }

        public void ReduceInventory(string itemId, int amount)
        {
            System.Console.WriteLine("Reducing inventory of " + itemId + " by " + amount);
        }
    }
}