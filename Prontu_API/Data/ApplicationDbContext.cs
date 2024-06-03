using Microsoft.EntityFrameworkCore;
using Prontu_API.Models.Entities;
using System.Security.Cryptography.X509Certificates;

namespace Prontu_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        public DbSet<UserAdmModel> Users { get; set; }
    }
}
