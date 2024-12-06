using Application.Services.Models.Entities;

namespace Application.Services.Repositories.Interfaces
{
    public interface IProjectREpository
    {
        Task<IEnumerable<Project>> GetAllDepartments();
    }
}
