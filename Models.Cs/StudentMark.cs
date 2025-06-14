public class StudentMark
{
    public int StudentMarkId { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; }
    public int ExamId { get; set; }
    public Exam Exam { get; set; }
    public int SubjectId { get; set; }
    public Subject Subject { get; set; }
    public int MarksObtained { get; set; }
    public int MaximumMarks { get; set; }
}
