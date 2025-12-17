import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SurveyService } from '../../services/survey.service';

@Component({
  selector: 'app-results',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './results.component.html',
})
export class ResultsComponent implements OnInit {
  results: any[] = [];
  comments: any[] = [];
  loadingComments = true;
  constructor(private surveyService: SurveyService) {}

  ngOnInit(): void {
    this.surveyService.getResults().subscribe((data) => {
      this.results = data;
    });

    this.surveyService.getComments().subscribe((data) => {
      this.comments = data;
      this.loadingComments = false;
    });
  }

  getCount(results: any[], value: number): number {
    const found = results.find((r) => r.value === value);
    return found ? found.count : 0;
  }
}
