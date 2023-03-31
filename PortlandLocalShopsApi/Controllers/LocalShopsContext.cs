using Microsoft.EntityFrameworkCore;

namespace PortlandLocalShopsApi.Models;

public class PortlandLocalShopsApiContext : DbContext
{
    public DbSet<Shop> Shops { get; set; } = null!;

    public PortlandLocalShopsApiContext(DbContextOptions<PortlandLocalShopsApiContext> options)
        : base(options)
    {
    }

}
