import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class SurveyService {
  private apiUrl = 'http://localhost:5201/api/surveys';

  constructor(private http: HttpClient) {}
  
  getComments() {
    return this.http.get<any[]>(`${this.apiUrl}/comments`);
  }
  getQuestions(): Observable<any[]> {
    return this.http.get<any[]>(`${this.apiUrl}/questions`);
  }

  submitSurvey(payload: any): Observable<any> {
    return this.http.post(this.apiUrl, payload);
  }

  getResults(): Observable<any[]> {
    return this.http.get<any[]>(`${this.apiUrl}/results`);
  }
}
