public static class DataSeeder
{
    public static void Seed(AppDbContext context)
    {
        if (context.Questions.Any())
            return;

        context.Questions.AddRange(
            new Question
            {
                Text = "Me siento seguro expresando mis ideas en el equipo",
                Category = "PsychologicalSafety"
            },
            new Question
            {
                Text = "Puedo pedir ayuda sin miedo a consecuencias negativas",
                Category = "PsychologicalSafety"
            },
            new Question
            {
                Text = "Propongo ideas para mejorar la forma de trabajar",
                Category = "Voice"
            },
            new Question
            {
                Text = "Hablo cuando detecto problemas que pueden afectar al equipo",
                Category = "Voice"
            },
            new Question
            {
                Text = "Evito expresar ideas por miedo a reacciones negativas",
                Category = "Silence"
            }
        );

        context.SaveChanges();
    }
}