# Proyecto Encuesta – Prueba Técnica 2026

Este proyecto implementa una solución completa para la gestión de encuestas, incluyendo backend y frontend desacoplados.

## 🧱 Arquitectura
El proyecto se divide en dos aplicaciones independientes:

/SurveyApi → Backend (.NET 8)
/survey-front → Frontend (Angular 19)

markdown
Copiar código

## 🔄 Flujo de la aplicación
1. El frontend obtiene las preguntas desde la API
2. El usuario responde la encuesta
3. Las respuestas se almacenan en el backend
4. El frontend consulta resultados agregados
5. Los resultados se muestran en una tabla

## 🛠️ Tecnologías
### Backend
- .NET 8
- ASP.NET Core Web API
- EF Core InMemory
- Swagger

### Frontend
- Angular 19
- Standalone Components
- Bootstrap
- Reactive Forms

## 🚀 Cómo ejecutar el proyecto

### Backend
```bash
cd SurveyApi
dotnet run
Frontend
bash
cd survey-front
npm install
ng serve
🧠 Consideraciones
Se priorizó claridad, arquitectura y buenas prácticas

El uso de InMemory simplifica la ejecución para fines de evaluación

La solución es fácilmente extensible a otros motores de base de datos

📌 Autor
Mateo Bonilla