import { Routes } from '@angular/router';
import { SurveyComponent } from './pages/survey/survey.component';
import { ResultsComponent } from './pages/results/results.component';

export const routes: Routes = [
  { path: '', redirectTo: 'survey', pathMatch: 'full' },
  { path: 'survey', component: SurveyComponent },
  { path: 'results', component: ResultsComponent },
];
