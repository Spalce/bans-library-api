using BansLibraryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BansLibraryApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {}

    public virtual DbSet<Student> Students { get; set; } = null!;
    public virtual DbSet<Course> Courses { get; set; } = null!;
    public virtual DbSet<Contact> Contacts { get; set; } = null!;
}
