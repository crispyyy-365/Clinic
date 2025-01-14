using Clinic.Models;
using Microsoft.EntityFrameworkCore;

namespace Clinic.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<PatientComment> PatientComments { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Department> Departments { get; set; }
        public DbSet<EmployeePhoto> EmployeePhotos { get; set; }
	}
}
