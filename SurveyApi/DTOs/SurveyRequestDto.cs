
public class SurveyRequestDto
{
    public List<AnswerDto> Answers { get; set; } = new();
    public string? Comment { get; set; }
}
