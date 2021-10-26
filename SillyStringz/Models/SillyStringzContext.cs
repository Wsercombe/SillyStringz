using Microsoft.EntityFrameworkCore;

namespace SillyStringz.Models
{
  public class SillyStringzContext : DbContext
  {
    public DbSet<Machine> Machines { get; set; }
    public DbSet<Engineer> Engineers { get; set; }
    public DbSet<EngineerMachine> EngineerMachine { get; set; }

    public SillyStringzContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}