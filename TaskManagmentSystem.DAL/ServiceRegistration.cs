using Microsoft.Extensions.DependencyInjection;
using TaskManagmentSystem.Core.RepositoryInterfaces;
using TaskManagmentSystem.DAL.RepositoryImplements;

namespace TaskManagmentSystem.DAL;

public static class ServiceRegistration
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        services.AddScoped<IAssignmentRepository, AssignmentRepository>();
        services.AddScoped<ITopicRepository, TopicRepository>();
        return services;
    }
}
