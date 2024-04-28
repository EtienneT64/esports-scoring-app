using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class TeamsController : BaseApiController
    {
        private readonly ITeamsRepository _teamsRepository;
        public TeamsController(ITeamsRepository teamsRepository)
        {
            _teamsRepository = teamsRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Team>>> GetTeams()
        {
            var teams = await _teamsRepository.GetTeamsAsync();
            return Ok(teams);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Team>> GetTeam(int id)
        {
            var team = await _teamsRepository.GetTeamByIdAsync(id);
            return Ok(team);
        }
    }
}
