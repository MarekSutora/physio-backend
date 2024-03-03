using Shared.DTO.Statistics.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
