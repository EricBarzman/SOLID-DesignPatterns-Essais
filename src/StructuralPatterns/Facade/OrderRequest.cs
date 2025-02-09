namespace ConsoleApp1.src.StructuralPatterns.Facade
{
    public class OrderRequest
    {
        public string Name { get; } = "danny";
        public string CardNumber { get; } = "1234";
        public float Amount { get; } = 20.99f;
        public string Address { get; } = "8930 Springfield Way, Washington State";
        public string[] ItemIds { get; } = { "123", "422", "555", "978" };
    }
}