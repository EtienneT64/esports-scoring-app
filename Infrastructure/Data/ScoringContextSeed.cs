using System.Text.Json;
using Core.Entities;

namespace Infrastructure.Data
{
    public class ScoringContextSeed
    {
        public static async Task SeedAsync(ScoringContext context)
        {
            if (!context.Series.Any())
            {
                var seriesData = File.ReadAllText("../Infrastructure/Data/SeedData/series.json");
                var series = JsonSerializer.Deserialize<List<Series>>(seriesData);
                context.Series.AddRange(series);
            }

            if (!context.Matches.Any())
            {
                var matchesData = File.ReadAllText("../Infrastructure/Data/SeedData/matches.json");
                var matches = JsonSerializer.Deserialize<List<Match>>(matchesData);
                context.Matches.AddRange(matches);
            }

            if (!context.Rounds.Any())
            {
                var roundsData = File.ReadAllText("../Infrastructure/Data/SeedData/rounds.json");
                var rounds = JsonSerializer.Deserialize<List<Round>>(roundsData);
                context.Rounds.AddRange(rounds);
            }

            if (!context.Teams.Any())
            {
                var teamsData = File.ReadAllText("../Infrastructure/Data/SeedData/teams.json");
                var teams = JsonSerializer.Deserialize<List<Team>>(teamsData);
                context.Teams.AddRange(teams);
            }

            if (!context.TeamMembers.Any())
            {
                var teamMembersData = File.ReadAllText("../Infrastructure/Data/SeedData/teamMembers.json");
                var teamMembers = JsonSerializer.Deserialize<List<TeamMember>>(teamMembersData);
                context.TeamMembers.AddRange(teamMembers);
            }

            if (context.ChangeTracker.HasChanges()) await context.SaveChangesAsync();
        }
    }
}
