using TaskManagmentSystem.BL.DTOs.Assignment;
using TaskManagmentSystem.Core.Entities;

namespace TaskManagmentSystem.BL.Services.AssignmentService;

public interface IAssignmentService
{
    Task<IEnumerable<Assignment>> GetAll();
    Task CreateAsync(AssignmentCreateDTO dto);
    Task<Assignment> GetByIdAsync(int id);
    Task DeleteAsync(int id);
}
