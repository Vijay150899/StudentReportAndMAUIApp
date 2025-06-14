
using Microsoft.EntityFrameworkCore;

public class SchoolContext : DbContext
{
    public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }

    public DbSet<Student> Students { get; set; }
    public DbSet<Class> Classes { get; set; }
    public DbSet<Section> Sections { get; set; }
    public DbSet<AcademicYear> AcademicYears { get; set; }
    public DbSet<Exam> Exams { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<StudentMark> StudentMarks { get; set; }
}
