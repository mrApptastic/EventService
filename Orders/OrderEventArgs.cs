using PizzaService.Orders;

public class OrderEventArgs : EventArgs
{
    public Order Order { get; }

    public OrderEventArgs(Order order)
    {
        Order = order;
    }
}