import { Component } from '@angular/core';
import { Team } from '../shared/models/team';
import { MatchingService } from '../shared/matching.service';

@Component({
  selector: 'app-teams',
  templateUrl: './teams.component.html',
  styleUrl: './teams.component.scss',
})
export class TeamsComponent {
  teams: Team[] = [];

  constructor(private matchingService: MatchingService) {}

  ngOnInit(): void {
    this.matchingService.getTeams().subscribe({
      next: (response: any) => {
        console.log(response);
        this.teams = response;
      },
      error: (error) => console.log(error),
    });
  }
}
