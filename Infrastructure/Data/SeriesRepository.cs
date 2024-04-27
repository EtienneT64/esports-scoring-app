using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class SeriesRepository : ISeriesRepository
    {
        private readonly ScoringContext _context;
        public SeriesRepository(ScoringContext context)
        {
            _context = context;
        }

        public async Task<Series> GetSeriesByIdAsync(int id)
        {
            return await _context.Series.FindAsync(id);
        }

        public async Task<List<Series>> GetSeriesAsync()
        {
            return await _context.Series.ToListAsync();
        }

    }
}
