namespace ConsoleApp1.src.StructuralPatterns.Adapter.Package
{
    public class Rainbow
    {
        public void Setup() {
            System.Console.WriteLine("Setting rainbow filter");
        }

        public void Update(Video video) {
            System.Console.WriteLine("Applying rainbow to video");
        }
    }
}