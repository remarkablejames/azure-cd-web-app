using azure_cd_web_app.Models;
using Microsoft.EntityFrameworkCore;

namespace azure_cd_web_app.Data;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
    {
    }
    
    public DbSet<Person> People { get; set; } = null!;
    
}