using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public DbSet<Item> Items { get; set; }

    public AnimalShleterContext(DbContextOptions options) : base(options) { }
  }
}