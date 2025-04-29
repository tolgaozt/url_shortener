using Microsoft.EntityFrameworkCore;
using UrlShortener.Models;

namespace UrlShortener.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // Table representing all shortened URL mappings
    public DbSet<UrlMapping> UrlMappings => Set<UrlMapping>();
}
