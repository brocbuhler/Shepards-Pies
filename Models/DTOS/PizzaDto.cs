using System.ComponentModel.DataAnnotations;
using System.Drawing;
using Microsoft.AspNetCore.SignalR;
namespace ShepardsPies.Models.DTOS;
public class PizzaDto
{
  [Required]
  public Size PizzaSize { get; set; }
  [Required]
  public Sauce PizzaSauce { get; set; }
  [Required]
  public Cheese PizzaCheese { get; set; }
  public List<PizzaTopping> PizzaToppings { get; set; }
}
