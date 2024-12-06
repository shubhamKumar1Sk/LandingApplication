using Application.Services.Managers.Interfaces;
using Application.Services.Models.Entities;

namespace Application.Services.Managers
{
    public class ProjectManager : IProjectManager
    {
        public async Task<IEnumerable<Project>> GetAllProjectAsync()
        {
            throw new NotImplementedException();
        }
    }
}
