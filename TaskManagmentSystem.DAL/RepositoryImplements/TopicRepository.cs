using TaskManagmentSystem.Core.Entities;
using TaskManagmentSystem.Core.RepositoryInterfaces;
using TaskManagmentSystem.DAL.Context;

namespace TaskManagmentSystem.DAL.RepositoryImplements;

public class TopicRepository : GenericRepository<Topic>, ITopicRepository
{
    readonly SqlContext _context;
    public TopicRepository(SqlContext context) : base(context)
    {
        _context = context;
    }
}