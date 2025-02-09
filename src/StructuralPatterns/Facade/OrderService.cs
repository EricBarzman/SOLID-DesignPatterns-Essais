namespace ConsoleApp1.src.StructuralPatterns.Facade
{
    // OUR FACADE !
    public class OrderService
    {
        // Tout ce qui était dans le programme, cad le client, a été passé ici
        public void Order(OrderRequest orderReq)
        {
            var auth = new Authenticate();
            var inventory = new Inventory();

            foreach (var id in orderReq.ItemIds)
                inventory.CheckInventory(id);   

            var payment = new Payment(orderReq.Name, orderReq.CardNumber, orderReq.Amount);
            payment.Pay();

            var orderFullfillment = new OrderFullfillment(inventory);
            orderFullfillment.Fullfill(orderReq.Name, orderReq.Address, orderReq.ItemIds);
        }
    }
}