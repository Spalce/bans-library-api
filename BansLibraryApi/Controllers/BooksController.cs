using System.Net.Mime;
using BansLibraryApi.Models;
using BansLibraryApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BansLibraryApi.Controllers;

[Produces(MediaTypeNames.Application.Json)]
[Route("api/[controller]")]
[ApiController]
public class BooksController : Controller
{
    private readonly StudentService _service;

    public BooksController(StudentService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<Student>>> GetAll()
    {
        return await _service.GetAll().ConfigureAwait(false);
    }

    [HttpPost]
    public async Task<ActionResult<Student>> Create([FromBody] Student model)
    {
        return await _service.Create(model).ConfigureAwait(false);
    }
}
