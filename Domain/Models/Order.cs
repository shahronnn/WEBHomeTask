namespace Domain.Models;

public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Product { get; set; }
    public int Quantity { get; set; }
}
