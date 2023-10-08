using PizzaService.Orders;

public class OrderProcessor
{
    static List<Order> orders = new List<Order>();

    public void ProcessOrder(object sender, OrderEventArgs e)
    {
        orders.Add(e.Order);
    }
}