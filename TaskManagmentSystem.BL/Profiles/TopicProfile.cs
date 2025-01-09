using AutoMapper;
using TaskManagmentSystem.BL.DTOs.TopicDTOs;
using TaskManagmentSystem.Core.Entities;

namespace TaskManagmentSystem.BL.Profiles;

public class TopicProfile : Profile
{
    public TopicProfile()
    {
        CreateMap<TopicCreateDTO, Topic>().ReverseMap();
    }
}
