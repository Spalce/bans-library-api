using BansLibrary.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace BansLibraryApi.Controllers;

public class StaffsController : Controller
{
    private readonly IStaffService _staffService;

    public StaffsController(IStaffService staffService)
    {
        _staffService = staffService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var staffs = _staffService.GetAllAsync();
        return Ok(staffs);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {
        var staff = _staffService.GetById(id);
        return Ok(staff);
    }
}
