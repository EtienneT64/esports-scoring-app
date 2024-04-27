using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class SeriesController : ControllerBase
    {
        private readonly ISeriesRepository _seriesRepository;
        public SeriesController(ISeriesRepository seriesRepository)
        {
            _seriesRepository = seriesRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Series>>> GetSeries()
        {
            var series = await _seriesRepository.GetSeriesAsync();

            return Ok(series);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Series>> GetSeries(int id)
        {
            return await _seriesRepository.GetSeriesByIdAsync(id);
        }
    }
}
