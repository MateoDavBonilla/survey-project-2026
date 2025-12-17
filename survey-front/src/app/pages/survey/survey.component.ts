import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  FormBuilder,
  FormGroup,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { SurveyService } from '../../services/survey.service';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-survey',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule, RouterLink],
  templateUrl: './survey.component.html',
})
export class SurveyComponent implements OnInit {
  questions: any[] = [];
  form!: FormGroup;
  submitted = false;
  showModal = false;
  constructor(private fb: FormBuilder, private surveyService: SurveyService) {}

  ngOnInit(): void {
    this.surveyService.getQuestions().subscribe((qs) => {
      this.questions = qs;

      const controls: any = {};
      qs.forEach((q) => (controls[q.id] = ['', Validators.required]));
      controls['comment'] = [''];
      this.form = this.fb.group(controls);
    });
  }

  submit(): void {
    if (this.form.invalid) return;

    const answers = Object.keys(this.form.value)
      .filter((key) => key !== 'comment')
      .map((key) => ({
        questionId: Number(key),
        value: this.form.value[key],
      }));

    const payload = {
      answers,
      comment: this.form.value.comment,
    };

    this.surveyService.submitSurvey(payload).subscribe(() => {
      this.showModal = true;
    });
  }
  closeModal(): void {
    this.showModal = false;
    this.form.reset();
  }
}
