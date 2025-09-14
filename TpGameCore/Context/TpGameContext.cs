using Microsoft.EntityFrameworkCore;
using TpGameCore.Entity;

namespace TpGameCore.Context;

public class TpGameContext : DbContext
{
    public DbSet<Monstre> Monstres { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=TpGameRpg;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
