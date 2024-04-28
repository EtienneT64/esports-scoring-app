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

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTeam(int id, Team team)
        {
            if (id != team.Id)
            {
                return BadRequest();
            }

            var existingTeam = await _teamsRepository.GetTeamByIdAsync(id);
            if (existingTeam == null)
            {
                return NotFound();
            }

            existingTeam.Name = team.Name ?? existingTeam.Name;
            existingTeam.NumPlayers = team.NumPlayers;

            var updatedTeam = await _teamsRepository.UpdateTeamByIdAsync(existingTeam);

            return Ok(updatedTeam);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeam(int id)
        {
            var team = await _teamsRepository.GetTeamByIdAsync(id);
            if (team == null)
            {
                return NotFound();
            }

            await _teamsRepository.DeleteTeamByIdAsync(id);

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTeam([FromBody] Team team)
        {
            if (team == null)
            {
                return BadRequest("Team data is null.");
            }

            var createdTeam = await _teamsRepository.CreateTeamAsync(team);

            if (createdTeam == null)
            {
                return StatusCode(500, "An error occurred while creating the team.");
            }

            return Ok(createdTeam);
        }

    }

}
