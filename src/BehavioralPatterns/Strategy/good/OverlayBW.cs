namespace ConsoleApp1.src.BehavioralPatterns.Strategy.good
{
    public class OverlayBW : IOverlay
    {
        public void Apply()
        {
            System.Console.WriteLine("Applying black and whites");
        }
    }
}