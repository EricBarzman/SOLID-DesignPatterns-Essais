namespace ConsoleApp1.src.StructuralPatterns.Adapter
{
    public class MidnightColor : Color
    {
        public void Apply(Video video)
        {
            System.Console.WriteLine("applying midnight");
        }
    }
}