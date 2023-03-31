using Microsoft.EntityFrameworkCore;

namespace PortlandLocalShopsApi.Models;

public class PortlandLocalShopsApiContext : DbContext
{
    public DbSet<Shop> Shops { get; set; } = null!;

    public PortlandLocalShopsApiContext(DbContextOptions<PortlandLocalShopsApiContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Shop>()
        .HasData(
          new Shop { ShopId = 1, Name = "doug fir lounge", StoreType = "music venue", MusicType = "various, singer-songwriter, guitar-bass-drums", PartOfTown = "e, east" },
          new Shop { ShopId = 2, Name = "mississippi pizza", StoreType = "pizza restaurant, music venue", MusicType = "various, salsa, timba, singer-songwriter, guitar-bass-drums", PartOfTown = "ne, northeast" },
          new Shop { ShopId = 3, Name = "the goodfoot", StoreType = "bar, music venue", MusicType = "various, funk, salsa, guitar-bass-drums", PartOfTown = "ne, northeast" },
          new Shop { ShopId = 4, Name = "the 1905", StoreType = "bar, pizza, music venue", MusicType = "jazz", PartOfTown = "ne, northeast" }
        );
    }
}
