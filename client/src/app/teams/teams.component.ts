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
  newTeam: Team = { name: '', numPlayers: 0 };
  showCreateForm = false;
  selectedTeam: Team | null = null;
  editedTeam: Team = { id: 0, name: '', numPlayers: 0 };

  constructor(private matchingService: MatchingService) {}

  ngOnInit(): void {
    this.getTeams();
  }

  getTeams() {
    this.matchingService.getTeams().subscribe({
      next: (response: any) => {
        this.teams = response;
      },
      error: (error) => console.log(error),
    });
  }

  onDelete(id: number | undefined) {
    this.matchingService.deleteTeam(id).subscribe({
      next: () => {
        this.getTeams();
      },
      error: (error) => {
        console.log(`Error deleting team with Id ${id}:`, error);
      },
    });
  }

  toggleCreateForm() {
    this.showCreateForm = !this.showCreateForm;
    if (!this.showCreateForm) {
      this.resetForm();
    }
  }

  onSubmit() {
    this.matchingService.createTeam(this.newTeam).subscribe(() => {
      this.getTeams();
      this.resetForm();
    });
  }

  cancelCreate() {
    this.showCreateForm = false;
    this.resetForm();
  }

  resetForm() {
    this.newTeam = { name: '', numPlayers: 0 };
    this.showCreateForm = false;
  }

  toggleEditForm(team: Team) {
    this.selectedTeam = team;
    this.editedTeam = { ...team };
  }

  onSubmitEdit() {
    this.matchingService
      .updateTeam(this.editedTeam.id, this.editedTeam)
      .subscribe((updatedTeam: Team) => {
        const index = this.teams.findIndex(
          (team) => team.id === updatedTeam.id
        );
        if (index !== -1) {
          this.teams[index] = updatedTeam;
        }
        this.cancelEdit();
      });
  }

  cancelEdit() {
    this.selectedTeam = null;
    this.editedTeam = { id: 0, name: '', numPlayers: 0 };
  }
}
