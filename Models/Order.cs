using System.ComponentModel.DataAnnotations;
namespace ShepardsPies.Models;

public class Order
{
  public int Id { get; set; }
  public int TableNumber { get; set; }
  public string DeliveryAddress { get; set; }
  public int DeliveryDriverId { get; set; }
  [Required]
  public int CashierId { get; set; }
  public decimal Tip { get; set; }
  public DateTime OrderTakenOn { get; set; }
  //figure out total cost in controller
  public List<Pizza> Pizzas { get; set; }
}
