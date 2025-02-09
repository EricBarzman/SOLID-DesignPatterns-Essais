namespace ConsoleApp1.src.StructuralPatterns.Adapter
{
    public class BlackAndWhiteColor : Color
    {
        public void Apply(Video video)
        {
            System.Console.WriteLine("applying bw");
        }
    }
}