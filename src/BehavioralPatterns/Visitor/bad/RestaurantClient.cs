namespace ConsoleApp1.src.BehavioralPatterns.Visitor.bad
{
    public class RestaurantClient : Client
    {
        public RestaurantClient(string name, string email) : base(name, email)
        {
        }

        public override void SendEmail()
        {
            System.Console.WriteLine("Sending restaurant marketing tips");
        }
    }
}