import { Component, OnInit } from '@angular/core';
import { Series } from '../shared/models/series';
import { MatchingService } from '../shared/matching.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss',
})
export class HomeComponent implements OnInit {
  series: Series[] = [];

  constructor(private matchingService: MatchingService) {}

  ngOnInit(): void {
    this.matchingService.getSeries().subscribe({
      next: (response: any) => {
        console.log(response);
        this.series = response;
      },
      error: (error) => console.log(error),
    });
  }
}
