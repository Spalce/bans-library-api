using BansLibraryApi.Models;
using BansLibraryApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BansLibraryApi.Controllers;

public class CoursesController : Controller
{
    private readonly CourseService _courseService;

    public CoursesController(CourseService courseService)
    {
        _courseService = courseService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _courseService.GetAll();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _courseService.GetById(id);
        return Ok(result);
    }

    [HttpGet("name/{name}")]
    public async Task<IActionResult> GetByName(string name)
    {
        var result = await _courseService.GetByName(name);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Course model)
    {
        var result = await _courseService.Create(model);
        return Ok(result);
    }

    [HttpPost("batch")]
    public async Task<IActionResult> CreateBatch([FromBody] List<Course> model)
    {
        var result = await _courseService.CreateBatch(model);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] Course model)
    {
        var result = await _courseService.Update(model);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _courseService.Delete(id);
        return Ok(result);
    }
}
