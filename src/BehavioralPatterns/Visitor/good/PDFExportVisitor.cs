
namespace ConsoleApp1.src.BehavioralPatterns.Visitor.good
{
    // Grâce au pattern Visitor, il est plus facile de créer un nouveau VISITOR
    // (une nouvelle fonction POUR CHAQUE CLIENT). En revanche, ajouter un client est plus galère.
    public class PDFExportVisitor : IVisitor
    {
        public void VisitLaw(LawClient lawClient)
        {
            System.Console.WriteLine("Exporting law client as PDF");
        }

        public void VisitRestaurant(RestaurantClient restaurantClient)
        {
            System.Console.WriteLine("Exporting restaurant client as PDF");
        }

        public void VisitRetail(RetailClient retailClient)
        {
            System.Console.WriteLine("Exporting retail client as PDF");
        }
    }
}