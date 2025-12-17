# Survey API

Backend REST API desarrollada en **.NET 8** para la gestión de encuestas de clima de equipo.

## 🧩 Funcionalidad
La API permite:
- Obtener las preguntas de la encuesta
- Registrar una encuesta completa con múltiples respuestas
- Consultar resultados agregados por pregunta

## 🛠️ Tecnologías
- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- Base de datos InMemory
- Swagger

## 🚀 Ejecución
Desde la carpeta del proyecto:

```bash
dotnet run
La API estará disponible en:

http://localhost:5201

Swagger: http://localhost:5201/swagger

📌 Endpoints
Obtener preguntas
bash
GET /api/surveys/questions
Registrar encuesta
bash
POST /api/surveys
Payload ejemplo:

json
{
  "answers": [
    { "questionId": 1, "value": 4 },
    { "questionId": 2, "value": 5 }
  ]
}
Resultados agregados
bash
GET /api/surveys/results
Devuelve el conteo de respuestas por valor para cada pregunta.

💾 Persistencia
Se utiliza Entity Framework Core InMemory para simplificar la ejecución en un entorno de evaluación técnica.
Los datos se mantienen mientras la aplicación está en ejecución.

🔐 CORS
La API permite peticiones desde:

http://localhost:4200

🧠 Decisiones técnicas
Separación entre entidades y DTOs

No dependencia de propiedades de navegación

Endpoints orientados a consumo por frontend