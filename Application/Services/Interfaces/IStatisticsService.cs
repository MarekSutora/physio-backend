using Shared.DTO.Statistics.Response;

namespace Application.Services.Interfaces
{
    public interface IStatisticsService
    {

        Task<IEnumerable<ServiceTypeMonthlyStatisticsDto>> GetServiceTypesFinishedAppointmentsCountsAsync();

        Task<IEnumerable<RevenueStatisticsDto>> GetTotalRevenueStatisticsAsync();

        Task<IEnumerable<NewClientsStatisticsDto>> GetNewClientsTrendAsync();

        Task<IEnumerable<BlogPostViewsStatsDto>> GetBlogPostViewsStatsAsync();

    }
}
