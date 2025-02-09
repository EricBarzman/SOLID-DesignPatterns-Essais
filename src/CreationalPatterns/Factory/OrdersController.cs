using ConsoleApp1.src.CreationalPatterns.Factory.MVCFramework;

namespace ConsoleApp1.src.CreationalPatterns.Factory
{
    // Le choix de la Factory est faite ici, dans l'extension
    public class OrdersController : TwigController
    {
        public void ListOrders()
        {
            // Simulation d'une récupération sur la DB
            var orders = new Dictionary<string, object>{
                {"Red", "15€"},
                {"Orange", "10€"},
                {"Blue", "17€"},
            };

            Render("orders.blade.php", orders);
        }

        public void GetOrder(int id)
        {
            // Pareil
            var order = new Dictionary<string, object>{
                {"Red", "15€"},
            };

            Render("order.php", order);
        }
    }
}