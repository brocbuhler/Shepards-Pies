using System.ComponentModel.DataAnnotations;
using System.Drawing;
using Microsoft.AspNetCore.SignalR;
namespace ShepardsPies.Models;

public enum Size
{
  Small,
  Medium,
  Large
}
public enum Sauce
{
  Marinara,
  Arrabbiata,
  GarlicWhite,
  None
}
public enum Cheese
{
  BuffaloMozzarella,
  FourCheese,
  Vegan,
  None
}
public class Pizza
{
  public int Id { get; set; }
  //figure out allowed types
  [Required]
  public Size PizzaSize { get; set; }
  [Required]
  public Sauce PizzaSauce { get; set; }
  [Required]
  public Cheese PizzaCheese { get; set; }
  public List<PizzaTopping> PizzaToppings { get; set; }
}
