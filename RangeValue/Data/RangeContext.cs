using Microsoft.EntityFrameworkCore;
using RangeValue.Data.Entities;

namespace RangeValue.Data;

public class RangeContext:DbContext
{
    private readonly IConfiguration _configuration;

    public RangeContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public DbSet<RangeControl> RangeControls{ get; set; }
    public DbSet<Result> Results { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlServer(_configuration["ConnectionStrings:RangeContextDb"]);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

    }

}
