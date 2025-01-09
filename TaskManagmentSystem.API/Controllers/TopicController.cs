using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TaskManagmentSystem.BL.DTOs.TopicDTOs;
using TaskManagmentSystem.BL.Services.TopicServices;
using TaskManagmentSystem.Core.Entities;

namespace TaskManagmentSystem.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TopicController(ITopicService _service, IMapper _mapper) : ControllerBase
{
    [HttpPost("[action]")]
    public async Task<IActionResult> Create(TopicCreateDTO dto)
    {
        await _service.CreateAsync(dto);
        return Ok();
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetAll()
    {

        return Ok(_mapper.Map<IEnumerable<Topic>>(_service.GetAll()));
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