using TaskManagmentSystem.Core.Entities;
using TaskManagmentSystem.Core.RepositoryInterfaces;
using TaskManagmentSystem.DAL.Context;

namespace TaskManagmentSystem.DAL.RepositoryImplements;

public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
{
    readonly SqlContext _context;
    public EmployeeRepository(SqlContext context) : base(context)
    {
        _context = context;
    }
}