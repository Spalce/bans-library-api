using BansLibraryApi.Data;
using BansLibraryApi.Interfaces;
using BansLibraryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BansLibraryApi.Services;

public class StudentService : IStudentService
{
    private readonly AppDbContext _db;

    public StudentService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<List<Student>> GetAll()
    {
        return await _db.Students.ToListAsync();
    }

    public async Task<Student> GetById(Guid id)
    {
        var record =  await _db.Students.FindAsync(id);
        if (record != null!)
            return record;

        return null!;
    }

    public async Task<Student> GetByFirstName(string name)
    {
        var record =  await _db.Students.FirstOrDefaultAsync(e => e.FirstName == name);
        return record != null! ? record : null!;
    }

    public async Task<Student> Create(Student model)
    {
        await _db.Students.AddAsync(model);
        var result = await _db.SaveChangesAsync();
        if (result > 0)
            return model;

        return null!;
    }

    public async Task<bool> CreateBatch(List<Student> model)
    {
        await _db.Students.AddRangeAsync(model);
        var result = await _db.SaveChangesAsync();
        if (result > 0)
            return true;

        return false!;
    }

    public async Task<Student> Update(Student model)
    {
        var existing = await _db.Students.FindAsync(model.Id);
        if (existing == null!)
            return null!;

        existing.FirstName = model.FirstName;
        existing.LastName = model.LastName;
        existing.DateOfBirth = model.DateOfBirth;
        existing.IsActive = model.IsActive;

        _db.Students.Update(model);
        var result = await _db.SaveChangesAsync();
        if (result > 0)
            return model;

        return null!;
    }

    public async Task<bool> Delete(Student model)
    {
        _db.Students.Remove(model);
        var result = await _db.SaveChangesAsync();
        if (result == 0)
            return true;

        return false!;
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
