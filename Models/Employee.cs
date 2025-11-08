using System.ComponentModel.DataAnnotations;
namespace ShepardsPies.Models;

public class Employee
{
  public int Id { get; set; }
  [Required]
  public string Name { get; set; }
}
