using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace SurveyApi.Controllers;

[ApiController]
[Route("api/surveys")]
public class SurveyController : ControllerBase
{
    private readonly AppDbContext _context;

    public SurveyController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("ping")]
    public IActionResult Ping()
    {
        return Ok("Survey API is running");
    }


    [HttpPost]
    public async Task<IActionResult> CreateSurvey([FromBody] SurveyRequestDto request)
    {
        if (request.Answers == null || !request.Answers.Any())
            return BadRequest("No answers provided");

        var survey = new Survey();

        foreach (var answer in request.Answers)
        {
            survey.Answers.Add(new Answer
            {
                QuestionId = answer.QuestionId,
                Value = answer.Value
            });
        }

        _context.Surveys.Add(survey);
        await _context.SaveChangesAsync();

        return Ok(new { message = "Survey saved successfully" });
    }


    [HttpGet("results")]
    public IActionResult GetResults()
    {
        var results = _context.Answers
            .Join(
                _context.Questions,
                answer => answer.QuestionId,
                question => question.Id,
                (answer, question) => new
                {
                    question.Text,
                    answer.Value
                }
            )
            .GroupBy(x => x.Text)
            .Select(g => new
            {
                Question = g.Key,
                Results = g
                    .GroupBy(x => x.Value)
                    .Select(v => new
                    {
                        Value = v.Key,
                        Count = v.Count()
                    })
                    .OrderBy(v => v.Value)
                    .ToList()
            })
            .ToList();

        return Ok(results);
    }

    [HttpGet("questions")]
    public IActionResult GetQuestions()
    {
        var questions = _context.Questions
            .Select(q => new
            {
                q.Id,
                q.Text,
                q.Category
            })
            .OrderBy(q => q.Category)
            .ToList();

        return Ok(questions);
    }
}
