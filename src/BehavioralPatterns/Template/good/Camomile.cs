namespace ConsoleApp1.src.BehavioralPatterns.Template.good
{
    public class Camomile : Beverage
    {
        protected override void Brew()
        {
            System.Console.WriteLine("Brewing camomile for 10 minutes");
        }
    }
}