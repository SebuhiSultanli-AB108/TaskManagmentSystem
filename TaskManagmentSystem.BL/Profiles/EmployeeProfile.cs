using AutoMapper;
using TaskManagmentSystem.BL.DTOs.Employee;
using TaskManagmentSystem.Core.Entities;

namespace TaskManagmentSystem.BL.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeCreateDTO, Employee>().ReverseMap();
        }
    }
}
