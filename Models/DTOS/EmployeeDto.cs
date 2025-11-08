using System.ComponentModel.DataAnnotations;
namespace ShepardsPies.Models.DTOS;

public class EmployeeDto
{
  [Required]
  public string Name { get; set; }
}
