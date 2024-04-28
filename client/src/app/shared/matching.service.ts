import { HttpClient } from '@angular/common/http';
import { Injectable, OnInit } from '@angular/core';
import { Series } from './models/series';
import { Team } from './models/team';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class MatchingService {
  constructor(private http: HttpClient) {}

  getSeries() {
    return this.http.get<Series>('https://localhost:7060/api/series');
  }

  getTeams() {
    return this.http.get<Series>('https://localhost:7060/api/teams');
  }

  updateTeam(id: number | undefined, updatedTeamData: Partial<Team>): Observable<Team> {
    return this.http.put<Team>(
      `https://localhost:7060/api/teams/${id}`,
      updatedTeamData
    );
  }

  deleteTeam(id: number | undefined): Observable<any> {
    return this.http.delete(`https://localhost:7060/api/teams/${id}`);
  }

  createTeam(team: Team): Observable<Team> {
    return this.http.post<any>(`https://localhost:7060/api/teams`, team);
  }
}
