using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShepardsPies.Data;
using Microsoft.EntityFrameworkCore;
using ShepardsPies.Models;
using ShepardsPies.Models.DTOS;

namespace ShepardsPies.Controllers;

[ApiController]
[Route("api/[controller]")]

public class OrderController : ControllerBase
{
  private ShepardsPiesDbContext db;
  public OrderController(ShepardsPiesDbContext context)
  {
    db = context;
  }

  [HttpGet]
  public IActionResult Get()
  {
    
  }
}
