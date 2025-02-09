namespace ConsoleApp1.src.BehavioralPatterns.Visitor.good
{
    public class RestaurantClient : Client
    {
        public RestaurantClient(string name, string email) : base(name, email) {}

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitRestaurant(this);
        }
    }
}