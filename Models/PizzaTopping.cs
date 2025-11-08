using System.ComponentModel.DataAnnotations;
namespace ShepardsPies.Models;

public class PizzaTopping
{
  public int Id { get; set; }
  [Required]
  public int ToppingId { get; set; }
  [Required]
  public int PizzaId { get; set; }
}
