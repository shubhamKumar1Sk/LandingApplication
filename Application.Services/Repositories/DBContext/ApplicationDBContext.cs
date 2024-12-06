using Application.Services.Models.Entities;
using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace Application.Services.Repositories.DBContext
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }


       public DbSet<Project> Projects { get; set; }
       public DbSet<Department> Departments { get; set; }
       public DbSet<Employee> Employees { get; set; }
    }
}
