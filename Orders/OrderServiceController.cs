using Microsoft.AspNetCore.Mvc;
using PizzaService.Orders;

[ApiController]
[Route("api/[controller]")]
public class OrderServiceController : ControllerBase
{
    public static event EventHandler<OrderEventArgs> NewOrderEvent;

    [HttpPost("order")]
    public ActionResult<Order> NewOrder([FromBody] Order order)
    {
        OnNewOrder(order);
     
        return Ok(order);
    }

    protected virtual void OnNewOrder(Order order)
    {
        NewOrderEvent?.Invoke(this, new OrderEventArgs(order));
    }
}
