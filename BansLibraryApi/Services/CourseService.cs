using BansLibraryApi.Data;
using BansLibraryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BansLibraryApi.Services;

public class CourseService
{
    private readonly AppDbContext _db;

    public CourseService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<List<Course>> GetAll()
    {
        return await _db.Courses.ToListAsync();
    }

    public async Task<Course> GetById(Guid id)
    {
        var record =  await _db.Courses.FindAsync(id);
        if (record != null!)
            return record;

        return null!;
    }

    public async Task<Course> GetByName(string name)
    {
        var record =  await _db.Courses.FirstOrDefaultAsync(e => e.Name == name);
        return record != null! ? record : null!;
    }

    public async Task<Course> Create(Course model)
    {
        await _db.Courses.AddAsync(model);
        var result = await _db.SaveChangesAsync();
        return result > 0 ? model : null!;
    }

    public async Task<bool> CreateBatch(List<Course> model)
    {
        await _db.Courses.AddRangeAsync(model);
        var result = await _db.SaveChangesAsync();
        return result > 0;
    }

    public async Task<Course> Update(Course model)
    {
        var existing = await _db.Courses.FindAsync(model.Id);
        if (existing == null!)
            return null!;

        existing.Name = model.Name;
        var result = await _db.SaveChangesAsync();
        return result > 0 ? existing : null!;
    }

    public async Task<bool> Delete(Guid id)
    {
        var existing = await _db.Courses.FindAsync(id);
        if (existing == null!)
            return false;

        _db.Courses.Remove(existing);
        var result = await _db.SaveChangesAsync();
        return result > 0;
    }
}
