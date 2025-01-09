
using Microsoft.Extensions.DependencyInjection;
using TaskManagmentSystem.BL.Services.AssignmentService;
using TaskManagmentSystem.BL.Services.EmployeeServices;
using TaskManagmentSystem.BL.Services.TopicServices;

namespace TaskManagmentSystem.BL;

public static class ServiceRegistration
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IEmployeeService, EmployeeService>();
        services.AddScoped<IAssignmentService, AssignmentService>();
        services.AddScoped<ITopicService, TopicService>();
        return services;
    }
    public static IServiceCollection AddAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(ServiceRegistration));
        return services;
    }
    //public static IServiceCollection AddFluentValidation(this IServiceCollection services)
    //{
    //    services.AddFluentValidationAutoValidation();
    //    services.AddValidatorsFromAssemblyContaining(typeof(ServiceRegistration));
    //    return services;
    //}
}