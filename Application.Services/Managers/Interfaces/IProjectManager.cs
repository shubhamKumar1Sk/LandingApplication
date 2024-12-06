using Application.Services.Models.Entities;

namespace Application.Services.Managers.Interfaces
{
    public interface IProjectManager
    {
        Task<IEnumerable<Project>> GetAllProjectAsync();
    }
}
