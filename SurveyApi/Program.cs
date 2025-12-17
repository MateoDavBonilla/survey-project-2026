using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("SurveyDb"));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy =>
        {
            policy
                .WithOrigins("http://localhost:4200")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

var app = builder.Build();

// Seed de datos
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    if (!context.Questions.Any())
    {
        context.Questions.AddRange(
            new Question { Text = "Me siento seguro expresando mis ideas", Category = "PsychologicalSafety" },
            new Question { Text = "Puedo pedir ayuda sin miedo", Category = "PsychologicalSafety" },
            new Question { Text = "Propongo ideas para mejorar el trabajo", Category = "Voice" },
            new Question { Text = "Hablo cuando detecto problemas", Category = "Voice" },
            new Question { Text = "Evito expresar ideas por miedo", Category = "Silence" }
        );

        context.SaveChanges();
    }
}

// HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAngular");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
