using Dapper;
using Domain.Models;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class OrderServise
{
    private readonly DataContext _dataContext;
    public OrderServise()=> _dataContext = new DataContext();

    public string AddOrder(Order order)
    {
        using (var connection = _dataContext.CreateConnection())
        {
            var sql = $"insert into orders(userid, product, quantity) values({order.UserId}, '{order.Product}', '{order.Quantity}')";
            var response = connection.Execute(sql);
            if (response == 1)
            {
                return "Order added!";
            }
            return "Error";
        }
    }
    public string DeleteOrder(int id)
    {
        using (var connection = _dataContext.CreateConnection())
        {
            var sql = $"delete orders where id = {id}";
            var response = connection.Execute(sql);
            if (response == 1)
            {
                return "Order deleted!";
            }
            return "Error";
        }
    }
    public string UpdateOrder(Order order)
    {
        using(var connection = _dataContext.CreateConnection())
        {
            var sql = $"update orders set userid = {order.UserId}, product = '{order.Product}', quantity = '{order.Quantity}' where id = {order.Id}";
            var response = connection.Execute(sql);
            if (response == 1)
            {
                return "Order deleted";
            }
            return "Error";
        }
    }
    public List<Order> GetOrders()
    {
        using (var connection = _dataContext.CreateConnection())
        {
            var sql = "select * from orders";
            var response = connection.Query<Order>(sql);
            return response.ToList();
        }
    }
    public Order GetOrder(int id)
    {
        using (var connection = _dataContext.CreateConnection())
        {
            var sql = $"select * from orders where id = {id}";
            var response = connection.QueryFirstOrDefault(sql);
            return response;
        }
    }
}
