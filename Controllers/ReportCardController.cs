[ApiController]
[Route("api/[controller]")]
public class ReportCardController : ControllerBase
{
    private readonly SchoolContext _context;

    public ReportCardController(SchoolContext context)
    {
        _context = context;
    }

    [HttpPost("GetReportCards")]
    public IActionResult GetReportCards([FromBody] List<int> studentIds)
    {
        var reportCards = _context.Students
            .Where(s => studentIds.Contains(s.StudentId))
            .Select(s => new
            {
                s.StudentId,
                s.Name,
                ClassName = s.Class.ClassName,
                SectionName = s.Section.SectionName,
                AcademicYear = s.AcademicYear.Year,
                Exams = _context.StudentMarks
                    .Where(sm => sm.StudentId == s.StudentId)
                    .GroupBy(sm => new { sm.ExamId, sm.Exam.ExamName })
                    .Select(g => new
                    {
                        ExamId = g.Key.ExamId,
                        ExamName = g.Key.ExamName,
                        Subjects = g.Select(sm => new
                        {
                            sm.SubjectId,
                            SubjectName = sm.Subject.SubjectName,
                            sm.MarksObtained,
                            sm.MaximumMarks
                        }).ToList(),
                        TotalMarksObtained = g.Sum(sm => sm.MarksObtained),
                        TotalMaximumMarks = g.Sum(sm => sm.MaximumMarks),
                        Percentage = (double)g.Sum(sm => sm.MarksObtained) * 100 / g.Sum(sm => sm.MaximumMarks)
                    }).ToList()
            }).ToList();

        return Ok(reportCards);
    }
}
