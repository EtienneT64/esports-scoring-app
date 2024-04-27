using Core.Entities;

namespace Core.Interfaces
{
    public interface ISeriesRepository
    {
        Task<Series> GetSeriesByIdAsync(int id);
        Task<List<Series>> GetSeriesAsync();
    }
}
