namespace ShepardsPies.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ShepardsPies.Models;
using Microsoft.AspNetCore.Identity;

public class ShepardsPiesDbContext : IdentityDbContext<IdentityUser>
{
  private readonly IConfiguration _configuration;
  public DbSet<Employee> employees { get; set; }
  public DbSet<Order> orders { get; set; }
  public DbSet<Pizza> pizzas { get; set; }
  public DbSet<PizzaTopping> pizzaToppings { get; set; }
  public DbSet<Topping> toppings { get; set; }
  public DbSet<UserProfile> UserProfiles { get; set; }
  public ShepardsPiesDbContext(DbContextOptions<ShepardsPiesDbContext> context, IConfiguration config) : base(context)
  {
    _configuration = config;
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
    {
      Id = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
      Name = "Admin",
      NormalizedName = "admin"
    });

    modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
    {
      Id = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
      UserName = "Administrator",
      Email = "admina@strator.comx",
      PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, _configuration["AdminPassword"])
    });
    modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
    {
      RoleId = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
      UserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f"
    });
    modelBuilder.Entity<UserProfile>().HasData(new UserProfile
    {
      Id = 1,
      IdentityUserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
      FirstName = "Admina",
      LastName = "Strator",
      Address = "101 Main Street",
    });

    modelBuilder.Entity<Employee>().HasData(new Employee[]
    {
        new Employee { Id = 1, Name = "Casey Cashier" },
        new Employee { Id = 2, Name = "Derek Driver" }
    });

    modelBuilder.Entity<Topping>().HasData(new Topping[]
    {
        new Topping { Id = 1, Type = "Pepperoni" },
        new Topping { Id = 2, Type = "Mushrooms" },
        new Topping { Id = 3, Type = "Basil" }
    });

    modelBuilder.Entity<Pizza>().HasData(new Pizza[]
    {
        new Pizza
        {
            Id = 1,
            PizzaSize = Size.Medium,
            PizzaSauce = Sauce.Marinara,
            PizzaCheese = Cheese.FourCheese
        }
    });

    modelBuilder.Entity<PizzaTopping>().HasData(new PizzaTopping[]
    {
        new PizzaTopping { Id = 1, PizzaId = 1, ToppingId = 1 },
        new PizzaTopping { Id = 2, PizzaId = 1, ToppingId = 2 },
        new PizzaTopping { Id = 3, PizzaId = 1, ToppingId = 3 }
    });

    modelBuilder.Entity<Order>().HasData(new Order[]
    {
        new Order
        {
            Id = 1,
            TableNumber = 4,
            DeliveryAddress = "4700 humber drive",
            DeliveryDriverId = 2,
            CashierId = 1,
            Tip = 3.50m,
            OrderTakenOn = new DateTime(2025, 11, 8)
        }
    });
  }
}
