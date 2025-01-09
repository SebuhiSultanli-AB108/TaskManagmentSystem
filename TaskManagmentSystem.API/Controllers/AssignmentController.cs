using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TaskManagmentSystem.BL.DTOs.Assignment;
using TaskManagmentSystem.BL.Services.AssignmentService;

namespace TaskManagmentSystem.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AssignmentController(IAssignmentService _service, IMapper _mapper) : ControllerBase
{
    [HttpPost("[action]")]
    public async Task<IActionResult> Create(AssignmentCreateDTO dto)
    {
        await _service.CreateAsync(dto);
        return Ok();
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetAll()
    {

        return Ok(_service.GetAll());
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetById(int id)
    {
        return Ok(await _service.GetByIdAsync(id));
    }

    [HttpDelete("[action]")]
    public async Task<IActionResult> Delete(int id)
    {
        return Ok(_service.DeleteAsync(id));
    }
}