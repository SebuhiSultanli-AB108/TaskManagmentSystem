using AutoMapper;
using TaskManagmentSystem.BL.DTOs.Assignment;
using TaskManagmentSystem.Core.Entities;
using TaskManagmentSystem.Core.RepositoryInterfaces;

namespace TaskManagmentSystem.BL.Services.AssignmentService;

public class AssignmentService(IAssignmentRepository _repository, IMapper _mapper) : IAssignmentService
{
    public async Task CreateAsync(AssignmentCreateDTO dto)
    {
        await _repository.AddAsync(_mapper.Map<Assignment>(dto));
        await _repository.SaveAsync();
    }

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteByIdAsync(id);
        await _repository.SaveAsync();
    }

    public async Task<IEnumerable<Assignment>> GetAll()
    {
        return await _repository.GetAssignmentsAsync();
        //return _mapper.Map<IEnumerable<Assignment>>(_repository.GetAll().ToList());
    }
    public async Task<Assignment> GetByIdAsync(int id)
    {
        return _mapper.Map<Assignment>(await _repository.GetByIdAsync(id));
    }
}