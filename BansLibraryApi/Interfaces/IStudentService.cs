using BansLibraryApi.Models;

namespace BansLibraryApi.Interfaces;

public interface IStudentService
{
    Task<List<Student>> GetAll();
    Task<Student> GetById(Guid id);
    Task<Student> GetByFirstName(string name);
    Task<Student> Create(Student model);
    Task<bool> CreateBatch(List<Student> model);
    Task<Student> Update(Student model);
    Task<bool> Delete(Student model);
    // void Dispose();
}
