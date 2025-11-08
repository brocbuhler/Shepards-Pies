using System.ComponentModel.DataAnnotations;
namespace ShepardsPies.Models;

public class Topping
{
  public int Id { get; set; }
  [Required]
  public string Type { get; set; }
}
