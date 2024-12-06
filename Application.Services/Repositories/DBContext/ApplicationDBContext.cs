using Application.Services.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.Repositories.DBContext
{
    public class ApplicationDBContext : DbContext
    {
        DbSet<Project> projects;
        DbSet<Department> department;
        DbSet<Employee> employees;
    }
}
