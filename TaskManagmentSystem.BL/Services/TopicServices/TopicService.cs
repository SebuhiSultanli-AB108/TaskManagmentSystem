using AutoMapper;
using TaskManagmentSystem.BL.DTOs.TopicDTOs;
using TaskManagmentSystem.Core.Entities;
using TaskManagmentSystem.Core.RepositoryInterfaces;

namespace TaskManagmentSystem.BL.Services.TopicServices;

public class TopicService(ITopicRepository _repository, IMapper _mapper) : ITopicService
{
    public async Task CreateAsync(TopicCreateDTO dto)
    {
        await _repository.AddAsync(_mapper.Map<Topic>(dto));
        await _repository.SaveAsync();
    }

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteByIdAsync(id);
        await _repository.SaveAsync();
    }

    public IEnumerable<Topic> GetAll()
    {
        return _mapper.Map<IEnumerable<Topic>>(_repository.GetAll().ToList());
    }

    public async Task<Topic> GetByIdAsync(int id)
    {
        return _mapper.Map<Topic>(await _repository.GetByIdAsync(id));
    }
}