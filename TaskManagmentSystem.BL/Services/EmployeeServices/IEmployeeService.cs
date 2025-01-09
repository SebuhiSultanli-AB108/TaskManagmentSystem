using TaskManagmentSystem.BL.DTOs.Employee;
using TaskManagmentSystem.Core.Entities;

namespace TaskManagmentSystem.BL.Services.EmployeeServices;

public interface IEmployeeService
{
    IEnumerable<Employee> GetAll();
    Task CreateAsync(EmployeeCreateDTO dto);
    Task<Employee> GetByIdAsync(int id);
    Task DeleteAsync(int id);
}
