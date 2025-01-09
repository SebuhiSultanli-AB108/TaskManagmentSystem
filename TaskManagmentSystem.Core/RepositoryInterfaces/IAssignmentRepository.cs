using TaskManagmentSystem.Core.Entities;

namespace TaskManagmentSystem.Core.RepositoryInterfaces;

public interface IAssignmentRepository : IGenericRepository<Assignment>
{
    Task<IEnumerable<Assignment>> GetAssignmentsAsync();
}