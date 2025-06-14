public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int ClassId { get; set; }
    public Class Class { get; set; }
    public int SectionId { get; set; }
    public Section Section { get; set; }
    public int AcademicYearId { get; set; }
    public AcademicYear AcademicYear { get; set; }
}
