var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<SchoolContext>(options => options.UseInMemoryDatabase("SchoolDb"));

var app = builder.Build();

// Seed data
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<SchoolContext>();

    var class1 = new Class { ClassId = 1, ClassName = "10th Grade" };
    var sectionA = new Section { SectionId = 1, SectionName = "A" };
    var year2025 = new AcademicYear { AcademicYearId = 1, Year = "2024-2025" };

    var exam1 = new Exam { ExamId = 1, ExamName = "Mid Term" };
    var exam2 = new Exam { ExamId = 2, ExamName = "Final" };

    var math = new Subject { SubjectId = 1, SubjectName = "Mathematics" };
    var science = new Subject { SubjectId = 2, SubjectName = "Science" };

    var student1 = new Student { StudentId = 1, Name = "John Doe", Class = class1, Section = sectionA, AcademicYear = year2025 };
    var student2 = new Student { StudentId = 2, Name = "Jane Smith", Class = class1, Section = sectionA, AcademicYear = year2025 };

    context.Classes.Add(class1);
    context.Sections.Add(sectionA);
    context.AcademicYears.Add(year2025);
    context.Exams.AddRange(exam1, exam2);
    context.Subjects.AddRange(math, science);
    context.Students.AddRange(student1, student2);

    context.StudentMarks.AddRange(
        new StudentMark { StudentId = 1, Exam = exam1, Subject = math, MarksObtained = 80, MaximumMarks = 100 },
        new StudentMark { StudentId = 1, Exam = exam1, Subject = science, MarksObtained = 75, MaximumMarks = 100 },
        new StudentMark { StudentId = 1, Exam = exam2, Subject = math, MarksObtained = 85, MaximumMarks = 100 },
        new StudentMark { StudentId = 1, Exam = exam2, Subject = science, MarksObtained = 78, MaximumMarks = 100 },

        new StudentMark { StudentId = 2, Exam = exam1, Subject = math, MarksObtained = 70, MaximumMarks = 100 },
        new StudentMark { StudentId = 2, Exam = exam1, Subject = science, MarksObtained = 72, MaximumMarks = 100 },
        new StudentMark { StudentId = 2, Exam = exam2, Subject = math, MarksObtained = 90, MaximumMarks = 100 },
        new StudentMark { StudentId = 2, Exam = exam2, Subject = science, MarksObtained = 88, MaximumMarks = 100 }
    );

    context.SaveChanges();
}

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
