using Microsoft.EntityFrameworkCore;

namespace Api;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Owner> Owners { get; set; }
    public DbSet<Pet> Pets { get; set; }
        
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
            
        // Create a unique index on Owner's Email
        modelBuilder.Entity<Owner>()
            .HasIndex(o => o.Email)
            .IsUnique();
                
        // Create a unique index on Pet's Name + OwnerId
        modelBuilder.Entity<Pet>()
            .HasIndex(p => new { p.Name, p.OwnerId })
            .IsUnique();
                
        // Configure the relationship between Owner and Pet
        modelBuilder.Entity<Owner>()
            .HasMany(o => o.Pets)
            .WithOne(p => p.Owner)
            .HasForeignKey(p => p.OwnerId)
            .OnDelete(DeleteBehavior.Cascade);       
    }
}
