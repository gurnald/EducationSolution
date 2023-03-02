using Microsoft.EntityFrameworkCore;

namespace Education.Models;

public class EducationDbContext : DbContext {

    public DbSet<Major> Majors { get; set; }
    public DbSet<Student> Students { get; set; }

    public EducationDbContext(DbContextOptions<EducationDbContext> options) : base(options) { }

}