using API.Dtos;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class SeriesController : BaseApiController
    {
        private readonly ISeriesRepository _seriesRepository;
        public SeriesController(ISeriesRepository seriesRepository)
        {
            _seriesRepository = seriesRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<SeriesToReturnDto>>> GetSeries()
        {
            var series = await _seriesRepository.GetSeriesAsync();

            return series.Select(series => new SeriesToReturnDto
            {
                Id = series.Id,
                Title = series.Title,
                Date = series.Date,
                FirstToWins = series.FirstToWins,
                TeamOneScore = series.TeamOneScore,
                TeamTwoScore = series.TeamTwoScore,
                Victor = series.Victor?.Name,
                TeamOne = series.Teams?.FirstOrDefault()?.Name,
                TeamTwo = series.Teams?.Skip(1).FirstOrDefault()?.Name,
                Matches = series.Matches?.Select(x => x.Id).ToList()
            }).ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SeriesToReturnDto>> GetSeries(int id)
        {
            var series = await _seriesRepository.GetSeriesByIdAsync(id);

            return new SeriesToReturnDto
            {
                Id = series.Id,
                Title = series.Title,
                Date = series.Date,
                FirstToWins = series.FirstToWins,
                TeamOneScore = series.TeamOneScore,
                TeamTwoScore = series.TeamTwoScore,
                Victor = series.Victor?.Name,
                TeamOne = series.Teams?.FirstOrDefault()?.Name,
                TeamTwo = series.Teams?.Skip(1).FirstOrDefault()?.Name,
                Matches = series.Matches?.Select(x => x.Id).ToList()
            };
        }
    }
}
