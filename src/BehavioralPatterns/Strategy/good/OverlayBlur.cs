namespace ConsoleApp1.src.BehavioralPatterns.Strategy.good
{
    public class OverlayBlur : IOverlay
    {
        public void Apply()
        {
            System.Console.WriteLine("Applying blur");
        }
    }
}