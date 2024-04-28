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
        this.series = response;
      },
      error: (error) => console.log(error),
    });
  }

  displayBestOf(firstToWins: number) {
    switch (firstToWins) {
      case 1:
        return 'Bo1';

      case 2:
        return 'Bo3';

      case 3:
        return 'Bo5';

      default:
        return 'N/A';
    }
  }
}
