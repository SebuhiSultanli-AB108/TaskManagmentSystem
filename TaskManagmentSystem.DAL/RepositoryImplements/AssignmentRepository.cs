using Microsoft.EntityFrameworkCore;
using TaskManagmentSystem.Core.Entities;
using TaskManagmentSystem.Core.RepositoryInterfaces;
using TaskManagmentSystem.DAL.Context;

namespace TaskManagmentSystem.DAL.RepositoryImplements;

public class AssignmentRepository : GenericRepository<Assignment>, IAssignmentRepository
{
    readonly SqlContext _context;
    public AssignmentRepository(SqlContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Assignment>> GetAssignmentsAsync()
    {
        return await _context.Assignments.Include(x => x.Tags).ToListAsync();
    }
}
