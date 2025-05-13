using Microsoft.EntityFrameworkCore;
using cocteleria_kris_backend.Models; // Make sure this namespace matches your project

namespace cocteleria_kris_backend.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Drink> Drinks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Drink>(entity =>
        {
            entity.Property(d => d.PrimaryType).HasColumnName("primary_type");
            entity.Property(d => d.SecondaryType).HasColumnName("secondary_type");
            entity.Property(d => d.PowderedDelta).HasColumnName("powdered_delta");
            entity.Property(d => d.BronsonExtract).HasColumnName("bronson_extract");
            entity.Property(d => d.KarmotrineOptional).HasColumnName("karmotrine_optional");
        });

        base.OnModelCreating(modelBuilder);
    }
}

