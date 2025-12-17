public class Question
{
    public int Id { get; set; }
    public string Text { get; set; } = null!;
    public string Category { get; set; } = null!; // PsychologicalSafety, Voice, Silence
}