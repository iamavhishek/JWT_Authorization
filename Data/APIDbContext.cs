using JWTAuthorization.Models;
using Microsoft.EntityFrameworkCore;

namespace JWTAuthorization.Data
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

    }
}
