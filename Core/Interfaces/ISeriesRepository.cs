using Core.Entities;

namespace Core.Interfaces
{
    public interface ISeriesRepository
    {
        Task<Series> GetSeriesByIdAsync(int id);
        Task<List<Series>> GetSeriesAsync();
        Task<Series> UpdateSeriesByIdAsync(int id);
        Task<Series> DeleteSeriesByIdAsync(int id);
        Task<Series> CreateSeriesByIdAsync(int id);

    }
}
