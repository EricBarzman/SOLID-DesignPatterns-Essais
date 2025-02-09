namespace ConsoleApp1.src.BehavioralPatterns.ChainOfResponsibility.good
{
    public class Logger : Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
            System.Console.WriteLine("Logged");
            return false;
        }
    }
}