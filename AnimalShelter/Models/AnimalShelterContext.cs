using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : AddDbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public ToDoListContext(DbContextOptions options) : base(options) { }
  }
}