using Microsoft.EntityFrameworkCore;

namespace PortlandLocalShopsApi.Models;
public class PortlandLocalShopsApiContext : DbContext
{
  public DbSet<Shop> Shops { get; set; }

  public PortlandLocalShopsApiContext(DbContextOptions<PortlandLocalShopsApiContext> options)
    : base(options)
  {
  }

  protected override void OnModelCreating(ModelBuilder builder)
  {
    for (int i = 5; i < 100; i++)
    {
      builder.Entity<Shop>().HasData(
          new Shop { ShopId = i, Name = Faker.Company.Name(),  StoreType = $"Faker.Lorem.Words(4)", MusicType = $"Faker.Lorem.Words(4)", PartOfTown = $"Faker.Lorem.Words(4)" }
          );
    }

  }
}
  

