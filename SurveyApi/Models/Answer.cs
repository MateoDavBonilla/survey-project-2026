public class Answer
{
    public int Id { get; set; }

    public int SurveyId { get; set; }
    public Survey Survey { get; set; } = null!;

    public int QuestionId { get; set; }
    public Question Question { get; set; } = null!;

    public int Value { get; set; } // 1–5
}
