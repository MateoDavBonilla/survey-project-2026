# 📄 README — Frontend (`survey-front/README.md`)

```md
# Survey Frontend

Aplicación frontend desarrollada con **Angular 19 (standalone)** para responder encuestas y visualizar resultados.

## 🧩 Funcionalidad
- Visualización dinámica de preguntas
- Formulario reactivo para responder la encuesta
- Envío de respuestas al backend
- Visualización de resultados agregados
- Modal de confirmación al enviar la encuesta

## 🛠️ Tecnologías
- Angular 19
- Standalone Components
- Reactive Forms
- Bootstrap 5
- HttpClient

## 🚀 Ejecución
Desde la carpeta del proyecto:

```bash
npm install
ng serve
La aplicación estará disponible en:

http://localhost:4200

📌 Navegación
/survey → Formulario de encuesta

/results → Resultados agregados

🧠 Decisiones técnicas
Uso de componentes standalone (sin NgModules)

Formularios dinámicos basados en datos del backend

Lógica separada de la vista

Modal controlado por estado de Angular