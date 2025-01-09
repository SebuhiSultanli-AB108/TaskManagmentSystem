using TaskManagmentSystem.BL.DTOs.TopicDTOs;
using TaskManagmentSystem.Core.Entities;

namespace TaskManagmentSystem.BL.Services.TopicServices;

public interface ITopicService
{
    IEnumerable<Topic> GetAll();
    Task CreateAsync(TopicCreateDTO dto);
    Task<Topic> GetByIdAsync(int id);
    Task DeleteAsync(int id);
}
