using Core.Entities;

namespace Core.Interfaces
{
    public interface ITeamsRepository
    {
        Task<Team> GetTeamByIdAsync(int id);
        Task<List<Team>> GetTeamsAsync();
        Task<Team> UpdateTeamByIdAsync(Team team);
        Task<Team> DeleteTeamByIdAsync(int id);
        Task<Team> CreateTeamByIdAsync(Team team);
    }
}
