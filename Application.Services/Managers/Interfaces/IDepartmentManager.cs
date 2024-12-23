﻿using Application.Services.Models.Entities;

namespace Application.Services.Managers.Interfaces
{
    public interface IDepartmentManager
    {
        Task<IEnumerable<Department>> GetAllDepartmentAsync();
    }
}
