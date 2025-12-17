using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Question> Questions => Set<Question>();
    public DbSet<Survey> Surveys => Set<Survey>();
    public DbSet<Answer> Answers => Set<Answer>();
}
