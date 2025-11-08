using System.ComponentModel.DataAnnotations;
namespace ShepardsPies.Models.DTOS;
public class ToppingDto
{
  [Required]
  public string Type { get; set; }
}
