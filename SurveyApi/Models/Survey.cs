public class Survey
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<Answer> Answers { get; set; } = new List<Answer>();
}
