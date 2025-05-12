using Microsoft.EntityFrameworkCore;
using cocteleria_kris_backend.Models; // Make sure this namespace matches your project

namespace cocteleria_kris_backend.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
}
