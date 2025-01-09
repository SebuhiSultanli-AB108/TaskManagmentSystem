using AutoMapper;
using TaskManagmentSystem.BL.DTOs.Employee;
using TaskManagmentSystem.Core.Entities;
using TaskManagmentSystem.Core.RepositoryInterfaces;

namespace TaskManagmentSystem.BL.Services.EmployeeServices;

public class EmployeeService(IEmployeeRepository _repository, IMapper _mapper) : IEmployeeService
{
    public async Task CreateAsync(EmployeeCreateDTO dto)
    {
        await _repository.AddAsync(_mapper.Map<Employee>(dto));
        await _repository.SaveAsync();
    }

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteByIdAsync(id);
        await _repository.SaveAsync();
    }

    public IEnumerable<Employee> GetAll()
    {
        return _mapper.Map<IEnumerable<Employee>>(_repository.GetAll().ToList());
    }

    public async Task<Employee> GetByIdAsync(int id)
    {
        return _mapper.Map<Employee>(await _repository.GetByIdAsync(id));
    }
}