using GIT_API.Models;
using Microsoft.EntityFrameworkCore;

namespace GIT_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base (options)
        {}
        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<UserDetail> Registers { get; set; }
    }
}
