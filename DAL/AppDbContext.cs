using Clinic.Models;
using Microsoft.EntityFrameworkCore;

namespace Clinic.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<PatientComment> PatientComments { get; set; }
    }
}
