import { HttpClient } from '@angular/common/http';
import { Injectable, OnInit } from '@angular/core';
import { Series } from './models/series';

@Injectable({
  providedIn: 'root',
})
export class MatchingService {
  series: Series[] = [];

  constructor(private http: HttpClient) {}

  getSeries() {
    return this.http.get<Series>('https://localhost:7060/api/series');
  }
}
