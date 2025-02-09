namespace ConsoleApp1.src.BehavioralPatterns.Visitor.good
{
    public interface IVisitor
    {
        void VisitRetail(RetailClient retailClient);
        void VisitLaw(LawClient lawClient);
        void VisitRestaurant(RestaurantClient restaurantClient);
    }
}