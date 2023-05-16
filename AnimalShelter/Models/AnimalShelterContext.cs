using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; } // need to change item later

    public AnimalShelterContext(DbContextOptions options) : base(options) { }
  }
}