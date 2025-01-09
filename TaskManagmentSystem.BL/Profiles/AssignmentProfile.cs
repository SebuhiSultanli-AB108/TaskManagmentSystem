using AutoMapper;
using TaskManagmentSystem.BL.DTOs.Assignment;
using TaskManagmentSystem.Core.Entities;

namespace TaskManagmentSystem.BL.Profiles;

public class AssignmentProfile : Profile
{
    public AssignmentProfile()
    {
        CreateMap<AssignmentCreateDTO, Assignment>()
            .ForMember(x => x.Tags, y => y.MapFrom(z => z.Tags.Select(s => new Tag { Description = s }).ToList()));
    }
}