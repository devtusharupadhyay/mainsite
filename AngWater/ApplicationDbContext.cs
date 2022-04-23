using AngWater.Models;
using Microsoft.EntityFrameworkCore;

namespace AngWater
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }

        public DbSet<Log> Logs { get; set; }

        public DbSet<Schedule> Schedule { get; set; }

    }
}
