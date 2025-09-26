using Microsoft.EntityFrameworkCore;
using VeterinariaSanMiguel.Models;

namespace VeterinariaSanMiguel.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Veterinario> Veterinarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql(
                "server=127.0.0.1;database=interstellar_HU_3;user=interstellar;password=int123!",
                new MySqlServerVersion(new Version(8, 0, 36))
            );
        }
    }
}