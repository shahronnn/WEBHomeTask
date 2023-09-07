using Domain.Models;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly OrderServise _orderService;
    [HttpGet("GetOrders")]
    public List<Order> GetOrders()
    {
        return _orderService.GetOrders();
    }
    [HttpGet("GetOrder")]
    public Order GetOrder(int id)
    {
        return _orderService.GetOrder(id);
    }
    [HttpPut("UpdateOrder")]
    public string UpdateOrder(Order order)
    {
        return _orderService.UpdateOrder(order);
    }
    [HttpDelete("DeleteOrder")]
    public string DeleteOrder(int id)
    {
        return _orderService.DeleteOrder(id);
    }
    [HttpPost("AddOrder")]
    public string AddOrder(Order order)
    {
        return _orderService.AddOrder(order);
    }
}
