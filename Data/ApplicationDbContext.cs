using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Board> Boards { get; set; }
    public DbSet<Data.Models.Task> Tasks { get; set; }

}
