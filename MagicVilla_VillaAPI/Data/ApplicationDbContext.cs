using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Villa>? Villas { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Villa>()
            .HasData(
                new Villa()
                {
                    Id=1,
                    Name="Kilimanjaro",
                    Details="Pretty Cool and has a lot of floors",
                    Rate=2000,
                    Occupancy=2,
                    Sqft=500,
                    ImageUrl="https://dotnetmastery.com/bluevillaimages/villa3.jpg",
                    Amenity="Hata sijui hii ni nini",
                    CreatedDate = DateTime.Now
                }
            );
    }
}