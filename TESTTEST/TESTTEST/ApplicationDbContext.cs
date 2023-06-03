using Microsoft.EntityFrameworkCore;
using TESTTEST.Models;

namespace TESTTEST;

public class ApplicationDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }



    public ApplicationDbContext()
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .HasOne(b => b.Category)
            .WithMany(a => a.Products)
            .HasForeignKey(b => b.Id);

    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
}