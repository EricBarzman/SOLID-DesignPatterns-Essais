namespace ConsoleApp1.src.BehavioralPatterns.Visitor.bad
{
    public class RetailClient : Client
    {
        public RetailClient(string name, string email) : base(name, email)
        {
        }

        public override void SendEmail()
        {
            System.Console.WriteLine("Sending retail marketing tips");
        }
    }
}