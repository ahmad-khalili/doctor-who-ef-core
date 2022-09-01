using DoctorWho.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Db;

public class DoctorWhoCoreDbContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Enemy> Enemies { get; set; }
    public DbSet<Companion> Companions { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Episode> Episodes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=DESKTOP-MBUG9CK;Initial Catalog = DoctorWhoCore;Trusted_Connection=True";
        optionsBuilder.UseSqlServer(connectionString);
    }
}