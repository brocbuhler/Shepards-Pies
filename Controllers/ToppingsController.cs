using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShepardsPies.Data;
using Microsoft.EntityFrameworkCore;
using ShepardsPies.Models;
using ShepardsPies.Models.DTOS;

namespace ShepardsPies.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ToppingController : ControllerBase
{
  private ShepardsPiesDbContext db;
  public ToppingController(ShepardsPiesDbContext context)
  {
    db = context;
  }

  [HttpGet]
  public IActionResult Get()
  {
    return Ok (db.toppings.Select(t => new ToppingDto
    {
    Type = t.Type
    }).ToList());
  }
}
