using BansLibraryApi.Models;

namespace BansLibraryApi.Interfaces;

public interface ICourseService
{
    Task<List<Course>> GetAll();

    Task<Course> GetById(Guid id);

    Task<Course> GetByName(string name);

    Task<Course> Create(Course model);

    Task<bool> CreateBatch(List<Course> model);

    Task<Course> Update(Course model);

    Task<bool> Delete(Guid id);
}
