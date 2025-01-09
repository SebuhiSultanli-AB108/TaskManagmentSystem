using TaskManagmentSystem.Core.Entities;
using TaskManagmentSystem.Core.RepositoryInterfaces;
using TaskManagmentSystem.DAL.Context;

namespace TaskManagmentSystem.DAL.RepositoryImplements;

public class TagRepository : GenericRepository<Tag>, ITagRepository
{
    readonly SqlContext _context;
    public TagRepository(SqlContext context) : base(context)
    {
        _context = context;
    }
}