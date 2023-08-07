using Microsoft.EntityFrameworkCore;
using Contexts.Users.Domain;

namespace Contexts.Users.Infraestruture;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<User> Users { get; set; }
}